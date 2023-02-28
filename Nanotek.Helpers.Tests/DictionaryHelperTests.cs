using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nanotek.Helpers.Tests
{
    [TestClass]
    public class DictionaryHelperTests
    {
        #region AddOrIncrement

        [TestMethod]
        [DataRow(10, 5, 5)]
        [DataRow(10, 0, 0)]
        [DataRow(10, -5, -5)]
        public void Can_AddOrIncrement_New_Int(int key, int add, int expected)
        {
            // ARRANGE
            var dictionary = new Dictionary<int, int>();

            // ACT
            Assert.IsTrue(!dictionary.ContainsKey(key));
            DictionaryHelper.AddOrIncrement(dictionary, key, add);

            // ASSERT
            Assert.AreEqual(expected, dictionary[key]);
        }

        [TestMethod]
        [DataRow(10, 5, 10)]
        [DataRow(10, 0, 0)]
        [DataRow(10, -5, -10)]
        public void Can_AddOrIncrement_Twice_Int(int key, int add, int expected)
        {
            // ARRANGE
            var dictionary = new Dictionary<int, int>();

            // ACT
            Assert.IsTrue(!dictionary.ContainsKey(key));
            DictionaryHelper.AddOrIncrement(dictionary, key, add);
            DictionaryHelper.AddOrIncrement(dictionary, key, add);

            // ASSERT
            Assert.AreEqual(expected, dictionary[key]);
        }

        [TestMethod]
        [DataRow(10, 2.5, 2.5)]
        [DataRow(10, 0, 0)]
        [DataRow(10, -1.32, -1.32)]
        public void Can_AddOrIncrement_New_Double(int key, double add, double expected)
        {
            // ARRANGE
            var dictionary = new Dictionary<int, double>();

            // ACT
            Assert.IsTrue(!dictionary.ContainsKey(key));
            DictionaryHelper.AddOrIncrement(dictionary, key, add);

            // ASSERT
            Assert.AreEqual(expected, dictionary[key]);
        }

        [TestMethod]
        [DataRow(10, 2.5, 5)]
        [DataRow(10, 0, 0)]
        [DataRow(10, -1.32, -2.64)]
        public void Can_AddOrIncrement_Twice_Double(int key, double add, double expected)
        {
            // ARRANGE
            var dictionary = new Dictionary<int, double>();

            // ACT
            Assert.IsTrue(!dictionary.ContainsKey(key));
            DictionaryHelper.AddOrIncrement(dictionary, key, add);
            DictionaryHelper.AddOrIncrement(dictionary, key, add);

            // ASSERT
            Assert.AreEqual(expected, dictionary[key]);
        }

        #endregion
    }
}
