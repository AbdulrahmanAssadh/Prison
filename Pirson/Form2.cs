using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pirson
{
    public partial class Form2 : Form
    {
        TextBox id_room, name_crim, sex ,count;
        
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id_room.Text = comboBox2.Text;
            name_crim.Text = comboBox1.Text;

            utils.bs4.EndEdit(); 
            utils.d4.Update(utils.ds, "prisons");
            utils.ds.AcceptChanges(); 

            string str =count.Text;
            count.Text = (int.Parse(str) + 1).ToString();
            utils.bs3.EndEdit();
            utils.d3.Update(utils.ds, "rooms");
            utils.ds.AcceptChanges();
            MessageBox.Show("successfuly");
            utils.bs4.AddNew();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            id_room = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(id_room);
            name_crim = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(name_crim);

            sex = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(sex);
            count = new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(count);

            comboBox1.DisplayMember = "name_crime";
            comboBox1.ValueMember = "name_crime";
            comboBox1.DataSource = utils.bs1;

            comboBox2.DisplayMember = "id_room";
            comboBox2.ValueMember = "count_pirsoner";
            comboBox2.DataSource = utils.bs3;

            count.DataBindings.Add("text", utils.bs3, "count_pirsoner");

            textBox3.DataBindings.Add("text", utils.bs4, "prisoner_num");
            txtN_aname.DataBindings.Add("text", utils.bs4, "prisoner_name");
            textBox2.DataBindings.Add("text", utils.bs4, "num_file");
            textBox1.DataBindings.Add("text", utils.bs4, "age");
            dateTimePicker1.DataBindings.Add("text", utils.bs4, "date_in",true);
            id_room.DataBindings.Add("text", utils.bs4, "id_room");
            name_crim.DataBindings.Add("text", utils.bs4, "id_crime");
            sex.DataBindings.Add("text", utils.bs4, "sex");
            PictureBox1.DataBindings.Add("image", utils.bs4, "prisoner_image", true);

            dataGridView1.DataSource = utils.bs3;

            utils.com1 = new OleDbCommandBuilder(utils.d4);
            utils.com2 = new OleDbCommandBuilder(utils.d3);
            utils.bs4.AddNew();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == radioButton1) sex.Text = "ذكر";
            else sex.Text = "أنثئ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
                PictureBox1.Image = Image.FromFile(op.FileName);
        }
    }
}
