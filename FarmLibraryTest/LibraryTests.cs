using ClassLibrarySquares;

namespace FarmLibraryTest
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
        public void QudratTest()
        {
            double firstPerimetr = 23;
            double secondPerimetr = 0.32;
            double thirdPerimetr = 294;
            double fourthPerimetr = 75;
            double fifthPerimetr = 890;

            double firstExpected = 33.0625;
            double secondExpected = 0.0064;
            double thirdExpected = 5402.25;
            double fourthExpected = 351.5625;
            double fifthExpected = 49506.25;

            double firstActual = SquareModel.SquareQudrat(firstPerimetr);
            double secondActual = SquareModel.SquareQudrat(secondPerimetr);
            double thirdActual = SquareModel.SquareQudrat(thirdPerimetr);
            double fourthActual = SquareModel.SquareQudrat(fourthPerimetr);
            double fifthActual = SquareModel.SquareQudrat(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }

        [TestMethod]
        public void Rectangle2Test()
        {
            double firstPerimetr = 31;
            double secondPerimetr = 0.1;
            double thirdPerimetr = 567;
            double fourthPerimetr = 199;
            double fifthPerimetr = 369;

            double firstExpected = 53.38888888888888;
            double secondExpected = 0.000555555555555;
            double thirdExpected = 17860.5;
            double fourthExpected = 2200.055555555555;
            double fifthExpected = 7564.5;

            double firstActual = SquareModel.SquareRectangle2(firstPerimetr);
            double secondActual = SquareModel.SquareRectangle2(secondPerimetr);
            double thirdActual = SquareModel.SquareRectangle2(thirdPerimetr);
            double fourthActual = SquareModel.SquareRectangle2(fourthPerimetr);
            double fifthActual = SquareModel.SquareRectangle2(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }

        [TestMethod]
        public void CircleTest()
        {
            double firstPerimetr = Math.PI;
            double secondPerimetr = 129;
            double thirdPerimetr = 42;
            double fourthPerimetr = 672;
            double fifthPerimetr = 0.7;

            double firstExpected = Math.PI / 4;
            double secondExpected = 1324.2487;
            double thirdExpected = 140.37466;
            double fourthExpected = 35935.91291;
            double fifthExpected = 0.038993;

            double firstActual = SquareModel.SquareCircle(firstPerimetr);
            double secondActual = SquareModel.SquareCircle(secondPerimetr);
            double thirdActual = SquareModel.SquareCircle(thirdPerimetr);
            double fourthActual = SquareModel.SquareCircle(fourthPerimetr);
            double fifthActual = SquareModel.SquareCircle(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }


        [TestMethod]
        public void RectangleGoldTest()
        {
            double firstPerimetr = 10;
            double secondPerimetr = 0.25;
            double thirdPerimetr = 600;
            double fourthPerimetr = 155;
            double fifthPerimetr = 321;

            double firstExpected = 5.90169;
            double secondExpected = 0.00368856;
            double thirdExpected = 21246.11797;
            double fourthExpected = 1417.88329;
            double fifthExpected = 6081.17012;

            double firstActual = SquareModel.SquareRectangleGold(firstPerimetr);
            double secondActual = SquareModel.SquareRectangleGold(secondPerimetr);
            double thirdActual = SquareModel.SquareRectangleGold(thirdPerimetr);
            double fourthActual = SquareModel.SquareRectangleGold(fourthPerimetr);
            double fifthActual = SquareModel.SquareRectangleGold(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }

        [TestMethod]
        public void TriangleTest()
        {
            double firstPerimetr = 30;
            double secondPerimetr = 0.3;
            double thirdPerimetr = 15;
            double fourthPerimetr = 45;
            double fifthPerimetr = 186;

            double firstExpected = 43.30127018922193;
            double secondExpected = 0.004330127018922194;
            double thirdExpected = 10.825317547305483;
            double fourthExpected = 97.42785792574934;
            double fifthExpected = 1664.500826073691;

            double firstActual = SquareModel.SquareTriangle(firstPerimetr);
            double secondActual = SquareModel.SquareTriangle(secondPerimetr);
            double thirdActual = SquareModel.SquareTriangle(thirdPerimetr);
            double fourthActual = SquareModel.SquareTriangle(fourthPerimetr);
            double fifthActual = SquareModel.SquareTriangle(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.0000001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.0000001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.0000001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.0000001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.0000001);
        }

        [TestMethod]
        public void HexagonTest()
        {
            double firstPerimetr = 60;
            double secondPerimetr = 0.6;
            double thirdPerimetr = 36;
            double fourthPerimetr = 72;
            double fifthPerimetr = 12;

            double firstExpected = 259.80762;
            double secondExpected = 0.02598;
            double thirdExpected = 93.53074;
            double fourthExpected = 374.12297;
            double fifthExpected = 10.39230;

            double firstActual = SquareModel.SquareHexagon(firstPerimetr);
            double secondActual = SquareModel.SquareHexagon(secondPerimetr);
            double thirdActual = SquareModel.SquareHexagon(thirdPerimetr);
            double fourthActual = SquareModel.SquareHexagon(fourthPerimetr);
            double fifthActual = SquareModel.SquareHexagon(fifthPerimetr);


            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }

        [TestMethod]
        public void RombTest()
        {
            double firstPerimetr = 4;
            double secondPerimetr = 0.9;
            double thirdPerimetr = 132;
            double fourthPerimetr = 16;
            double fifthPerimetr = 80;

            double firstExpected = 0.866025;
            double secondExpected = 0.0438425;
            double thirdExpected = 943.10166;
            double fourthExpected = 13.85641;
            double fifthExpected = 346.41016;

            double firstActual = SquareModel.SquareRomb(firstPerimetr);
            double secondActual = SquareModel.SquareRomb(secondPerimetr);
            double thirdActual = SquareModel.SquareRomb(thirdPerimetr);
            double fourthActual = SquareModel.SquareRomb(fourthPerimetr);
            double fifthActual = SquareModel.SquareRomb(fifthPerimetr);

            Assert.IsTrue(Math.Abs(firstExpected - firstActual) < 0.00001);
            Assert.IsTrue(Math.Abs(secondActual - secondExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(thirdActual - thirdExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fourthActual - fourthExpected) < 0.00001);
            Assert.IsTrue(Math.Abs(fifthActual - fifthExpected) < 0.00001);
        }
    }
}