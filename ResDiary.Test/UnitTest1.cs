using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ResDiary.Test
{
    [TestClass]
    public class UnitTest1
    {
        public bool Compare(List<List<int>> a1, List<List<int>> a2)
        {
            if (a1.Count != a2.Count)
            {
                return false;
            }

            var result = true;
            for (var i = 0; i < a1.Count; i++)
            {
                result = a1[i].SequenceEqual(a2[i]);
            }

            return result;
        }

        /// <summary>
        /// Original test given in specification
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5 };
            List<List<int>> goal = new List<List<int>>
            {
                new List<int>{1, 2},
                new List<int>{3, 4},
                new List<int>{5},
            };

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 3), goal));
        }

        /// <summary>
        /// Splitting the array with no remainder
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 6 };
            List<List<int>> goal = new List<List<int>>
            {
                new List<int>{1, 2},
                new List<int>{3, 4},
                new List<int>{5, 6},
            };

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 3), goal));
        }

        /// <summary>
        /// Checking what happens when there are multiple remainders
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<int>> goal = new List<List<int>>
            {
                new List<int>{1, 2, 3},
                new List<int>{4, 5, 6},
                new List<int>{7, 8},
            };

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 3), goal));
        }

        /// <summary>
        /// Splitting the array into 4
        /// </summary>
        [TestMethod]
        public void TestMethod4()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<int>> goal = new List<List<int>>
            {
                new List<int>{1, 2},
                new List<int>{3, 4},
                new List<int>{5, 6},
                new List<int>{7, 8},
            };

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 4), goal));
        }

        /// <summary>
        /// Invalid split given with 0
        /// </summary>
        [TestMethod]
        public void TestMethod5()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<int>> goal = new List<List<int>>();

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 0), goal));
        }

        /// <summary>
        /// Invalid split given with -1
        /// </summary>
        [TestMethod]
        public void TestMethod6()
        {
            List<int> array = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            List<List<int>> goal = new List<List<int>>();

            Assert.IsTrue(Compare(ResDiaryClass.GroupArrayElements(array, 0), goal));
        }
    }
}