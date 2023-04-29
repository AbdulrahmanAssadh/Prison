using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pirson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtN_aname.Text.Trim();
            string pass = textBox1.Text.Trim();
            List<string> passwords = new List<string> {"admin", "111", "7723", "1212" };

            List<string> names = new List<string>{"admin", "assadh", "khalil", "zakria" };
            
            if(names.Contains(name)&& passwords.Contains(pass))
            {
                Form3 f = new Form3();
                f.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("هناك خطأ في إسم المستخدم او كلمة المرور");
            }
            
           

         
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtN_aname_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
