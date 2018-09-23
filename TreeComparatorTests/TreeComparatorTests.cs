using CodingTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeComparatorTests
{
    [TestClass]
    public class TreeComparatorTests
    {
        [TestMethod]
        public void ShouldReturnTrueIfTreesAreEmpty()
        {
            var firstTree = new BTN();
            var secondTree = new BTN();

            var comparisonResult = TreeComparator.Compare(firstTree, secondTree);

            Assert.IsTrue(comparisonResult);

        }

        [TestMethod]
        public void ShouldReturnFalseIfExactlyOneTreeIsEmpty()
        {
            var firstTree = new BTN();
            var secondTree = new BTN {Value = 1};


            var comparisonResult = TreeComparator.Compare(firstTree, secondTree);

            Assert.IsFalse(comparisonResult);

        }

        [TestMethod]
        public void ShouldReturnTrueIfTreesAreEqual()
        {
            var firstTree = new BTN {Value = 1};
            var secondTree = new BTN {Value = 1};

            var comparisonResult = TreeComparator.Compare(firstTree, secondTree);

            Assert.IsTrue(comparisonResult);

        }

        [TestMethod]
        public void ShouldReturnFalseIfTreesNotEqual()
        {

            var leftSubtree = new BTN() { Value = 2 };
            var rightSubtree = new BTN() { Value = 3 };

            var firstTree = new BTN
            {
                Value = 1, 
                Right = rightSubtree,
                Left = leftSubtree
            };

            var secondTree = new BTN
            {
                Value = 1,
                Right = leftSubtree,
                Left = rightSubtree
            };


            var comparisonResult = TreeComparator.Compare(firstTree, secondTree);

            Assert.IsFalse(comparisonResult);

        }




    }
}
