using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisabilityList
{
    public partial class PatientForm : Form
    {
        long m_id;
        bool m_selmode;
        const string EMPTY_SNILS_TRIMMED = "-   -";
        public long id { get { return m_id; } }

        public PatientForm(long id = 0, bool sel_mode = false)
        {
            InitializeComponent();
            m_id = id;
            m_selmode = sel_mode;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.patient32;
            var lst =  await Program.m_helper.GetPatients();
            if (lst.IsNullOrEmpty()) return;
            name_comboBox.DataSource = lst;

            Patient p = m_id > 0 ? lst.FirstOrDefault(el => el.id == m_id) : (lst.IsNullOrEmpty() ? null : lst[0]);
            if (p != null)
            {
                int idx = GetIndexByID(name_comboBox, p.id);
                if (idx >= 0)
                    name_comboBox.SelectedIndex = idx;
            }

            if (m_selmode)
            {
                name_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                add_button.Text = "ОК";
                edit_button.Text = "Отмена";
                delete_button.Visible = false;
            }

        }

        /// <summary>
        /// Найти индекс в списке по идентификатору в БД
        /// </summary>
        /// <param name="cmb">Выпвдвющий список</param>
        /// <returns>индекс в списке, -1 е найден</returns>
        private int GetIndexByID(ComboBox cmb, long id)
        {
            int idx = -1;
            if (cmb == name_comboBox)
            {
                foreach (var el in name_comboBox.Items)
                {
                    Patient p = el as Patient;
                    if (p != null)
                    {
                        if (p.id == id) return ++idx;
                    }
                    idx++;
                }
            }            
            return -1;
        }

        private void OnNameChanged(object sender, EventArgs e)
        {
            int idx = name_comboBox.SelectedIndex;
            if (idx < 0) return;
            Patient p = name_comboBox.Items[idx] as Patient;
            if (p != null)
            {
                m_id = p.id;
                birthDate_dateTimePicker.Value = p.birth_date;

                inn_maskedTextBox.Text = p.inn;
                relative_checkBox.Checked = string.IsNullOrEmpty(p.inn.Trim());

                snils_maskedTextBox.Text = p.snils;

                passport_textBox.Text = p.passport;
            }
        }

        private async void add_button_Click(object sender, EventArgs e)
        {
            if(m_selmode)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                string _name = name_comboBox.Text;
                if(string.IsNullOrEmpty(_name))
                {
                    Program.ShowErrorMessage("Не заданы ФИО пациента");
                    return;
                }
                string _inn = inn_maskedTextBox.Text;
                if(!relative_checkBox.Checked &&  (string.IsNullOrEmpty(_inn) || _inn.Length < 12))
                {
                    Program.ShowErrorMessage("Неверно задан ИНН");
                    return;
                }
                string _snils = snils_maskedTextBox.Text;
                if (!relative_checkBox.Checked && (string.IsNullOrEmpty(_snils) || _snils.Length < 14))
                {
                    Program.ShowErrorMessage("Неверно задан ИНН");
                    return;
                }
                if (relative_checkBox.Checked && _snils.Trim() == EMPTY_SNILS_TRIMMED)
                    _snils = string.Empty;


                    string _passport = passport_textBox.Text;
                if (!relative_checkBox.Checked && (string.IsNullOrEmpty(_passport)))
                {
                    Program.ShowErrorMessage("Неверно задан ИНН");
                    return;
                }

                DateTime bd = birthDate_dateTimePicker.Value;

                Patient p = new Patient
                {
                    id = 0,
                    name = _name,
                    birth_date = bd,
                    inn = _inn,
                    snils = _snils,
                    passport = _passport
                };

                int recs = Program.m_helper.AddPatient(p);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetPatients();
                    name_comboBox.DataSource = lst;
                    if (!lst.IsNullOrEmpty())
                    {
                        int idx = name_comboBox.FindString(_name);
                        if (idx >= 0)
                            name_comboBox.SelectedIndex = idx; 
                    }

                }

            }
        }

        private async void edit_button_Click(object sender, EventArgs e)
        {
            if (m_selmode)
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
            else
            {
                string _name = name_comboBox.Text;
                if (string.IsNullOrEmpty(_name))
                {
                    Program.ShowErrorMessage("Не заданы ФИО пациента");
                    return;
                }
                string _inn = inn_maskedTextBox.Text;
                if (!relative_checkBox.Checked && (string.IsNullOrEmpty(_inn) || _inn.Length < 12))
                {
                    Program.ShowErrorMessage("Неверно задан ИНН");
                    return;
                }

                string _snils = snils_maskedTextBox.Text;
                if (!relative_checkBox.Checked && (string.IsNullOrEmpty(_snils) || _snils.Length < 14 || _snils.Trim() == EMPTY_SNILS_TRIMMED))
                {
                    Program.ShowErrorMessage("Неверно задан СНИЛС");
                    return;
                }
                if (_snils.Trim() == EMPTY_SNILS_TRIMMED)
                    _snils = string.Empty;

                string _passport = passport_textBox.Text;
                if (!relative_checkBox.Checked && (string.IsNullOrEmpty(_passport)))
                {
                    Program.ShowErrorMessage("Неверно задан ИНН");
                    return;
                }
                DateTime bd = birthDate_dateTimePicker.Value;

                Patient p = new Patient
                {
                    id = m_id,
                    name = _name,
                    birth_date = bd,
                    inn = _inn,
                    snils = _snils,
                    passport = _passport
                };

                int recs = Program.m_helper.UpdatePatient(p);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetPatients();
                    name_comboBox.DataSource = lst;
                    if (!lst.IsNullOrEmpty())
                    {
                        int idx = name_comboBox.FindString(_name);
                        if (idx >= 0)
                            name_comboBox.SelectedIndex = idx;
                    }

                }
            }

        }

        private async void delete_button_Click(object sender, EventArgs e)
        {
            if (!m_selmode)
            {
                int recs = Program.m_helper.DeletePatient(m_id);
                if (recs < 1)
                    Program.DBErrorMessage();
                else
                {
                    var lst = await Program.m_helper.GetPatients();
                    name_comboBox.DataSource = lst;
                    if (!lst.IsNullOrEmpty())
                    {
                        name_comboBox.SelectedIndex = 0;
                    }

                }
            }

        }

        private void OnRelativeCheck(object sender, EventArgs e)
        {
            if (relative_checkBox.Checked)
            {
                inn_maskedTextBox.Text = string.Empty;
                snils_maskedTextBox.Text = EMPTY_SNILS_TRIMMED.PadLeft(3).PadRight(6);
                passport_textBox.Text = string.Empty;
            }
            
            inn_maskedTextBox.Enabled = !relative_checkBox.Checked;
            snils_maskedTextBox.Enabled = !relative_checkBox.Checked;
            passport_textBox.Enabled = !relative_checkBox.Checked;

        }
    }
}
