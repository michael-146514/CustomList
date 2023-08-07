using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class _OperatorOverloadTest
    {
        [TestMethod]
        public void OperatorPlus_ListOneLonger_AddingListOneToListTwo()
        {
            //Arange
            CustomList<string> myListOne = new CustomList<string>();
            myListOne.Add("Hello");
            myListOne.Add("World");
            string[] expectedList = {"Hello", "World", "Bye World"};


            CustomList<string> myListTwo = new CustomList<string>();
            myListTwo.Add("Bye World");

            //Act
            CustomList<string> adding = myListOne + myListTwo;


            //Assert

            for (int i = 0; i < expectedList.Length; i++)
            {
                Assert.AreEqual(expectedList[i], adding[i]); 
            }
        }

        [TestMethod]
        public void OperatorPlus_ListTwoLonger_AddingListTwoToListOne()
        {
            //Arange
            CustomList<int> myListOne = new CustomList<int>();
            myListOne.Add(1);
            myListOne.Add(3);

            CustomList<int> myListTwo = new CustomList<int>();
            myListTwo.Add(5);
            myListOne.Add(8);
            myListOne.Add(4);

            //Act
            CustomList<int> adding = myListOne + myListTwo;

            //Assert
            Assert.AreEqual(21, adding);
        }

        [TestMethod]
        public void OperatorPlus_AddingBlankLists()
        {
            //Arange
            CustomList<string> myListOne = new CustomList<string>();
            myListOne.Add("");

            CustomList<string> myListTwo = new CustomList<string>();
            myListTwo.Add("");

            //Act
            CustomList<string> adding = myListOne + myListTwo;

            //Assert
            Assert.AreEqual("", adding);
        }
    }
}
