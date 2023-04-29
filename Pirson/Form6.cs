using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Pirson
{
    public partial class Form6 : Form
    {
        TextBox n, d;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            n= new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(n);
            d= new TextBox() { Size = new Size(0, 0) };
            this.Controls.Add(d);
            DataGridView1.DataSource=utils.bs4;
            d.DataBindings.Add("text", utils.bs4, "prisoner_num");
            n.DataBindings.Add("text", utils.bs4, "prisoner_name");
           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView1.CurrentRow.Selected=true;
            utils.name_prison = n.Text;
            utils.id_prison = d.Text;
            MessageBox.Show(utils.name_prison+ utils.id_prison);
            this.Close();
        }
        DataTable dt = new DataTable();
        OleDbDataAdapter dp;
        private void button1_Click(object sender, EventArgs e)
        {
            dp = new OleDbDataAdapter("select * from  prisons where prisoner_name  like '%"+textBox4.Text+"%'",utils.con);
            dp.Fill(dt);
            DataGridView1.DataSource = dt;



        }
    }
}
