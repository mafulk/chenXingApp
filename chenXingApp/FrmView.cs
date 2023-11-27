using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chenXingApp
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
            loadData();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\dotnet\chenXingApp\chenXingApp\ChenXingDB.mdf;Integrated Security = True; Connect Timeout = 30;");

        private void populate()
        {
            conn.Open();
            string query = "select MName,MSex,MBirthdate,MXueli,MXuewei,MSchool,MProf,MZhicheng,MPhone,MCategory,MDanwei,MZhuzhi,MKu,MJiguan from MemberTb1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            DGVView.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void FrmView_FormClosing(object sender, FormClosingEventArgs e)
        {   
            Main main = new Main(); 
            main.Show();
            this.Hide();
            
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void miExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void subView_Click(object sender, EventArgs e)
        {
            populate();
            //mdiView mdiView = new mdiView();
            //mdiView.MdiParent = this;
            //mdiView.Show();
        }

        private void subExit_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void DGVView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
        private void loadData()
        {
            Management  mng=new Management();
            var items = mng.CatCb.Items;
            foreach (var item in items) 
            {
                comboBox1.Items.Add(item);
            }
            var itms = mng.MKuCB.Items;
            foreach (var item in itms) 
            {
                comboBox2.Items.Add(item);
            }
            
        }

        private void DGVView_Scroll(object sender, ScrollEventArgs e)
        {
            if(e.NewValue >= DGVView.Rows.Count)
            {
                return;
            }
            DGVView.FirstDisplayedScrollingRowIndex = e.NewValue;
        }

        private void DGVView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
