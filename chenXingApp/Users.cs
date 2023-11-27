using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace chenXingApp
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
            populate();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\dotnet\chenXingApp\chenXingApp\ChenXingDB.mdf;Integrated Security = True; Connect Timeout = 30;");
        private void populate()
        {
            conn.Open();
            string query = "select * from UserTb1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            UsersDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PWTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "")
            { 
                MessageBox.Show("请将信息填写完整，再进行保存！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "insert into UserTb1 values('" + NameTb.Text + "','"+ PWTb.Text +"','"+ AddTb.Text+"','"+ PhoneTb.Text +"') ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户信息保存成功！");
                    conn.Close();
                    populate();
                   // Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Reset()
        {
            NameTb.Text = "";
            PWTb.Text = "";
            AddTb.Text = "";
            PhoneTb.Text = "";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        
        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("未选中用户，请选择要删除的用户！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "delete from UserTb1 where UId = " + key + " ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户删除成功！");
                    conn.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        int key = 0;
        private void UsersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NameTb.Text = UsersDGV.SelectedRows[0].Cells[1].Value.ToString();
            PWTb.Text = UsersDGV.SelectedRows[0].Cells[2].Value.ToString();
            AddTb.Text = UsersDGV.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = UsersDGV.SelectedRows[0].Cells[4].Value.ToString();
            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(UsersDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PWTb.Text == "" || AddTb.Text == "" || PhoneTb.Text == "")
            {
                MessageBox.Show("用户信息不完整，请完善信息！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "update UserTb1 set UName = '" + NameTb.Text + "' ,UPassword = '" + PWTb.Text + "' , UAdd = '"+ AddTb.Text+"' ,UPhone = '"+ PhoneTb.Text +"' where UId = " + key + "";//更新数据库信息
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("用户信息更新成功！");
                    conn.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Users_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
