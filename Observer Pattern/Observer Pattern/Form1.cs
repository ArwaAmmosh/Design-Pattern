using Observer_Pattern.Observer;
using System;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Form1 : Form ,IObserver
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Update(int count)
        {
            setText(count);
        }

        private void setText(int count)
        {
            label1.Text = count.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
