using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class AddMethodTest
    {
        [TestMethod]
        public void AddMethod_AddTwoItems_SecondItemAtIndexOne()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");

            //Assert
            Assert.AreEqual("world", myList[1]);
        }

        [TestMethod]
        public void AddMethod_AddTwoItems_FirstItemAtIndexOne()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("hello");
            myList.Add("world");

            //Assert
            Assert.AreEqual("hello", myList[0]);
        }

        [TestMethod]
        public void AddMethod_CapacityIncreases_WhenItemsAddedBeyondInitialCapacity()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("One");
            myList.Add("One");
            myList.Add("One");
            myList.Add("One");
            myList.Add("One");
            myList.Add("One");
            myList.Add("One");

            //Assert
            Assert.AreEqual(8, myList);
        }

        [TestMethod]
        public void AddMethod_CapacityIncreases_OriginalItemsSameIndex()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Frog");
            myList.Add("Rabbit");
            myList.Add("Dog");
            myList.Add("Cat");
            myList.Add("Monkey");

            //Assert
            Assert.AreEqual("Frog", myList[0]);
            Assert.AreEqual("Rabbit", myList[1]);
            Assert.AreEqual("Dog", myList[2]);
        }
    }
}