using System;
using System.Windows.Forms;

namespace FormsComunicationV2
{
    public partial class Form2 : Form           //form2
    {
        public event sendTxt sendtxt2to3;
        public string text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendtxt2to3.Invoke(textBox1.Text);
        }
    }
}
