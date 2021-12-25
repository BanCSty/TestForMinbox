using FindArea.FigureS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FindAreaTest
{
    [TestClass]
    public class TestFindArea
    {
        [TestMethod]
        public void CircleArea_12__452returned()
        {
            IArea abs = new Circle(12);
            double result = 452.3893421169302;
            Assert.AreEqual(abs.GetArea(), result);
        }
        [TestMethod]
        public void CircleArea_0__FailReturned()
        {
            try
            {
                IArea abs = new Circle(0);
            }
            catch (ArgumentOutOfRangeException range)
            {
                Assert.AreEqual("Input string was not in a correct format.", range.Message);
            }
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }
        }

        //������������ �������� ���������� - https://qastack.ru/programming/741029/best-way-to-test-exceptions-with-assert-to-ensure-they-will-be-thrown
        [TestMethod]
        public void TriangleArea_3_0_5__FAILreturned()
        {
            try
            {
                IArea abs = new Triangle("3", 0, 5);
                Assert.Fail("An exception should have been thrown"); //�������������� ��� ������ � ��� ����� OK
            }
            catch (ArgumentOutOfRangeException range)
            {
                Assert.AreEqual("Input string was not in a correct format.", range.Message);
            }
            //��� ������������ ����� deep-error 
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }
        }

        [TestMethod]
        public void IsRectengular_3_4_5__TRUEreturn()
        {

            Triangle triangle = new Triangle("3", 4, 5);
            Assert.IsTrue(triangle.IsRectengular());
        }

        [TestMethod]
        public void abstractFigure_4_5_3__6retrun()
        {
            Figure triangle = new Figure("4", 5, 3);
            Assert.AreEqual(triangle.Result(), 6);
        }
    }
}
