using CustomList;


namespace CustomListTest
{
    [TestClass]
    public class _NegOperatorOverloadTest
    {
        [TestMethod]
        public void SubtractOperator_FirstListLonger_RemovesMatchingElements()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int> { 1, 2, 3, 3, 4 };
            CustomList<int> list2 = new CustomList<int> { 2, 3 };

            int[] expectedList = { 1, 4 };

            // Act
            CustomList<int> result = list1 - list2;

            // Assert
        
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void SubtractOperator_SecondListLonger_EmptyResult()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int> { 1, 2 };
            CustomList<int> list2 = new CustomList<int> { 2, 3, 4 };

            // Act
            CustomList<int> result = list1 - list2;

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void SubtractOperator_SecondListEmpty_UnchangedResult()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int> { 1, 2, 3 };
            CustomList<int> list2 = new CustomList<int>();

            // Act
            CustomList<int> result = list1 - list2;

            // Assert
            Assert.AreEqual(list1.Count, result.Count);
            CollectionAssert.AreEqual(list1.ToArray(), result.ToArray());
        }

        [TestMethod]
        public void SubtractOperator_RemoveSingleInstanceFromFirstList()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int> { 3, 3, 3 };
            CustomList<int> list2 = new CustomList<int> { 1, 2, 3 };

            // Act
            CustomList<int> result = list1 - list2;

            // Assert
            Assert.AreEqual(12, result);
     
        }
    }
}
