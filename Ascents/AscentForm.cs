using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascents
{
    public partial class AscentForm : Form
    {
        BindingList<Group> m_group;
        BindingList<AbstractPerson> m_persons;
        private long m_id;
        public AscentForm(long id = 0)
        {
            InitializeComponent();
            m_group = new BindingList<Group>();
            m_persons = new BindingList<AbstractPerson>();
            m_id = id;
        }
        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mountain32;

            List<AbstractPerson> prclst = await Program.m_helper.GetFilteredPersons();
            foreach (AbstractPerson prc in prclst)
            {
                m_persons.Add(prc);
            }
            personsComboBox.DataSource = m_persons;
            if (personsComboBox.Items.Count > 0)
                personsComboBox.SelectedIndex = 0;

            if (m_id > 0)
            {
                Ascent ascent = Program.m_helper.GetAscentByID(m_id);
                if (ascent != null)
                {
                    ascentdateTimePicker.Value = ascent.ascdate;
                    PeakMountain pm = Program.m_helper.GetPeakMountainByID(ascent.idpeak);
                    if (pm != null)
                    {
                        peakChoiceButton.Enabled = false;
                        peakNameTextBox.Text = pm.ToString();
                        peakNameTextBox.ReadOnly = true;
                        peakNameTextBox.Tag = pm.id;
                    }
                    commentsTextBox.Text = Program.m_helper.GetAscentComments(m_id);
                    List<Group> lgp = await Program.m_helper.GetAscentGroup(m_id);
                    foreach (Group gp in lgp)
                    {
                        m_group.Add(gp);
                    }
                }                
            }

            personsDataGridView.DataSource = m_group;
        }
        void SortPersons()
        {
            List<AbstractPerson> lst = m_persons.OrderBy(p => p.name).ToList();
            m_persons.Clear();
            foreach(AbstractPerson prc in lst)
            {
                m_persons.Add(prc);
            }
        }
        /// <summary>
        /// Добавить альпиниста в группу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            AbstractPerson prc = personsComboBox.SelectedItem as AbstractPerson;
            if(prc != null)
            {
                Group grp = new Group();
                grp.id = prc.id;
                grp.name = prc.name;
                grp.leader = false;
                m_group.Add(grp);
                m_persons.Remove(prc);
            }
        }
        /// <summary>
        /// Удалить альпиниста из группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delPersonButton_Click(object sender, EventArgs e)
        {
            var row = personsDataGridView.CurrentRow;
            if (row != null)
            {
                long id = Convert.ToInt64(row.Cells["id"].Value);
                foreach (Group grp in m_group)
                {
                    if (grp.id == id) 
                    {
                        AbstractPerson prc = new AbstractPerson();
                        prc.id = grp.id;
                        prc.name = grp.name;
                        m_persons.Add(prc);
                        SortPersons();
                        m_group.Remove(grp);
                        break; 
                    }
                }
            }
        }
        /// <summary>
        /// Назначить альпиниста руководителем группы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chiefSetButton_Click(object sender, EventArgs e)
        {
            var row = personsDataGridView.CurrentRow;
            if (row != null)
            {
                foreach (Group grp in m_group)
                {
                    grp.leader = false;
                }
                long id = Convert.ToInt64(row.Cells["id"].Value);
                foreach (Group grp in m_group)
                {
                    if (grp.id == id) { grp.leader = true; personsDataGridView.Refresh(); break; }

                }
            }
        }
        /// <summary>
        /// Удалить или править запись о восхождении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptButton_Click(object sender, EventArgs e)
        {
            DateTime dt = ascentdateTimePicker.Value;
            long idpeak = Convert.ToInt64(peakNameTextBox.Tag);
            string comments = commentsTextBox.Text;
            List<Group> glst = m_group.ToList();
            if(glst.Count < 1)
            {
                MessageBox.Show("Группа альпинистов должна состоять хотя бы из одного человека");
                DialogResult = DialogResult.Cancel;
                return;
            }
            int nrec = m_id > 0 ? Program.m_helper.UpdateAscent(m_id, dt, comments, glst) 
                : Program.m_helper.AddAscent(idpeak, dt, comments, glst);
            if(nrec < 1)
            {
                Program.DBErrorMessage();
                DialogResult = DialogResult.Cancel;
            }
        }
        /// <summary>
        /// Выбор вершины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void peakChoiceButton_Click(object sender, EventArgs e)
        {
            PeakForm frm = new PeakForm(true);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                peakNameTextBox.Text = frm.peak.ToString();
                peakNameTextBox.Tag = frm.peak.id;
            }
        }
    }
}
