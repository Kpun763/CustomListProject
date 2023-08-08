using CustomList;
using System.Net.Http.Headers;

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

        public void Add_AddSingleItem_ShouldIncreaseCountToOne()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();

            //Act
            myList.Add(50);

            //Assert
            Assert.AreEqual(1, myList.Count);
            Assert.AreEqual(50, myList[0]);
        }

        [TestMethod]

        public void Add_AddMultipleItems_ShouldIncreaseCountAndMaintainOrder()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Pineapple");
            myList.Add("Pear");
            myList.Add("Strawberry");

            //Assert
            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual("Pineapple", myList[0]);
            Assert.AreEqual("Pear", myList[1]);
            Assert.AreEqual("Strawberry", myList[2]);

        }

        [TestMethod]
        public void Add_ThirdItemAddedIsFoundAtCorrectIndex()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);

            //Act
            myList.Add(3);

            //Assert
            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual(3, myList[2]);
        }

        [TestMethod]

        public void Add_AddNullItem_ShouldIncreaseCountAndAddNullToTheList()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add(null);

            //Assert
            Assert.AreEqual(1, myList.Count);
            Assert.IsNull(myList[0]);
        }

        [TestMethod]

        public void Add_AddSameItemMultipleTimes_ShouldIncreaseCountAndMaintainORder()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();

            //Act
            myList.Add("Pineapple");
            myList.Add("Pineapple");
            myList.Add("Pineapple");


            //Assert
            Assert.AreEqual(3, myList.Count);
            Assert.AreEqual("Pineapple", myList[0]);
            Assert.AreEqual("Pineapple", myList[1]);
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
            myList.Add("Pineapple");
            myList.Add("Pear");


            //Act
            bool removed = myList.Remove("Strawberry");

            //Assert
            Assert.IsFalse(removed); //This should fail as method is not implemented
            Assert.AreEqual(2, myList.Count); //This should fail as method is not implemented
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
            bool removed = myList.Remove(4);

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
            bool removed2 = myList.Remove('C');

            //Assert
            Assert.IsTrue(removed1); //This should return true, as B does exist in my list and is removed
            Assert.IsTrue(removed2); //This should return true, as c does exist in my list and is removed
            Assert.AreEqual(1, myList.Count);
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
            Assert.IsTrue(removed);
            Assert.AreEqual(2, myList.Count);

        }

        [TestMethod]

        public void ToString_EmptyList_ShouldReturnEmptyBrackets()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();


            //Act
            string result = myList.ToString();


            //Assert
            Assert.AreEqual("[]", result);
        }

        [TestMethod]

        public void ToString_ListWithOneItem_ShouldReturnSingleItemInBrackets()
        {
            //Arrange
            CustomList<string> myList = new CustomList<string>();
            myList.Add("Pineapple");

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("[Pineapple]", result);
        }

        [TestMethod]

        public void ToString_ListWithMultipleItems_ShouldReturnItemsInBracketsSeperatedByComma()
        {
            //Arrange
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("[1,2,3]", result);
        }

        [TestMethod]

        public void ToString_ListAfterAddingAndRemovingItems_ShouldReturnUpdatedListContents()
        {
            //Arrange
            CustomList<char> myList = new CustomList<char>();
            myList.Add('A');
            myList.Add('B');
            myList.Add('C');
            myList.Remove('B');

            //Act
            string result = myList.ToString();

            //Assert
            Assert.AreEqual("[A,C]", result);
        }

        [TestMethod]

        public void PlusOperator_TwoEmptyLines_shouldReturnEmptyList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();


            //Act
            CustomList<int> result = list1 + list2;

            //Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]

        public void PlusOperator_TwoNoneEmptyLists_ShouldCombimeLists()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            list1.Add("You're");
            list1.Add("Welcome");

            CustomList<string> list2 = new CustomList<string>();
            list2.Add("!");

            //Act
            CustomList<string> result = list1 + list2;

            //Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual("You're", result[0]);
            Assert.AreEqual("Welcome", result[1]);
            Assert.AreEqual("!", result[2]);
        }

        [TestMethod]

        public void PlusOperator_TwoNonEmptyLists_ShouldCombineLists()
        {
            // Arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(3);
            list2.Add(4);

            // Act
            CustomList<int> result = list1 + list2;

            // Assert
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);

        }

        [TestMethod]

        public void MinusOperator_RemoveItemsFromEmptyList_ShouldReturnEmptyList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            list2.Add(1);
            list2.Add(2);

            //Act
            CustomList<int> result = list1 - list2;

            //Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestMethod]

        public void MinusOperator_RemoveItemsFromNoneEmptyList_ShouldRemoveITemsFromList()
        {
            //Arrange
            CustomList<string> list1 = new CustomList<string>();
            list1.Add("Pineapple");
            list1.Add("Pear");
            list1.Add("Strawberry");

            CustomList<string> list2 = new CustomList<string>();
            list2.Add("Pear");

            //Act
            CustomList<string> result = list1 - list2;

            //Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("Pineapple", result[0]);
            Assert.AreEqual("Strawberry", result[1]);
        }

        [TestMethod]

        public void MinusOperator_RemoveNoneexistentItems_ShouldNotAffectList()
        {
            //Arrange
            CustomList<int> list1 = new CustomList<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);

            CustomList<int> list2 = new CustomList<int>();
            list2.Add(4);

            //Act
            CustomList<int> result = list1 - list2;

            //Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
        }

    }
}