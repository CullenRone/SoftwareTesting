using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle;

namespace TestLoaiTamGiac
{
    [TestClass] // Test loại tam giác_70Duy_N1
    public class UnitTestTamGiac
    {
        private Triangle_70Duy tg_70Duy;
        public TestContext TestContext { get; set; }
        
        [TestMethod]
        public void TestCase1_TamGiacThuong_70Duy() //TestCase1: kiểm tra xem có phải là tam giác thường hay không
        {
            tg_70Duy = new Triangle_70Duy(20, 24, 30); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,24,30
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy(); 
            string expected_70Duy = "Day la tam giac thuong!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        public void TestCase2_TamGiacDeu_70Duy() //TestCase2: kiểm tra xem có phải là tam giác đều hay không
        {
            tg_70Duy = new Triangle_70Duy(20, 20, 20); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,20,20
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = "Day la tam giac deu!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        public void TestCase3_TamGiacCan_70Duy() //TestCase3: kiểm tra xem có phải là tam giác cân hay không
        {
            tg_70Duy = new Triangle_70Duy(20, 20, 30); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,20,30
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = "Day la tam giac can!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        public void TestCase4_TamGiacVuong_70Duy() //TestCase4: kiểm tra xem có phải là tam giác vuông hay không
        {
            tg_70Duy = new Triangle_70Duy(5, 12, 13); //tạo một tam giác với độ dài ba cạnh lần lượt là 5,12,13
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = "Day la tam giac vuong!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        public void TestCase5_TamGiacTu_70Duy() //TestCase5: kiểm tra xem có phải là tam giác tù hay không
        {
            tg_70Duy = new Triangle_70Duy(4, 5, 9); //tạo một tam giác với độ dài ba cạnh lần lượt là 3,4,9
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = "Day la tam giac tu!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        public void TestCase6_KhongPhaiTamGiac_70Duy() //TestCase6: kiểm tra xem có phải là tam giác hay không
        {
            tg_70Duy = new Triangle_70Duy(3, 4, 9); //tạo một tam giác với độ dài ba cạnh lần lượt là 3,4,9
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = "Day khong phai la tam giac!";
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\DataTamGiac\TestDataTamGiac.csv", "TestDataTamGiac#csv", DataAccessMethod.Sequential)]

        public void TestWithDataSource_70Duy()
        {
            // lưu dữ liệu vào biến từ file .csv
            double a_70Duy = double.Parse(TestContext.DataRow[0].ToString());
            double b_70Duy = double.Parse(TestContext.DataRow[1].ToString());
            double c_70Duy = double.Parse(TestContext.DataRow[2].ToString());
            tg_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
            string actual_70Duy = tg_70Duy.checkTamGiac_70Duy();
            string expected_70Duy = TestContext.DataRow[3].ToString();
            Assert.AreEqual(expected_70Duy, actual_70Duy);
        }
    }
}
