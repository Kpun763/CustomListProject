using CustomList;

namespace CustomListsTest
{
    [TestClass]
    public class AddTestMethod
    {
        [TestMethod]
        public void Add_StoreDifferentDataTypes()
        {
         
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Assert
            
            Assert.AreEqual(3, myList.Count);
        }

        [TestMethod]

        public void Capacity_ShouldIncreaseWithAdditions()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();


            //Act
            int initialCapacity = myList.Capacity;

            myList.Add(1);
            int capacityAfterAdding1 = myList.Capacity;

            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            int capacityAfterAdding3More = myList.Capacity;

            myList.Add(5);
            int increasedCapacity = myList.Capacity;

            //Assert
           
            Assert.AreEqual(8, increasedCapacity);
        }

        [TestMethod]

        public void CustomList_AccessAnElementsByIndex()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Pineapple");
            myList.Add("Pear");

            string firstElement = myList[0];
            string secondElement = myList[1];

            myList[1] = "Apple";

            //Assert
            Assert.AreEqual("Apple", myList[1]);


        }

        [TestMethod]

        public void Remove_ItemsExistsInList_ShouldReturnTrueAndRemoveItems()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            //Act
            bool removed1 = myList.Remove(2);
            bool removed2 = myList.Remove(4);
            
            

            //Assert
            Assert.IsTrue(removed1);
            Assert.IsTrue(removed2);
            Assert.AreEqual(2, myList.Count);
            
        }

        [TestMethod]

        public void Remove_ItemDoesNotExistsInList_ShouldReturnFalse()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("One");
           

            //Act
            bool removed = myList.Remove("One");

            //Assert
            Assert.IsFalse(removed); //This should fail as method is not implemented
            Assert.AreEqual(0, myList.Count); //This should fail as method is not implemented
        }

        [TestMethod]

        public void Remove_RemoveNonExistentItem_ShouldReturnFalse()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);


            //Act
            bool removed = myList.Remove(4); // 

            //Assert
            Assert.IsFalse(removed); //This should return false because the list is empty
        }

        [TestMethod]

        public void Remove_RemoveMultipleItems()
        {
            //Arrange
            CustomList<char> myList = new CustomList<char>();
            myList.Add('A');
            myList.Add('B');
            myList.Add('C');
            

            //Act
            bool removed1 = myList.Remove('B');
            bool removed2 = myList.Remove('c');

            //Assert
            Assert.IsTrue(removed1); //This should return true, as B does exist in my list and is removed
            Assert.IsTrue(removed2); //This should return true, as c does exist in my list and is removed
            Assert.AreEqual(2, myList.Count);
        }

        [TestMethod]

        public void Remove_RemoveFirstOccurenceOfItem()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Pineapple");
            myList.Add("Pear");
            myList.Add("Strawberry");

            //Act
            bool removed = myList.Remove("Pear");

            //Assert
            Assert.IsFalse(removed);
           
        }

       
     
        
    }
}