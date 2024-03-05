using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test_2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1() // ���� ������� ���������� ������� ����������� ��������
        {
            double h = 3;
            double r = 4;
            double expected = 75.39822368615503;
            Program p = new Program();
            double actual = p.Sb1(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2() // ���� ������� ���������� ������ ��������
        {
            double h = 3;
            double r = 4;
            double expected = 150.79644737231007;
            Program p = new Program();
            double actual = p.Sb2(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3() // ���� ������� ���������� ������� ����������� �������� � �������� �������
        {
            double h = 3.5;
            double r = 4.34;
            double expected = 95.44158481605791;
            Program p = new Program();
            double actual = p.Sb1(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4() // ���� ������� ���������� ������ �������� � �������� �������
        {
            double h = 3.5;
            double r = 4.34;
            double expected = 207.10823905084567;
            Program p = new Program();
            double actual = p.Sb2(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5() // ���� ������� ���������� ������ �������� � ����� ������������� ������
        {
            double h = -5;
            double r = 43;
            double expected = -29044.024082437638;
            Program p = new Program();
            double actual = p.Sb2(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6() // ���� ������� ���������� ������ �������� � ����� �������������� �������
        {
            double h = -5;
            double r = -43;
            double expected = -29044.024082437638;
            Program p = new Program();
            double actual = p.Sb2(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7() // ���� ������� ���������� ������� ����������� �������� � ����� ������������� ������
        {
            double h = -5;
            double r = 43;
            double expected = -1350.884841043611;
            Program p = new Program();
            double actual = p.Sb1(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8() // ���� ������� ���������� ������� ����������� �������� � ����� �������������� �������
        {
            double h = -5;
            double r = -43;
            double expected = 1350.884841043611;
            Program p = new Program();
            double actual = p.Sb1(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9() // ���� ������� ���������� ������� ����������� �������� � ������� ���������
        {
            double h = 435;
            double r = 0;
            double expected = 0;
            Program p = new Program();
            double actual = p.Sb1(h, r);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10() // ���� ������� ���������� ������ �������� � ������� ���������
        {
            double h = 435;
            double r = 0;
            double expected = 0;
            Program p = new Program();
            double actual = p.Sb2(h, r);
            Assert.AreEqual(expected, actual);
        }
    }
}
