using Observer_Pattern.Implemtentation;
using System;
using System.Windows.Forms;

namespace Observer_Pattern
{
    public partial class FormMain : Form
    {
        private SubjectImplemention subject;
        public FormMain()
        {
            Form1 form1 = new Form1();
            form1.Show();
            Form3 form3 = new Form3();
            form3.Show();
            subject = new SubjectImplemention();
            subject.RegisterObserver(form1);
            subject.RegisterObserver(form3);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            subject.Increament();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subject.Decreament();
        }
    }
}
