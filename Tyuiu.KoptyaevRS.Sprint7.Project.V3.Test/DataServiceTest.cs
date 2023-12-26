using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoptyaevRS.Sprint7.Project.V3.Lib;

namespace Tyuiu.KoptyaevRS.Sprint7.Project.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 3] { {"Teacher1","20","Алгебра" },
                                                    {"Teacher2","18","Физика" } };

            string[] dataWait = new string[3] { "Teacher2", "18", "Физика" };

            CollectionAssert.AreEqual(dataWait, ds.Search(dataTest, "Физика"));
        }
        [TestMethod]
        public void ValidDataStatisticsSum()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Teacher1", "20"},
                                                   {"Teacher2", "30"},
                                                   {"Teacher3", "10"}};

            double dataWait = 40;

            string command = "sum";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMin()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Teacher1", "20"},
                                                   {"Teacher2", "30"},
                                                   {"Teacher3", "10"}};

            double dataWait = 10;

            string command = "min";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMax()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Teacher1", "20"},
                                                   {"Teacher2", "30"},
                                                   {"Teacher3", "10"}};

            double dataWait = 30;

            string command = "max";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsAvarage()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Teacher1", "20"},
                                                   {"Teacher2", "30"},
                                                   {"Teacher3", "10"}};

            double dataWait = 20;

            string command = "avarage";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }
    }
}
