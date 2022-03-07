using System;
using System.Windows.Forms;

namespace FormsComunicationV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form2 form2 = new Form2();
        public Form3 form3 = new Form3();

        private void button1_Click(object sender, EventArgs e)
        {
            form2.Show();
            form3.Show();
            form2.sendtxt2to3 += setlebel3;
            form3.sendtxt3to2 += setlebel2;
            this.Hide();
        }
        public void setlebel3(string a)
        {
            form3.text +="1:" +  a + "\n";
        }
        public void setlebel2(string a)
        { 
            form2.text +="2:" + a + "\n";
        }
    }
}
