using CustomList;



namespace CustomListTest
{
    [TestClass]
    public class ToStringMethodTest
    {
        [TestMethod]
        public void ToString_ListStringsReturn()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Rabbit");

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("FrogRabbit", result);
        }

        [TestMethod]
        public void ToString_ListIntReturn()
        {
            //Arange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("12", result);
        }

        [TestMethod]
        public void ToString_BlankString()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("", result);
        }
    }
}
