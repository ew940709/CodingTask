using System;
using System.Collections.Generic;
using System.Linq;
using CollectionFilter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CollectionFilterTests
{
    [TestClass]
    public class CollectionFilterTests
    {
        [TestMethod]
        public void ShouldReturnEmptyCollectionWhenEmpty()
        {
            var elementList = new List<Element>();

            var filteredElements = CollectionFilter.CollectionFilter.Filter(elementList);

            Assert.IsNotNull(elementList.ToList());
            Assert.AreEqual(elementList.Count, filteredElements.ToList().Count);
        }

        [TestMethod]
        public void ShouldReturnUniqueByNum()
        {
            var elementList = new List<Element>();
            var element1 = new Element() {Age = 21, Name = "test", Num = 20};
            var element2 = new Element() {Age = 21, Name = "test", Num = 20};
            var element3 = new Element() {Age = 22, Name = "test", Num = 20};
            var element4 = new Element() {Age = 22, Name = "test", Num = 21};
            elementList.Add(element1);
            elementList.Add(element2);
            elementList.Add(element3);
            elementList.Add(element4);

            var filteredElements = CollectionFilter.CollectionFilter.Filter(elementList).ToList();

            Assert.IsNotNull(filteredElements);
            Assert.AreEqual(2, filteredElements.Count);
            Assert.AreEqual(element1, filteredElements[0]);
            Assert.AreEqual(element4, filteredElements[1]);

        }


        [TestMethod]
        public void ShouldReturnHigherThanThreshold()
        {
            var elementList = new List<Element>();
            var element1 = new Element() { Age = 20, Name = "test", Num = 1 };
            var element2 = new Element() { Age = 21, Name = "test", Num = 2 };
            elementList.Add(element1);
            elementList.Add(element2);

            var filteredElements = CollectionFilter.CollectionFilter.Filter(elementList).ToList();

            Assert.IsNotNull(filteredElements);
            Assert.AreEqual(1, filteredElements.Count);
            Assert.AreEqual(element2, filteredElements[0]);

        }

    }
}
