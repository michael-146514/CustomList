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
            CustomList<string> myListOne = new CustomList<string>();
            myListOne.Add("Hello");
            string[] expectedList = { "Hello", "Bye World", "Bye" };


            CustomList<string> myListTwo = new CustomList<string>();
            myListTwo.Add("Bye World");
            myListTwo.Add("Bye");

            //Act
            CustomList<string> adding = myListOne + myListTwo;


            //Assert

            for (int i = 0; i < expectedList.Length; i++)
            {
                Assert.AreEqual(expectedList[i], adding[i]);
            }
        }

        [TestMethod]
        public void OperatorPlus_AddingBlankLists()
        {
            //Arange
            CustomList<string> myListOne = new CustomList<string>();
            myListOne.Add("");
            string[] expectedList = { "" };


            CustomList<string> myListTwo = new CustomList<string>();
            myListTwo.Add("");

            //Act
            CustomList<string> adding = myListOne + myListTwo;


            //Assert

            for (int i = 0; i < expectedList.Length; i++)
            {
                Assert.AreEqual(expectedList[i], adding[i]);
            }
        }
    }
}
