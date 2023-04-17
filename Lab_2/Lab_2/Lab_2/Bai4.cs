using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab_2
{
    public partial class Bai4 : Form
    {
        int index = 0;
        public class Student
        {
            public string Hoten { get; set; }
            public int MSSV { get; set; }
            public string SDT { get; set; }
            public float B1 { get; set; }
            public float B2 { get; set; }
            public float B3 { get; set; }
            public float DTB { get; set; }
        }
        double DTB(double b1, double b2, double b3)
        {
            return (b1 + b2 + b3) / 3.0;
        }
        List<Student> students = new List<Student>();
        public Bai4()
        {
            InitializeComponent();
            btn_doc.Enabled = false;
            btn_truoc.Enabled = false;
            btn_sau.Enabled = false;
            txt_b1doc.Enabled = false;
            txt_b2doc.Enabled = false;
            txt_b3doc.Enabled = false;
            txt_dtbdoc.Enabled = false;
            txt_Hotendoc.Enabled = false;
            txt_mssvdoc.Enabled = false;
            txt_sdtdoc.Enabled = false;
            txt_dtbghi.Enabled = false;
            label7.Enabled = false;
        }



        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Hotenghi.Text) && string.IsNullOrEmpty(txt_mssvghi.Text) && string.IsNullOrEmpty(txt_b1ghi.Text) &&
                string.IsNullOrEmpty(txt_b2ghi.Text) && string.IsNullOrEmpty(txt_b3ghi.Text) && string.IsNullOrEmpty(txt_sdtghi.Text))
            {
                MessageBox.Show("Nhập đầy đủ thông tin trước khi ghi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int mssv;
            if (txt_mssvghi.Text.Length != 8 || !int.TryParse(txt_mssvghi.Text, out mssv))
            {
                MessageBox.Show("MSSV sai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_sdtghi.Text.Length != 10 || txt_sdtghi.Text[0] != '0' || !int.TryParse(txt_sdtghi.Text, out int sdtCheck))
            {
                MessageBox.Show("Số điện thoại sai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            float b1, b2, b3;
            if (!float.TryParse(txt_b1ghi.Text, out b1))
            {
                MessageBox.Show("Điểm bài 1 sai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(txt_b2ghi.Text, out b2))
            {
                MessageBox.Show("Điểm bài 2 sai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!float.TryParse(txt_b3ghi.Text, out b3))
            {
                MessageBox.Show("Điểm bài 3 sai format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (b1 < 0 || b1 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (b2 < 0 || b2 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (b3 < 0 || b3 > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            richtxt_file.Text += (txt_Hotenghi.Text + Environment.NewLine);
            richtxt_file.Text += (txt_mssvghi.Text + Environment.NewLine);
            richtxt_file.Text += (txt_sdtghi.Text + Environment.NewLine);
            richtxt_file.Text += (txt_b1ghi.Text + Environment.NewLine);
            richtxt_file.Text += (txt_b2ghi.Text + Environment.NewLine);
            richtxt_file.Text += (txt_b3ghi.Text + Environment.NewLine);
            richtxt_file.Text += Environment.NewLine;

            Student student = new Student()
            {
                Hoten = txt_Hotenghi.Text,
                MSSV = mssv,
                SDT = txt_sdtghi.Text,
                B1 = b1,
                B2 = b2,
                B3 = b3,
                DTB = (b1 + b2 + b3) / 3

            };

            students.Add(student);

            txt_Hotenghi.Clear();
            txt_mssvghi.Clear();
            txt_sdtghi.Clear();
            txt_b1ghi.Clear();
            txt_b2ghi.Clear();
            txt_b3ghi.Clear();
            MessageBox.Show("Thêm sinh viên thành công vào danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ghi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(sfd.FileName))
                {
                    sr.WriteLine(richtxt_file.Text);
                }
                MessageBox.Show("Ghi thành công vào file: " + sfd.FileName.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btn_doc.Enabled = true;
        }
        private void btn_doc_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                FileStream fstr = new FileStream(dlg.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fstr);
                richtxt_file.Text = sr.ReadToEnd();
                Hienthongtin(index);
            }
            /*SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sr = new StreamWriter(sfd.FileName))
                {
                    sr.WriteLine(sr);
                }
                MessageBox.Show("Ghi thành công vào file: " + sfd.FileName.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
            btn_truoc.Enabled = false;
            btn_sau.Enabled = true;
            
            richtxt_file.Clear();
        }

        void Hienthongtin(int a)
        {

            txt_Hotendoc.Text = students[a].Hoten;
            txt_mssvdoc.Text = students[a].MSSV.ToString();
            txt_sdtdoc.Text = students[a].SDT.ToString();
            txt_b1doc.Text = students[a].B1.ToString();
            txt_b2doc.Text = students[a].B2.ToString();
            txt_b3doc.Text = students[a].B2.ToString();
            txt_dtbdoc.Text = students[a].DTB.ToString();
            
        }

        private void btn_truoc_Click(object sender, EventArgs e)
        {  
            if(index > 0)
            {
                index--;
                Hienthongtin(index);
            }
            if (index < students.Count() - 1)
            {
                btn_sau.Enabled = true;
            }
            if (index > 0)
            {
                btn_truoc.Enabled = true;
            }
            if (index == 0)
            {
                btn_truoc.Enabled = false;
            }
        }

        private void btn_sau_Click(object sender, EventArgs e)
        {
            if (index < students.Count() - 1) 
            {
                index++;
                Hienthongtin(index);
            }
            if (index > 0)
            {
                btn_truoc.Enabled = true;
            }    
            if(index == students.Count() - 1)
            {
                btn_sau.Enabled = false;
            }    
        }
    }
}
