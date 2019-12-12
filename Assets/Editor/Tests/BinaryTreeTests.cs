using NUnit.Framework;

namespace Editor.Tests
{
    public class BinarySearchTreeTests
    {
        // Test that our tree is properly sorted and get the max value
        [Test]
        public void TestMax()
        {
            Node root = new Node(20);
            root.Insert(15);
            root.Insert(16);
            root.Insert(23);
            root.Insert(1);
            root.Insert(4);
            root.Insert(4);

            int max = Node.GetMax(root);
            Assert.AreEqual(max, 23);
        }
        
        // Test that our tree is properly sorted and can get the min value
        [Test]
        public void TestMin()
        {
            Node root = new Node(20);
            root.Insert(15);
            root.Insert(16);
            root.Insert(23);
            root.Insert(1);
            root.Insert(4);
            root.Insert(4);

            int min = Node.GetMin(root);
            Assert.AreEqual(min, 1);
        }

        [Test]
        public void TestSearchFound()
        {
            Node root = new Node(20);
            root.Insert(15);
            root.Insert(16);
            root.Insert(23);
            root.Insert(1);
            root.Insert(4);
            root.Insert(4);

            bool found = root.Contains(4);
            Assert.AreEqual(found, true);
        }
        
        [Test]
        public void TestSearchNotFound()
        {
            Node root = new Node(20);
            root.Insert(15);
            root.Insert(16);
            root.Insert(23);
            root.Insert(1);
            root.Insert(4);
            root.Insert(4);

            bool found = root.Contains(40);
            Assert.AreEqual(found, false);
        }
    }
}