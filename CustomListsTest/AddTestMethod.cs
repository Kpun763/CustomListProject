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
    }
}