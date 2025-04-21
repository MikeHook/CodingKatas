namespace CodingKatas.LinkedLists
{
    using System;
    using System.Text;

    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public static Node Push(Node head, int data)
        {
            var node = new Node(data);
            node.Next = head;
            return node;
        }

        public static Node BuildOneTwoThree()
        {
            var chained = Push(null, 3);
            chained = Push(chained, 2);
            chained = Push(chained, 1);

            return chained;
        }
    }

    [TestFixture]
    public class PushOneTwoThreeTest
    {
        [Test, Description("tests for inserting a node before another node.")]
        [Order(1)]
        public void pushTests()
        {
            Assert.That(Node.Push(null, 1).Data, Is.EqualTo(1), "Should be able to create a new linked list with push().");
            Assert.That(Node.Push(null, 1).Next, Is.Null, "Should be able to create a new linked list with push().");
            Assert.That(Node.Push(new Node(1), 2).Data, Is.EqualTo(2), "Should be able to prepend a node to an existing node.");
            Assert.That(Node.Push(new Node(1), 2).Next.Data, Is.EqualTo(1), "Should be able to prepend a node to an existing node.");
        }

        [Test, Description("tests for building a linked list.")]
        [Order(2)]
        public void buildTests()
        {
            Assert.That(Node.BuildOneTwoThree().Data, Is.EqualTo(1), "First node should should have 1 as data.");
            Assert.That(Node.BuildOneTwoThree().Next.Data, Is.EqualTo(2), "Second node should should have 2 as data.");
            Assert.That(Node.BuildOneTwoThree().Next.Next.Data, Is.EqualTo(3), "Third node should should have 3 as data.");
            Assert.That(Node.BuildOneTwoThree().Next.Next.Next, Is.Null, "Third node should be the tail of the linked list");
        }
    }
}
