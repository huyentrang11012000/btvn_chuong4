using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chuong4_btvn
{
    public partial class frmtinhtong : Form
    {
        public frmtinhtong()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLL_Click(object sender, EventArgs e)
        {
            // TtA.text=""
            txtA.Text = "";
            txtB.Text = "";
            txtA.Focus();
        }

        private void lbA_Click(object sender, EventArgs e)
        {
           // double 
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            { MessageBox.Show(" hay nhap a");
            txtA.Focus();
            return;
            }    
                
            if (txtB.Text == "")
            { MessageBox.Show(" hay nhap b");
            txtB.Focus();
            return;
            }
            double tong =0;
           // double SShang;
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            if(a<b)
            {
                for(int i= a;i<=b;i++)
                {
                    tong = tong + i;
                }
                lbtong.Text = " tổng các số từ " + txtA.Text + " đến " + txtB.Text + " là " + tong;
                    }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    tong = tong + i;
                }
                lbtong.Text = " tổng các số từ " + txtB.Text + " đến " + txtA.Text + " là " + tong;
            }
           
            
        }

        private void lbtong_Click(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == '.' || Convert.ToInt32(e.KeyChar) == 8 || Convert.ToInt32(e.KeyChar) == 13)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
