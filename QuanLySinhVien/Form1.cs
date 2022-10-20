using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string[] data = new string[4];
            data[0] = bunifuTextBox1.Text;
            data[1] = bunifuTextBox2.Text;
            data[2] = bunifuTextBox3.Text;
            data[3] = bunifuTextBox4.Text;
            StreamWriter streamWriter = new StreamWriter("dssv.txt");
            streamWriter.WriteLine($"Mã số sinh viên: {data[0]}");
            streamWriter.WriteLine($"Họ và tên: {data[1]}");
            streamWriter.WriteLine($"Mã lớp: {data[2]}");
            streamWriter.WriteLine($"Điểm trung bình: {data[3]}");
            streamWriter.Close();
        }
    }
}
