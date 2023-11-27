using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace chenXingApp
{
    public partial class ModifyPass : Form
    {
        public ModifyPass()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\dotnet\chenXingApp\chenXingApp\ChenXingDB.mdf;Integrated Security = True; Connect Timeout = 30;");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                label3.Visible = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Management mgt = new Management();
        login lgn = new login();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                try
                {
                    conn.Open();
                    String query = "update UserTb1 set  UPassword = '"+textBox1.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("密码修改成功！请重新登录系统！");
                    conn.Close();
                    this.Close();
                    mgt.Close();
                    lgn.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                label3.Visible = true;
                label3.Text = "两次密码输入不一致！";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
        }
    }
}
