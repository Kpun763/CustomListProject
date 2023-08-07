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
            Assert.AreEqual(4, initialCapacity);
            Assert.AreEqual(4, capacityAfterAdding1);
            Assert.AreEqual(4, capacityAfterAdding3More);
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
            Assert.AreEqual("Pineapple", firstElement);
            Assert.AreEqual("Pear", secondElement);
            Assert.AreEqual("Apple", myList[1]);


        }

        
    }
}