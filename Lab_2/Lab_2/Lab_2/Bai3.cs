using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            rtxt_tinhtoan.ReadOnly = true;
            btn_write.Enabled = false;
            btn_Cal.Enabled = false;
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName)) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                rtxt_tinhtoan.Text = sr.ReadToEnd();
            }
            catch
            {
                MessageBox.Show("Lỗi khi đọc file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fs.Close();
            btn_Cal.Enabled = true;
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(sfd.FileName))
                {
                    sr.WriteLine(rtxt_tinhtoan.Text);
                }
                MessageBox.Show("Ghi thành công vào file: " + sfd.FileName.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Cal_Click(object sender, EventArgs e)
        {
            if (rtxt_tinhtoan.Text.Contains("="))
            {
                MessageBox.Show("Lỗi! Nhập sai ký tự không phải các phép tính cơ bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] text = rtxt_tinhtoan.Text.Split('\n');

            try
            {
                rtxt_tinhtoan.Clear();
                for (int i = 0; i < text.Length; i++)
                {
                    if (!string.IsNullOrEmpty(text[i]))
                    {
                        text[i] = text[i].Replace(" ", "");
                        rtxt_tinhtoan.Text += ($"{text[i]} = {getExpressionValue(text[i])}\n");
                    }
                }
                btn_write.Enabled = true;
            }
            catch
            {
                return;
            }
        }
        private int priority(char x)
        {
            if (x == '*' || x == '/') return 2;
            else if (x == '+' || x == '-') return 1;
            else if (x == '(') return 0;
            return -1;
        }

        List<string> changToPostFix(string s)
        {
            Stack<char> st = new Stack<char>();
            List<string> postFix = new List<string>();

            int i = 0, n = s.Length;
            while (i < n)
            {
                if (s[i] == ' ') { i++; }
                else if (s[i] == '(')
                {
                    st.Push(s[i]);
                    i++;
                }
                else if (s[i] == ')')
                {
                    while (st.Peek() != '(')
                    {
                        postFix.Add(st.Peek().ToString());
                        st.Pop();
                    }
                    st.Pop();
                    i++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    string number = string.Empty;
                    while (i < n && s[i] >= '0' && s[i] <= '9')
                    {
                        number += s[i];
                        i++;
                    }
                    postFix.Add(number);
                }
                else if (s[i] == '+' || s[i] == '-' || s[i] == '*' || s[i] == '/')
                {
                    while (st.Count != 0 && priority(st.Peek()) >= priority(s[i]))
                    {
                        postFix.Add(st.Peek().ToString());
                        st.Pop();
                    }
                    st.Push(s[i]);
                    i++;
                }
                else
                {
                    MessageBox.Show("Lỗi! Nhập sai ký tự không phải các phép tính cơ bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
            }

            while (st.Count != 0)
            {
                postFix.Add(st.Peek().ToString());
                st.Pop();
            }

            return postFix;
        }

        double getExpressionValue(string s)
        {
            List<string> postFix = changToPostFix(s);
            Stack<double> st = new Stack<double>();

            foreach (string e in postFix)
            {
                if (e == "+" || e == "-" || e == "*" || e == "/")
                {
                    double value1 = st.Peek();
                    st.Pop();
                    double value2 = st.Peek();
                    st.Pop();

                    if (e == "+") st.Push(value2 + value1);
                    else if (e == "-") st.Push(value2 - value1);
                    else if (e == "*") st.Push(value2 * value1);
                    else if (e == "/") st.Push(value2 / value1);
                    else
                    {
                        MessageBox.Show("Lỗi! Nhập sai ký tự không phải các phép tính cơ bản", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                else
                {
                    st.Push(double.Parse(e));
                }
            }

            return st.Peek();
        }
    }
}
