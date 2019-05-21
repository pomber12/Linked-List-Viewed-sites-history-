using System;
using System.Windows.Forms;

namespace MyProjectSDA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            history = new History<object>(Button1, 4);
            history.GotoItem += new EventHandler<HistoryEventArgs<object>>(history_GotoItem);
        }


        readonly History<object> history;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            history.CurrentItem = listBox1.SelectedItem;
        }


        private void history_GotoItem(object sender, HistoryEventArgs<object> e)
        {
            listBox1.SelectedItem = e.Item;
        }

       

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}