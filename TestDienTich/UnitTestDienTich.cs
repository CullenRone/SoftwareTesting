using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle;

namespace TestDienTich
{
    [TestClass] //70Duy Test tính diện tích tam giác
    public class UnitTestDienTich
    {
        private Triangle_70Duy tg_70Duy;
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestDienTich4_70Duy() //TestCase 4: PASS tính đúng kết quả diện tích tam giác
        {
            tg_70Duy = new Triangle_70Duy(20, 24, 30); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,24,30
            double actual_70Duy = tg_70Duy.tinhDienTich_70Duy();
            double expected_70Duy = 239.24;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.01);
        }

        [TestMethod]
        public void TestDienTich5_70Duy() //TestCase 5: FAIL tính sai kết quả diện tích tam giác
        {
            tg_70Duy = new Triangle_70Duy(13, 15, 20); //tạo một tam giác với độ dài ba cạnh lần lượt là 13,15,20
            double actual_70Duy = tg_70Duy.tinhDienTich_70Duy();
            double expected_70Duy = 97.5;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.01);
        }

        [TestMethod]
        public void TestDienTich6_70Duy() //TestCase 6: FAIL tính diện tích không phải hình tam giác
        {
            tg_70Duy = new Triangle_70Duy(2, 3, 9); //tạo một tam giác với độ dài ba cạnh lần lượt là 2, 3, 9
            double actual_70Duy = tg_70Duy.tinhDienTich_70Duy();
            double expected_70Duy = 7;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.01);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\DataDienTich\TestDataDienTich.csv", "TestDataDienTich#csv", DataAccessMethod.Sequential)]
        public void TestWithDataSource_70Duy()
        {
            // lưu dữ liệu vào biến từ file .csv
            double a_70Duy = double.Parse(TestContext.DataRow[0].ToString());
            double b_70Duy = double.Parse(TestContext.DataRow[1].ToString());
            double c_70Duy = double.Parse(TestContext.DataRow[2].ToString());
            tg_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
            double actual_70Duy = tg_70Duy.tinhDienTich_70Duy();
            double expected_70Duy = double.Parse(TestContext.DataRow[3].ToString());
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.01);
        }
    }
}
