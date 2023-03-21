using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int n1;
            string num1 = txt_nhapso.Text;
            bool check1 = int.TryParse(num1, out n1);
            if (string.IsNullOrEmpty(num1) || string.IsNullOrEmpty(num1))
            {
                MessageBox.Show("Bạn phải điền vào ô trống", "Cảnh báo");
            }
            else
            {
                if (check1 == false)
                {
                    MessageBox.Show("Bạn phải điền số nguyên vào ô trống", "Cảnh báo");
                }
                else
                {
                    if (n1 == 0)
                    {
                        txt_ketqua.Text = "Không";
                    }
                    else if (n1 == 1)
                    {
                        txt_ketqua.Text = "Một";
                    }
                    else if (n1 == 2)
                    {
                        txt_ketqua.Text = "Hai";
                    }
                    else if (n1 == 3)
                    {
                        txt_ketqua.Text = "Ba";
                    }
                    else if (n1 == 4)
                    {
                        txt_ketqua.Text = "Bốn";
                    }
                    else if (n1 == 5)
                    {
                        txt_ketqua.Text = "Năm";
                    }
                    else if (n1 == 6)
                    {
                        txt_ketqua.Text = "Sáu";
                    }
                    else if (n1 == 7)
                    {
                        txt_ketqua.Text = "Bảy";
                    }
                    else if (n1 == 8)
                    {
                        txt_ketqua.Text = "Tám";
                    }
                    else if (n1 == 9)
                    {
                        txt_ketqua.Text = "Chín";
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải điền vào ô các số từ 0 đến 9", "Cảnh báo");
                    }
                } 
            }
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = string.Empty;
            txt_nhapso.Text = string.Empty;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
