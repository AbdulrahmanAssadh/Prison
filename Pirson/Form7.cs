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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox3.DataBindings.Add("text", utils.bs4, "prisoner_num");
            txtN_aname.DataBindings.Add("text", utils.bs4, "prisoner_name");
            textBox2.DataBindings.Add("text", utils.bs4, "num_file");
            textBox1.DataBindings.Add("text", utils.bs4, "age");
            dateTimePicker1.DataBindings.Add("text", utils.bs4, "date_in", true);
            textBox5.DataBindings.Add("text", utils.bs4, "id_room");
             textBox4.DataBindings.Add("text", utils.bs4, "id_crime");
            textBox6.DataBindings.Add("text", utils.bs4, "sex");
            PictureBox1.DataBindings.Add("image", utils.bs4, "prisoner_image", true);
            dataGridView1.DataSource = utils.bs4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            utils.bs4.RemoveAt(dataGridView1.CurrentRow.Index);
            utils.d4.Update(utils.ds, "prisons");
            utils.ds.AcceptChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            utils.bs4.EndEdit();
            utils.d4.Update(utils.ds, "prisons");
            utils.ds.AcceptChanges();
        }
    }
}
