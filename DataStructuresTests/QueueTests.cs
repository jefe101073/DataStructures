using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTests
{
    [TestClass]
    public class QueueTests
    {
        [TestMethod]
        public void TestEnqueue()
        {
            var queue = new LinkListQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            var list = queue.ToList();
            for(int i = 0; i<list.Count();i++)
            {
                Assert.AreEqual(i + 1, list[i]);
            }
        }

        [TestMethod]
        public void TestDequeue()
        {
            var queue = new LinkListQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            var list = queue.ToList();
            Assert.AreEqual(2, list.Count());

            for (int i = 0; i < list.Count(); i++)
            {
                Assert.AreEqual(i + 4, list[i]);
            }
        }
    }
}
