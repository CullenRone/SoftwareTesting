using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle_70Duy //70_Duy_N1
    {
        private double a_70Duy, b_70Duy, c_70Duy; //Khai báo độ dài các cạnh tam giác lần lượt là a_70Duy, b_70Duy và c_70Duy

        public Triangle_70Duy(double a_70Duy, double b_70Duy, double c_70Duy) //70Duy tạo constructor
        {
            this.a_70Duy = a_70Duy;
            this.b_70Duy = b_70Duy;
            this.c_70Duy = c_70Duy;
        }

        public bool isTamGiac_70Duy() // 70Duy đây là câu lệnh để kiểm tra xem đây có phải là một tam giác hay không
        {
            if (a_70Duy <= b_70Duy + c_70Duy && b_70Duy <= a_70Duy + c_70Duy && c_70Duy <= a_70Duy + b_70Duy)
                return true;
            else
                return false;
        }

        private bool isTamGiacCan_70Duy() //70Duy đây là câu lệnh để kiểm tra có phải là tam giác cân hay không
        {
            if (a_70Duy == b_70Duy || b_70Duy == c_70Duy || a_70Duy == c_70Duy)
                return true;
            else
                return false;
        }

        private bool isTamGiacDeu_70Duy() //70Duy đây là câu lệnh để kiểm tra có phải là tam giác đều hay không
        {
            if (a_70Duy == b_70Duy && b_70Duy == c_70Duy)
                return true;
            else
                return false;
        }

        private bool isTamGiacVuong_70Duy() //70Duy đây là câu lệnh để kiểm tra có phải là tam giác vuông hay không
        {
            if (Math.Pow(a_70Duy, 2) == Math.Pow(b_70Duy, 2) + Math.Pow(c_70Duy, 2) ||
                Math.Pow(b_70Duy, 2) == Math.Pow(c_70Duy, 2) + Math.Pow(a_70Duy, 2) ||
                Math.Pow(c_70Duy, 2) == Math.Pow(a_70Duy, 2) + Math.Pow(b_70Duy, 2))
                return true;
            else
                return false;
        }


        private bool isTamGiacTu_70Duy() //70Duy đây là câu lệnh để kiểm tra có phải là tam giác tù hay không
        {
            if (Math.Pow(a_70Duy, 2) > Math.Pow(b_70Duy, 2) + Math.Pow(c_70Duy, 2) ||
                Math.Pow(b_70Duy, 2) > Math.Pow(c_70Duy, 2) + Math.Pow(a_70Duy, 2) ||
                Math.Pow(c_70Duy, 2) > Math.Pow(a_70Duy, 2) + Math.Pow(b_70Duy, 2))
                return true;
            else
                return false;
        }

        public string checkTamGiac_70Duy() //70Duy đây là câu lệnh để kiểm tra các loại tam giác
        {
            if (isTamGiac_70Duy())
            {
                if (isTamGiacDeu_70Duy())
                    return "Day la tam giac deu!";
                else if (isTamGiacCan_70Duy())
                    return "Day la tam giac can!";
                else if (isTamGiacVuong_70Duy())
                    return "Day la tam giac vuong!";
                else if (isTamGiacTu_70Duy())
                    return "Day la tam giac tu!";
                else
                    return "Day la tam giac thuong!";
            }
            else
                return "Day khong phai la tam giac!";
        }

        public double tinhChuVi_70Duy() //70Duy đây là câu lệnh thực hiện phép tính chu vi tam giác
        {
            if (isTamGiac_70Duy())
                return a_70Duy + b_70Duy + c_70Duy;
            else
                return 0;
        }

        public double tinhDienTich_70Duy() //70Duy đây là câu lệnh thực hiện phép tính diện tích tam giác
        {
            double p,S;
            if (isTamGiac_70Duy())
            {
                p = (a_70Duy + b_70Duy + c_70Duy) / 2;
                S = Math.Sqrt(p * (p - a_70Duy) * (p - b_70Duy) * (p - c_70Duy));
                return S;
            }    
            else
                return 0;
        }
    }
    
}
