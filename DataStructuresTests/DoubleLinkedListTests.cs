using DataStructures;

namespace DataStructuresTests
{
    [TestClass]
    public class DoubleinkedListTests
    {
        [TestMethod]
        public void TestInsertFront()
        {
            DoubleLinkedList l = new DoubleLinkedList();

            l.InsertFront(5);
            l.InsertFront(4);
            l.InsertFront(3);
            l.InsertFront(2);
            l.InsertFront(1);

            Assert.AreEqual(5, l.GetCount());

            var list = l.ToList().ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                Assert.AreEqual(i + 1, list[i]);
            }
        }

        [TestMethod]
        public void TestGetLastNode()
        {
            DoubleLinkedList l = new DoubleLinkedList();

            l.InsertFront(5);
            l.InsertFront(4);
            l.InsertFront(3);

            Assert.AreEqual(5, l.GetLastNode().data);
        }

        [TestMethod]
        public void TestInsertLastNode()
        {
            DoubleLinkedList l = new DoubleLinkedList();

            l.InsertLast(5);
            l.InsertLast(4);
            l.InsertLast(3);

            Assert.AreEqual(3, l.GetLastNode().data);
        }

        [TestMethod]
        public void TestInsertAfter()
        {
            DoubleLinkedList l = new DoubleLinkedList();

            l.InsertFront(1);

            var node = l.GetLastNode();

            l.InsertAfter(node, 2);

            Assert.AreEqual(2, l.GetCount());
            Assert.AreEqual(2, l.GetLastNode().data);
        }

        [TestMethod]
        public void TestDeleteNodeByKey()
        {
            DoubleLinkedList l = new DoubleLinkedList();

            l.InsertFront(5);
            l.InsertFront(4);
            l.InsertFront(3);
            l.InsertFront(2);
            l.InsertFront(1);

            l.DeleteNodebyKey(3);

            var list = l.ToList().ToArray();

            Assert.AreEqual(1, list[0]);
            Assert.AreEqual(2, list[1]);
            Assert.AreEqual(4, list[2]);
            Assert.AreEqual(5, list[3]);
        }

    }
}