using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chenXingApp
{
    public partial class loads : Form
    {
        public loads()
        {
            InitializeComponent();
            UPassTb.KeyDown += UPassTb_KeyDown;
        }
        //数据库链接
        SqlConnection conn = new SqlConnection(@"Data Source =.\SQL; AttachDbFilename=F:\C#dev\chenXingApp\chenXingApp\ChenXingDB.mdf;Integrated Security = True; Connect Timeout = 30;");

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static string UserNames = "";

        private void UPassTb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from UserTb1 where UName = '" + UNameTb.Text + "' and UPassword = '" + UPassTb.Text + "'", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserNames = UNameTb.Text;
                    Main obj = new Main();
                    obj.Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                    UNameTb.Text = "";
                    UPassTb.Text = "";
                    UNameTb.Focus();
                }
                conn.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open(); 
            SqlDataAdapter adapter = new SqlDataAdapter("select count(*) from UserTb1 where UName = '"+UNameTb.Text+"' and UPassword = '"+ UPassTb.Text +"'",conn); 
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                UserNames = UNameTb.Text;
                Main objm = new Main(); 
                objm.Show();
                this.Hide();
                conn.Close();
            }
            else 
            {
                MessageBox.Show("用户名或密码错误！");
                UNameTb.Text = "";
                UPassTb.Text = "";
                UNameTb.Focus();
            }
            conn.Close();
        }

        private void loads_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else 
            { 
                e.Cancel = true;//手动取消
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
