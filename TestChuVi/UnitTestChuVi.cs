using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Triangle;

namespace TestChuVi
{
    [TestClass] //70Duy Test tính chu vi tam giác
    public class UnitTestChuVi
    {
        private Triangle_70Duy tg_70Duy;
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void TestChuVi1_70Duy() //TestCase 1: PASS tính đúng kết quả chu vi tam giác
        {
            tg_70Duy = new Triangle_70Duy(20, 24, 30); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,24,30
            double actual_70Duy = tg_70Duy.tinhChuVi_70Duy();
            double expected_70Duy = 74;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.1);
        }

        [TestMethod]
        public void TestChuVi2_70Duy() //TestCase 2: FAIL tính sai kết quả chu vi tam giác
        {
            tg_70Duy = new Triangle_70Duy(20, 24, 32); //tạo một tam giác với độ dài ba cạnh lần lượt là 20,24,32
            double actual_70Duy = tg_70Duy.tinhChuVi_70Duy();
            double expected_70Duy = 70;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.1);
        }

        [TestMethod]
        public void TestChuVi3_70Duy() //TestCase 3: FAIL đây không phải là tam giác
        {
            tg_70Duy = new Triangle_70Duy(1, 1, 3); //tạo một tam giác với độ dài ba cạnh lần lượt là 1, 1, 3
            double actual_70Duy = tg_70Duy.tinhChuVi_70Duy();
            double expected_70Duy = 5;
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.1);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        @".\DataChuVi\TestDataChuVi.csv", "TestDataChuVi#csv", DataAccessMethod.Sequential)]

        public void TestWithDataSource_70Duy()
        {
            // lưu dữ liệu vào biến từ file .csv
            double a_70Duy = double.Parse(TestContext.DataRow[0].ToString());
            double b_70Duy = double.Parse(TestContext.DataRow[1].ToString());
            double c_70Duy = double.Parse(TestContext.DataRow[2].ToString());
            tg_70Duy = new Triangle_70Duy(a_70Duy, b_70Duy, c_70Duy);
            double actual_70Duy = tg_70Duy.tinhChuVi_70Duy();
            double expected_70Duy = double.Parse(TestContext.DataRow[3].ToString());
            Assert.AreEqual(expected_70Duy, actual_70Duy, 0.1);
        }
    }
}
