using System;
using System.Windows.Forms;

namespace FormsComunicationV2
{
    public delegate void sendTxt(string text);
    public partial class Form3 : Form       //form 3
    {

        public event sendTxt sendtxt3to2;
        public string text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sendtxt3to2.Invoke(textBox1.Text);
        }

    }
}
