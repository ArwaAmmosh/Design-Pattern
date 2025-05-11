using Observer_Pattern.Observer;
using System;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class Form3 : Form ,IObserver
    {
        public Form3()
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
    }
}
