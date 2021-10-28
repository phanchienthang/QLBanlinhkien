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
    public partial class TTnhanvien : Form
    {
        public TTnhanvien()
        {
            InitializeComponent();
        }

        private void thôngTinLinhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTlinhkien tt = new TTlinhkien();
            tt.Show();
            this.Hide();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTnhanvien tt = new TTnhanvien();
            tt.Show();
            this.Hide();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            f.Show();
            this.Hide();
        }

        private void QuaylaitoolStripLabel5_Click(object sender, EventArgs e)
        {
            fTrangchinh f = new fTrangchinh();
            f.Show();
            this.Hide();
        }
    }
}
