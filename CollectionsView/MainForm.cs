using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionsView
{
    public partial class MainForm : Form
    {
        private BindingList<string> queueList;
        private BindingList<string> stackList;
        private BindingList<string> listList;

        private List<string> listData;
        private Queue<string> queueData;
        private Stack<string> stackData;
        public MainForm()
        {
            queueList = new BindingList<string>();
            stackList = new BindingList<string>();
            listList = new BindingList<string>();

            queueData = new Queue<string>();
            stackData = new Stack<string>();
            listData = new List<string>();

            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            StackContent.DataSource = stackList;
            QueueContent.DataSource = queueList;
            ListContent.DataSource = listList;
        }
        
        // втолкнуть в стэк
        private void OnPushStack(object sender, EventArgs e)
        {
            string s1 = StackElement.Text;
            if(!String.IsNullOrEmpty(s1) && !String.IsNullOrWhiteSpace(s1))
            {
                if(!IsStringInStack(s1))
                {
                    stackData.Push(s1);
                    if (stackData.Count < 1)
                        stackList.Add(s1);
                    else
                        stackList.Insert(0, s1);
                    StackContent.SelectedIndex = stackData.Count > 0 ? 0 : -1;
                }
                
            }

        }
        // вытолкнуть из стэка
        private void OnPopStack(object sender, EventArgs e)
        {
            if (stackData.Count > 0)
            {
                string s1 = stackData.Pop();
                stackList.RemoveAt(0);
                StackContent.SelectedIndex = stackData.Count > 0 ? 0 : -1;
                StackElement.Text = s1;
            }
        }
        // есть ли строка src в стэке
        private bool IsStringInStack(string src)
        {
            string s1 = stackList.FirstOrDefault(se => src == se);
            return s1 != null;
        }
        // есть ли строка src в очереди
        private bool IsStringInQueue(string src)
        {
            string s1 = queueList.FirstOrDefault(se => src == se);
            return s1 != null;
        }

        // добавить в хвост очереди
        private void OnSetInTail(object sender, EventArgs e)
        {
            string s1 = LastInLine.Text;
            if (!String.IsNullOrEmpty(s1) && !String.IsNullOrWhiteSpace(s1))
            {
                if (!IsStringInQueue(s1))
                {
                    queueData.Enqueue(s1);
                    queueList.Add(s1);
                    QueueContent.SelectedIndex = queueData.Count > 0 ? 0 : -1;
                    FirsInLine.Text = queueList.ElementAt(0);
                }

            }

        }
        // покинуть очередь
        private void OnQuitQueue(object sender, EventArgs e)
        {
            if (queueData.Count < 1) return;
            string s1 = queueData.Dequeue();
            queueList.RemoveAt(0);
            FirsInLine.Text = s1;
            QueueContent.SelectedIndex = queueData.Count > 0 ? 0 : -1;

        }
        // добавить элемент в список
        private void OnAddToList(object sender, EventArgs e)
        {
            string s1 = ListElementTextBox.Text;
            if(!String.IsNullOrEmpty(s1) && !String.IsNullOrWhiteSpace(s1))
            {
                listData.Add(s1);
                listList.Add(s1);
            }

        }
        // удалить элемент в списке
        private void OnDeleteFromList(object sender, EventArgs e)
        {
            string s1 = ListContent.SelectedItem.ToString();
            listData.Remove(s1);
            listList.Remove(s1);
        }
        // сортировать список
        private void OnSortList(object sender, EventArgs e)
        {
            listData.Sort((x, y) => { return String.Compare(x,y); });
            listList.Clear();
            foreach (string s1 in listData)
                listList.Add(s1);
        }
        // поиск элемента в списке
        private void OnFindInList(object sender, EventArgs e)
        {

        }
        // отфильтровать список
        private void OnSetFilterList(object sender, EventArgs e)
        {

        }
        // изменить элемент списка
        private void OnChangeListElement(object sender, EventArgs e)
        {
            if (ListContent.SelectedIndex < 0) return;
            string s1 = ListElementTextBox.Text;
            string s2 = ListContent.SelectedItem.ToString();
            int idx = listData.FindIndex(x => x == s2);
            if(idx > 0)
            {
                listData.Insert(idx, s1);
                listData.RemoveAt(idx + 1);
                int idx1 = listList.IndexOf(s2);
                listList.Insert(idx1, s1);
                listList.RemoveAt(idx1 + 1);
            }

        }

        private void OnItemChanged(object sender, EventArgs e)
        {
            if (ListContent.SelectedIndex < 0) return;
            ListElementTextBox.Text = ListContent.SelectedItem.ToString();
        }
    }
}
