using CustomList;


namespace CustomListTest
{
    [TestClass]
    public class RemoveMethodTest
    {
        [TestMethod]
        public void RemoveMethod_CountDecreased_itemMovedDown()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Rabbit");

            //Act
            myList.Remove("Frog");
        
            //Assert
            Assert.AreEqual("Rabbit", myList[0]);
        }

        [TestMethod]
        public void RemoveMethod_IsTrueWhenItemRemoved()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Rabbit");

            //Act
            myList.Remove("Frog");
            bool Check = myList.Remove("frog");


            //Assert
             Assert.IsTrue(Check);
            Assert.AreEqual(0, myList.Count);
        }

        [TestMethod]
        public void RemoveMethod_DoesNotDecrementItem_IfNotInList()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Rabbit");

            //Act
            myList.Remove("Dog");


            //Assert
            Assert.AreEqual("Frog", myList[0]);
            Assert.AreEqual("Rabbit", myList[1]);
        }

        [TestMethod]
        public void RemoveMethod_ItemShiftBackAfterItemRemoved()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Rabbit");

            //Act
            myList.Remove(myList[0]);


            //Assert
            Assert.AreEqual("Rabbit", myList[0]);
        }

        [TestMethod]
        public void RemoveMethocityIncr_OriginalItemsSameIndex()
        {
            //Arange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Frog");
            myList.Add("Frog");
            myList.Add("Frog");

            //Act
            myList.Remove("Frog");



            //Assert
            Assert.AreEqual("Frog", myList[0]);
            Assert.AreEqual("Frog", myList[1]);

        }
    }
}
