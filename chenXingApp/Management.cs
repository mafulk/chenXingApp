using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace chenXingApp
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
            populate();
            UserNameLbl.Text = loads.UserNames;
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=F:\dotnet\chenXingApp\chenXingApp\ChenXingDB.mdf;Integrated Security = True; Connect Timeout = 30;");

        private void populate()
        {
            conn.Open();
            string query = "select MName,MSex,MBirthdate,MXueli,MXuewei,MSchool,MProf,MZhicheng,MPhone,MCategory,MDanwei,MZhuzhi,MKu,MJiguan from MemberTb1";
            SqlDataAdapter adapter = new SqlDataAdapter(query,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            MemberDGV.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void Filter()
        {
            conn.Open();
            string query = "select MName,MSex,MBirthdate,MXueli,MXuewei,MSchool,MProf,MZhicheng,MPhone,MCategory,MDanwei,MZhuzhi,MKu,MJiguan from MemberTb1 where MCategory = '" + CatCbSearchCb.SelectedItem.ToString()+"'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            MemberDGV.DataSource = ds.Tables[0];
            conn.Close();
        }
            private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Management_Load(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if(NameTb.Text == "" || SexTb.Text == "" ||  JGTb.Text == "" || XLTb.Text == "" || XWTb.Text == "" || SchoolTb.Text == "" || ProfTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || DWTb.Text == "" || MKuCB.SelectedIndex == -1 || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("请将信息填写完整，再进行增加！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "insert into MemberTb1 values('" + NameTb.Text + "','"+SexTb.Text+"','"+DTpicker.Value.Date+"','"+JGTb.Text+"','"+XLTb.Text+"','"+XWTb.Text+"','"+SchoolTb.Text+"','"+ProfTb.Text+"','"+PhoneTb.Text+"','"+DWTb.Text+"','"+AddTb.Text+"','"+CatCb.Text+"','"+MKuCB.Text+"') ";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("记录保存成功！");
                    conn.Close();
                    populate();
                    Reset();
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Reset()
        {
            NameTb.Text = "";
            SexTb.Text = "";
            JGTb.Text = "";
            XLTb.Text = "";
            XWTb.Text = "";
            SchoolTb.Text = "";
            ProfTb.Text = "";
            AddTb.Text = "";
            PhoneTb.Text = "";
            DWTb.Text = "";
            AddTb.Text = "";
            ZJTb.Text = "";
            CatCb.Text = "人才类型";
            MKuCB.Text = "人才库";
            DTpicker.Value=DateTime.Now.Date;
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Reset();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            populate();
            //CatCbSearchCb.SelectedIndex = -1; 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }
        int key = 0;
        
        private void MemberDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
         
            
            NameTb.Text = MemberDGV.SelectedRows[0].Cells[0].Value.ToString();
            SexTb.Text = MemberDGV.SelectedRows[0].Cells[1].Value.ToString();
            DTpicker.Value = Convert.ToDateTime(MemberDGV.SelectedRows[0].Cells[2].Value);
            XLTb.Text = MemberDGV.SelectedRows[0].Cells[3].Value.ToString();
            XWTb.Text = MemberDGV.SelectedRows[0].Cells[4].Value.ToString();
            SchoolTb.Text= MemberDGV.SelectedRows[0].Cells[5].Value.ToString();
            ProfTb.Text = MemberDGV.SelectedRows[0].Cells[6].Value.ToString();
            ZJTb.Text = MemberDGV.SelectedRows[0].Cells[7].Value.ToString();
            PhoneTb.Text = MemberDGV.SelectedRows[0].Cells[8].Value.ToString();
            CatCb.Text = MemberDGV.SelectedRows[0].Cells[9].Value.ToString();
            DWTb.Text = MemberDGV.SelectedRows[0].Cells[10].Value.ToString();
            AddTb.Text = MemberDGV.SelectedRows[0].Cells[11].Value.ToString();
            MKuCB.Text = MemberDGV.SelectedRows[0].Cells[12].Value.ToString();
            JGTb.Text = MemberDGV.SelectedRows[0].Cells[13].Value.ToString();

            if (NameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                // key = Convert.ToInt32(MemberDGV.SelectedRows[0].Cells[-1].Value.ToString());
                key = MemberDGV.SelectedCells[0].RowIndex;
            }


        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("未选中记录，请选择要删除的记录！！！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "delete from MemberTb1 where MId = " + key + " ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("记录删除成功！");
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || SexTb.Text == "" || JGTb.Text == "" || XLTb.Text == "" || XWTb.Text == "" || SchoolTb.Text == "" || ProfTb.Text == "" || PhoneTb.Text == "" || AddTb.Text == "" || DWTb.Text == "" || AddTb.Text == "" || CatCb.SelectedIndex == -1)
            {
                MessageBox.Show("记录信息不完整，请完善信息！");
            }
            else
            {
                try
                {
                    conn.Open();
                    String query = "update MemberTb1 set MName = '"+ NameTb.Text+ "' ,MSex = '"+SexTb.Text+"' ,MBirthdate = '"+DTpicker.Value.Date+"' ,MXueli = '"+XLTb.Text+"' ,MXuewei = '"+XWTb.Text+"' ,MSchool = '"+SchoolTb.Text+"',MProf = '"+ProfTb.Text+"' ,MZhicheng = '"+ZJTb.Text+"' ,MPhone = '"+PhoneTb.Text+"' ,MCategory = '"+CatCb.SelectedText+"' ,MDanwei = '"+DWTb.Text+"' ,MZhuzhi = '"+AddTb.Text+"' ,MKu = '"+MKuCB.SelectedText+"' ,MJiguan = '"+JGTb.Text+"' where MId = "+ key + "";//更新数据库信息
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("记录信息更新成功！");
                    conn.Close();
                    populate();
                    Reset();
                    CatCb.Text = "人才类型";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void SchoolTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProfTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void JGTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void XLTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void XWTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DWTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AddTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void CatTb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DTpicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Users usr = new Users();
            usr.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SexTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void Management_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main main = new Main(); 
            main.Show();
            this.Hide();
           
        }
        
        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void MemberDGV_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }


}
