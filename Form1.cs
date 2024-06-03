using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_tínhthuong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 + so2;
            txtkq.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();

        }

        private void btntinhhieu_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 - so2;
            txtkq.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 *so2;
            txtkq.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }

        private void btntinhtich_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            if(so2==0)
            {
                //txtkq.Text = "không chia hết cho 0";
                MessageBox.Show("không chia hết cho 0","thông báo lỗi",MessageBoxButtons.OKCancel);
            }    
            ketqua = so1 / so2;
            txtkq.Text = ketqua.ToString();
            lblkq.Text = ketqua.ToString();
        }
    }
}
