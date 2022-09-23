using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float soA, soB, ketqua;
        public bool Nhap()
        {
            if (float.TryParse(txtA.Text, out soA))
            {
                if (float.TryParse(txtB.Text, out soB))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Bạn nhập sai định dạng số B");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập sai định dạng số A");
                return false;
            }
        }

        private void btn_cong_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                ketqua = soA + soB;
                kq.Text = ketqua.ToString();
            }
        }

        private void btn_tru_Click(object sender, EventArgs e)
        {

        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {

        }

        private void bnt_chia_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
