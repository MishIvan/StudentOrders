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
    public partial class PeakForm : Form
    {
        private bool m_selectionMode;
        private PeakMountain m_peak;
        private int m_selectedIndex;
        public Peak peak { get { return m_peak; } }
        public PeakForm(bool selMode = false) 
        {
            InitializeComponent();
            m_selectionMode = selMode;
            m_selectedIndex = -1;
        }

        private async void OnLoad(object sender, EventArgs e)
        {
            Icon = Properties.Resources.mountain32;
            if(m_selectionMode)
            {
                addButton.Text = "ОК";
                addButton.DialogResult = DialogResult.OK;
                editButton.Text = "Отмена";
                editButton.DialogResult = DialogResult.Cancel;

                AcceptButton = addButton;
                CancelButton = editButton;
                peakComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            List<Mountains> mlist = await Program.m_helper.GetMountains();
            mountainComboBox.DataSource = mlist;

            List<Peak> plist = await Program.m_helper.GetPeaks();
            peakComboBox.DataSource = plist;
        }
        /// <summary>
        /// Добавить или ОК в режиме выбора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void addButton_Click(object sender, EventArgs e)
        {
            if(!m_selectionMode)
            {
                double h = 0.0;
                try
                {
                    h = Convert.ToDouble(heightTextBox.Text);
                }
                catch(Exception)
                {
                    MessageBox.Show("Неверно задана высота вершины");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                Mountains mnt = mountainComboBox.SelectedItem as Mountains;
                if(mnt == null)
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                Peak pk = new Peak();
                pk.name = peakComboBox.Text;
                pk.idmountains = mnt.id;
                pk.height = h;
                pk.id = 0;
                if(Program.m_helper.AddPeak(pk) < 1)
                {
                    DialogResult = DialogResult.Cancel;
                    Program.DBErrorMessage();
                }
                else
                {
                    List<Peak> plist = await Program.m_helper.GetPeaks();
                    peakComboBox.DataSource = plist;
                    int idx = peakComboBox.FindString(pk.name);
                    if (idx >= 0)
                        peakComboBox.SelectedIndex = idx;
                }
            }

            // режим выбора записи
            else
            {
                Peak pk = peakComboBox.SelectedItem as Peak;
                if (peak != null)
                {
                    m_peak = Program.m_helper.GetPeakMountainByID(pk.id);
                    if(m_peak == null)
                    {
                        DialogResult = DialogResult.Cancel;
                        Program.DBErrorMessage();
                    }
                    else
                        DialogResult = DialogResult.OK;

                }
                else
                    DialogResult = DialogResult.Cancel;
                Close();
            }
        }
        /// <summary>
        /// Править вершину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void editButton_Click(object sender, EventArgs e)
        {
            if(!m_selectionMode)
            {
                double h = 0.0;
                try
                {
                    h = Convert.ToDouble(heightTextBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверно задана высота вершины");
                    DialogResult = DialogResult.Cancel;
                    return;
                }
                Mountains mnt = mountainComboBox.SelectedItem as Mountains;
                if (mnt == null)
                {
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                if (m_selectedIndex >= 0)
                {
                    Peak pke = new Peak();
                    pke.name = peakComboBox.Text;
                    pke.idmountains = mnt.id;
                    pke.height = h;
                    pke.id = (peakComboBox.Items[m_selectedIndex] as Peak).id;
                    if(Program.m_helper.UpdatePeak(pke) < 0)
                    {
                        DialogResult = DialogResult.Cancel;
                        Program.DBErrorMessage();
                    }
                    else
                    {
                        List<Peak> plist = await Program.m_helper.GetPeaks();
                        peakComboBox.DataSource = plist;
                        int idx = peakComboBox.FindString(pke.name);
                        if (idx >= 0)
                            peakComboBox.SelectedIndex = idx;
                    }
                }
            }
            else
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void OnPeakSelectionChanged(object sender, EventArgs e)
        {
            m_selectedIndex = peakComboBox.SelectedIndex;
            if (m_selectedIndex < 0) return;
            Peak pk = peakComboBox.Items[m_selectedIndex] as Peak;
            if(pk != null)
            {
                SelectMountains(pk.idmountains);
                heightTextBox.Text = pk.height.ToString();
            }

        }
        /// <summary>
        /// Выбрать горную систему
        /// </summary>
        /// <param name="id">id горной системы</param>
        private void SelectMountains(int id)
        {
            foreach(object item in mountainComboBox.Items)
            {
                Mountains mnt = item as Mountains;
                if(mnt != null)
                {
                    if(mnt.id == id)
                    {
                        mountainComboBox.SelectedItem = mnt;
                        break;
                    }
                }
            }
        }
    }
}
