using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnKiemtra_Click(object sender, EventArgs e)
        {
            try
            {
                double a_70Duy, b_70Duy, c_70Duy;
                string check;
                a_70Duy = double.Parse(txtCanh1.Text);
                b_70Duy = double.Parse(txtCanh2.Text);
                c_70Duy = double.Parse(txtCanh3.Text);
                Triangle_70Duy t_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
                check = t_70Duy.checkTamGiac_70Duy();
                txtThongbao.Text = check;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ độ dài các cạnh!");
            }
            
        }

        private void btnTinhCV_Click(object sender, EventArgs e)
        {
            try
            {
                double a_70Duy, b_70Duy, c_70Duy;
                string check;
               
                a_70Duy = double.Parse(txtCanh1.Text);
                b_70Duy = double.Parse(txtCanh2.Text);
                c_70Duy = double.Parse(txtCanh3.Text);
                Triangle_70Duy t_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
                check = t_70Duy.checkTamGiac_70Duy();
                txtThongbao.Text = check;
                if (t_70Duy.isTamGiac_70Duy())
                    txtCV.Text = t_70Duy.tinhChuVi_70Duy().ToString();
                else
                    MessageBox.Show("Day khong phai la tam giac!");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ độ dài các cạnh!");
            }

        }

        private void btnTinhDT_Click(object sender, EventArgs e)
        {
            try
            {
                double a_70Duy, b_70Duy, c_70Duy;
                string check;

                a_70Duy = double.Parse(txtCanh1.Text);
                b_70Duy = double.Parse(txtCanh2.Text);
                c_70Duy = double.Parse(txtCanh3.Text);
                Triangle_70Duy t_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
                check = t_70Duy.checkTamGiac_70Duy();
                txtThongbao.Text = check;
                if (t_70Duy.isTamGiac_70Duy())
                    txtDT.Text = t_70Duy.tinhDienTich_70Duy().ToString();
                else
                    MessageBox.Show("Day khong phai la tam giac!");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đầy đủ độ dài các cạnh!");
            }

        }
    }
}
