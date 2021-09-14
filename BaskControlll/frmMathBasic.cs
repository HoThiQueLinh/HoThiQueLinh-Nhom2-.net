using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaskControlll
{
    public partial class frmMathBasic : Form
    {
        public frmMathBasic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = textBox1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);
                var soThuHai = textBox2.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat + nSoThuHai;
                label5.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so khong nhap ky tu {ex.Message }");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi roi ban gi oi {ex.Message }");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = textBox1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);
                var soThuHai = textBox2.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat - nSoThuHai;
                label5.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so khong nhap ky tu {ex.Message }");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi roi ban gi oi {ex.Message }");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = textBox1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);
                var soThuHai = textBox2.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat * nSoThuHai;
                label5.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so khong nhap ky tu {ex.Message }");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi roi ban gi oi {ex.Message }");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var soThuNhat = textBox1.Text;
                long nSoThuNhat = Convert.ToInt64(soThuNhat);
                var soThuHai = textBox2.Text;
                long nSoThuHai = long.Parse(soThuHai);
                var ketQua = nSoThuNhat / nSoThuHai;
                label5.Text = ketQua.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Loi dinh dang. Vui long nhap so khong nhap ky tu {ex.Message }");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Loi roi ban gi oi {ex.Message }");
            }
        }
    }
}
