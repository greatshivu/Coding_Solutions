using Challenges.Leet;

namespace Code_Challenges.Test
{
    public class AddTwoNumbers_LinkedList_Test
    {
        [Fact]
        public void Test_AddTwoNumber_with0()
        {
            var obj = new AddTwoNumbers_LinkedList();
            
            var result = obj.AddTwoNumbers(obj.GetList([0]), obj.GetList([0]));

            Assert.Equal([0], obj.GetvaluesFromNode(result));
        }

        [Fact]
        public void Test_AddTwoNumber_WithValues1()
        {
            var obj = new AddTwoNumbers_LinkedList();

            var result = obj.AddTwoNumbers(obj.GetList([2, 4, 3]), obj.GetList([5, 6, 4]));

            Assert.Equal([7, 0, 8], obj.GetvaluesFromNode(result));
        }

        [Fact]
        public void Test_AddTwoNumber_WithValues2()
        {
            var obj = new AddTwoNumbers_LinkedList();

            var result = obj.AddTwoNumbers(obj.GetList([9, 9, 9, 9, 9, 9, 9]), obj.GetList([9, 9, 9, 9]));

            Assert.Equal([8, 9, 9, 9, 0, 0, 0, 1], obj.GetvaluesFromNode(result));
        }

        [Fact]
        public void Test_AddTwoNumber_WithValues3()
        {
            var obj = new AddTwoNumbers_LinkedList();

            var result = obj.AddTwoNumbers(obj.GetList([9]), obj.GetList([1, 9, 9, 9, 9, 9, 9, 9, 9, 9]));

            Assert.Equal([0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1], obj.GetvaluesFromNode(result));
        }
    }
}