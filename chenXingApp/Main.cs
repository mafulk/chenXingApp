using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chenXingApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            UserNameLb1.Text = loads.UserNames;
            

        }



        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            Application.ExitThread();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Management obj = new Management();
            obj.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Management obj = new Management();
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ModifyPass modifyPass = new ModifyPass();
            modifyPass.Show();
            this.Hide();
            
        }

        private void UserNameLb1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmView frmView = new FrmView();
            frmView.Show();
            this.Hide();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {

            }
        }
    }
}
