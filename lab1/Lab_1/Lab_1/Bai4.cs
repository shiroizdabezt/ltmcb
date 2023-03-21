using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_chuyendoi_Click(object sender, EventArgs e)
        {
            double n1, tiendoi;
            string num1 = txt_sotiendoi.Text;
            bool check1 = double.TryParse(num1, out n1);
            if (string.IsNullOrEmpty(num1))
            {
                MessageBox.Show("Bạn phải điền vào ô trống", "Cảnh báo");
            }
            else 
            {
                if (check1 == false)
                {
                    MessageBox.Show("Bạn phải điền số tiền vào ô ", "Cảnh báo");
                }
                else if ( n1 <= 0 )
                    MessageBox.Show("Bạn phải điền số tiền lớn hơn 0 vào ô ", "Cảnh báo");
                else
                {
                    switch (cmbb_loaitien.Text)
                    {
                        case "USD":
                            tiendoi = n1 * 22.772;
                            txt_sotiendadoi.Text = tiendoi.ToString();
                            txt_tygia.Text = "1 USD = 22.772 VND";
                            break;
                        case "EUR":
                            tiendoi = n1 * 28.132;
                            txt_sotiendadoi.Text = tiendoi.ToString();
                            txt_tygia.Text = "1 EUR = 28.132 VND";
                            break;
                        case "GBP":
                            tiendoi = n1 * 31.538;
                            txt_sotiendadoi.Text = tiendoi.ToString();
                            txt_tygia.Text = "1 GBP = 31.538 VND";
                            break;
                        case "SGD":
                            tiendoi = n1 * 17.286;
                            txt_sotiendadoi.Text = tiendoi.ToString();
                            txt_tygia.Text = "1 SGD = 17.286 VND";
                            break;
                        case "JPY":
                            tiendoi = n1 * 214;
                            txt_sotiendadoi.Text = tiendoi.ToString();
                            txt_tygia.Text = "1 JPY = 214 VND";
                            break;
                        default:
                            MessageBox.Show("Bạn phải chọn loại tiền cần đổi vào ô trống", "Cảnh báo");
                            break;
                    }
                }
            }
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
