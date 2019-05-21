using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;


namespace MyProjectSDA
{
    public sealed class History<T> 
    {

        public event EventHandler<HistoryEventArgs<T>> GotoItem;
        public delegate string GetHistoryMenuText(T item);
      
        public History(ToolStripSplitButton button1,   uint limitList)
        {
            list = new LinkedList<T>();

            Menu = new ToolStripDropDownMenu();
            Menu.Opening += new CancelEventHandler(Menu_Opening);
           
            
            TsiButton1 = button1;
            assignButton(button1);
            

            limit = (int)limitList;
            _Enabled = true;
        }



        private T _CurrentItem;
        readonly LinkedList<T> list;
        private LinkedListNode<T> current;

         ToolStripDropDownMenu Menu;
         ToolStripSplitButton TsiButton1;
         
        private bool _Enabled;
        private bool inProc;
        readonly int limit;

        private GetHistoryMenuText _GetMenuText;
       


        public bool Enabled
        {
            get { return _Enabled; }
            set { _Enabled = value; }
        }


        public GetHistoryMenuText MenuTexts
        {
            get { return _GetMenuText; }
            set { _GetMenuText = value; }
        }



        public T CurrentItem
        {
            get { return _CurrentItem; }
            set
            {
                if (_Enabled)
                {
                    _CurrentItem = value;

                    if (!inProc && _CurrentItem != null)
                    {
                        addCurrentItem(value);
                    }
                }
            }
        }


        private void addCurrentItem(T item)
        {

            list.AddFirst(item);

            current = list.First;
            limitList();
            enableButtons();
        }

        private void Tsi_ButtonClick(object sender, EventArgs e)
        {
      

            limitList();
            enableButtons();
        }

        private void Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            LinkedListNode<T> node = (LinkedListNode<T>)e.ClickedItem.Tag;

            OnGotoItem(node);

            current = node;
            limitList();
            enableButtons();
        }

        private void Menu_Opening(object sender, CancelEventArgs e)
        {
            Debug.Assert(list.Count != 0 && current != null);

            Menu.Items.Clear();

            ToolStripItem Tsi = ((ToolStripDropDownMenu)sender).OwnerItem;
            bool isBackMenu = Tsi.Equals(TsiButton1);

            LinkedListNode<T> node = isBackMenu ? current.Next : current.Previous;

            while (node != null)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Tag = node;

                if (_GetMenuText != null)
                    tsmi.Text = _GetMenuText(node.Value);
                else
                    tsmi.Text = node.Value.ToString();
                
                Menu.Items.Add(tsmi);

                node = isBackMenu ? node.Next : node.Previous;
            }
        }

       
     
        private void limitList()
        {
            if (limit != 0 && list.Count > limit)
            {
                LinkedListNode<T> node = current.Next;
                int count = 0;

                while (node != null)
                {
                    if (++count > limit)
                    {
                        list.RemoveLast();
                    }
                    node = node.Next;
                }
            }
        }

        private void assignButton(ToolStripSplitButton Tsi)
        {
            if (Tsi != null)
            {
                Tsi.ButtonClick += new EventHandler(Tsi_ButtonClick);
                Tsi.DropDown = Menu;
                Tsi.Enabled = false;
            }
        }

        private void enableButtons()
        {
            if (TsiButton1 != null)
                TsiButton1.Enabled = (current != null && current.Next != null);
           
        }

        private void OnGotoItem(LinkedListNode<T> node)
        {
            Debug.Assert(node != null && node.Value != null);

            T item = node.Value;

            inProc = true;

            if (GotoItem != null)
            {
                GotoItem(this, new HistoryEventArgs<T>(item));
            }
            inProc = false;
        }


        public void Dispose()
        {
            if (Menu != null && !Menu.Disposing)
            {
                Menu.Dispose();
            }
        }

    }

    public class HistoryEventArgs<T> : EventArgs
    {
        public HistoryEventArgs(T item)
        {
            _Item = item;
        }

        readonly T _Item;

        public T Item { get { return _Item; } }
    }
}