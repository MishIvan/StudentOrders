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
            Filter.Text = String.Empty;
            SortedFlag.Checked = false;
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
                    FirsInLine.Text = queueList.ElementAt(0);
                }

            }

        }
        // покинуть очередь
        private void OnQuitQueue(object sender, EventArgs e)
        {
            if (queueData.Count < 1) return;
            queueData.Dequeue();
            string s1 = queueData.Count > 0 ? queueData.ToArray()[0] : String.Empty;
            queueList.RemoveAt(0);
            FirsInLine.Text = s1;
        }
        // добавить элемент в список
        private void OnAddToList(object sender, EventArgs e)
        {
            string s1 = ListElementTextBox.Text;
            if(!String.IsNullOrEmpty(s1) && !String.IsNullOrWhiteSpace(s1))
            {
                int idx = listData.FindIndex(x => x == s1);
                if(idx < 0)
                {
                    listData.Add(s1);
                    FormSortedAndFilteredView();
                }
            }

        }
        // удалить элемент в списке
        private void OnDeleteFromList(object sender, EventArgs e)
        {
            string s1 = ListContent.SelectedItem.ToString();
            if(listData.Remove(s1))
                FormSortedAndFilteredView();
        }
        // поиск элемента в списке по фрагменту строки
        private void OnFindInList(object sender, EventArgs e)
        {
            string s1 = ListElementTextBox.Text;
            if (String.IsNullOrEmpty(s1) || String.IsNullOrWhiteSpace(s1)) return;
            int idx = listList.ToList().FindIndex(x => x.ToLower().Contains(s1.ToLower()));
            if (idx >= 0)
                ListContent.SelectedIndex = idx;


        }
        // изменить элемент списка
        private void OnChangeListElement(object sender, EventArgs e)
        {
            int i = ListContent.SelectedIndex;
            if (i < 0) return;
            string s1 = ListElementTextBox.Text; // новое значение
            string s2 = ListContent.SelectedItem.ToString(); // старое значение
            int idx = listData.FindIndex(x => x == s2);
            if(idx >= 0)
            {
                listData.Insert(idx, s1);
                listData.RemoveAt(idx + 1);
                FormSortedAndFilteredView();
                ListContent.SelectedIndex = i;
            }

        }
        // изменилось значение флага фильтрации
        private void OnItemChanged(object sender, EventArgs e)
        {
            if (ListContent.SelectedIndex < 0) return;
            ListElementTextBox.Text = ListContent.SelectedItem.ToString();
        }

        // установить есть сортировка или нет
        private void OnChangeSortFlag(object sender, EventArgs e)
        {
            FormSortedAndFilteredView();
        }
        // сформировать сортированный отфильтрованный список
        private void FormSortedAndFilteredView()
        {
            bool sorted = SortedFlag.Checked;
            string filter = Filter.Text;
            bool nofilter = String.IsNullOrEmpty(filter) || String.IsNullOrWhiteSpace(filter);
            List<string> lst = null;
            if (!sorted && !nofilter)
                lst = listData.Where(x => x.ToLower().Contains(filter.ToLower())).ToList();
            else if (sorted && !nofilter)
                lst = listData.Where(x => x.ToLower().Contains(filter.ToLower())).OrderBy(x => x).ToList();
            else if (sorted && nofilter)
                lst = listData.OrderBy(x => x).ToList();
            else
                lst = listData;
            listList = new BindingList<string>(lst);
            ListContent.DataSource = listList;

        }
        // убрать фильтрацию списка, показать весь список
        private void OnCleanFilter(object sender, EventArgs e)
        {
            Filter.Text = String.Empty;
            FormSortedAndFilteredView();
        }
        // изменился фильтр
        private void OnFilterChanged(object sender, EventArgs e)
        {
            FormSortedAndFilteredView();
        }
    }
}
