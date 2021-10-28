using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanlinhkien
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text == "phanthang") && (this.txtPassWord.Text == "123456"))
            {
                this.Hide();
                fTrangchinh f = new fTrangchinh();
                f.Show();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng vui lòng thử lại!", "Thông báo");
                this.txtUser.Focus();
                this.txtPassWord.Focus();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát khỏi phần mềm", "Thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
