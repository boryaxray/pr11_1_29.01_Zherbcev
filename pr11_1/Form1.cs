using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zherbcev_Vitaliy_26._01
{
    public partial class Student_Work :Form
    {
        public Student_Work ()
        {
            InitializeComponent();
        }



        public class Train
        {
            public string num;
            public string time;
            public string punkt;

            
        }
        private void label2_Click (object sender, EventArgs e)
        {

        }

        private void label1_Click (object sender, EventArgs e)
        {

        }

        private void button1_Click (object sender, EventArgs e)
        {
            Train train1 = new Train();
            train1.num = textBox1.Text;
            train1.punkt = textBox2.Text;
            train1.time = textBox3.Text;
           
            MessageBox.Show(string.Format("Номер поезда: {0}\nВремя: {1}\nПункт: {2}", train1.num, train1.punkt, train1.time));
            
        }
    }
}
