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
    public partial class Form3 : Form
    {
       

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            utils.con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DataPrison.mdb");
            utils.ds = new DataSet();
            try
            {
                utils.con.Open();
            }catch(Exception ex ){MessageBox.Show(ex.ToString());}
            utils.d1=new OleDbDataAdapter("select * from type_crime", utils.con);
            utils.d1.Fill(utils.ds, "type_crime");
            utils.bs1 = new BindingSource(utils.ds, "type_crime");

            utils.d2 = new OleDbDataAdapter("select * from sperms", utils.con);
            utils.d2.Fill(utils.ds, "sperms");

            utils.d3 = new OleDbDataAdapter("select * from rooms where count_pirsoner <5 ", utils.con);
            utils.d3.Fill(utils.ds, "rooms");



            utils.ds.Relations.Add("cs", utils.ds.Tables["type_crime"].Columns["id_crime"], utils.ds.Tables["sperms"].Columns["id_crime"]);


            utils.ds.Relations.Add("sr", utils.ds.Tables["sperms"].Columns["id_sperm"], utils.ds.Tables["rooms"].Columns["id_sperm"]);

            utils.d4 = new OleDbDataAdapter("select * from prisons", utils.con);
            utils.d4.Fill(utils.ds, "prisons");

            utils.bs2 = new BindingSource(utils.bs1, "cs");

            utils.bs3 = new BindingSource(utils.bs2, "sr");
            utils.bs4 = new BindingSource(utils.ds, "prisons");



            utils.d5 = new OleDbDataAdapter("select * from guest", utils.con);
            utils.d5.Fill(utils.ds, "g");
            utils.bs5 = new BindingSource(utils.ds, "g");
            utils.d6 = new OleDbDataAdapter("select * from visitor", utils.con);
            utils.d6.Fill(utils.ds, "v");
            utils.bs6 = new BindingSource(utils.ds, "v");
            utils.com5 = new OleDbCommandBuilder(utils.d5);
            utils.com6 = new OleDbCommandBuilder(utils.d6);



        }

        private void DRDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void men_RefreshItems(object sender, EventArgs e)
        {

        }

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.MdiParent = this;
            f5.Show();
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void BindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

            Form2 f = new Form2();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {


            Form4 f = new Form4();
            f.MdiParent = this;
            f.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.MdiParent = this;
            f6.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form7 fi = new Form7();
            fi.MdiParent = this;
            fi.Show();
        }
    }
}
