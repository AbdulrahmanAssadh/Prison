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
    public partial class Form4 : Form
    {
        TextBox idg,id;
        public Form4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            idg.Text = id.Text;
            textBox4.Text = utils.name_prison;

            utils.bs5.EndEdit();
            utils.bs6.EndEdit();
            utils.d5.Update(utils.ds, "g");
            utils.d6.Update(utils.ds, "v");
            utils.ds.AcceptChanges();
            utils.bs5.AddNew();
            utils.bs6.AddNew();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this.MdiParent;
            f6.Show();
            f6.FormClosing += (s, ss) =>
            {
                textBox4.Text = utils.name_prison;
                textBox5.Text = utils.id_prison;
            };
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            idg = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(idg);
            id = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(id);

            txtN_aname.DataBindings.Add("text", utils.bs5, "name_guest");
            textBox2.DataBindings.Add("text", utils.bs5, "kinship");
            textBox3.DataBindings.Add("text", utils.bs5, "num_card");
            id.DataBindings.Add("text", utils.bs5, "id_guest");

            dataGridView1.DataSource = utils.bs5;

            textBox5.DataBindings.Add("text",utils.bs6,"id_prisoner" );
            idg.DataBindings.Add("text", utils.bs6, "id_guest");

            dateTimePicker1.DataBindings.Add("text", utils.bs6, "date_visit", true);

            utils.bs5.AddNew();
            utils.bs6.AddNew();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
