using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresTests
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestPush()
        {
            LinkedListStack s = new LinkedListStack();
            s.Push(1);
            s.Push(2);

            Assert.AreEqual(2, s.Peek());
        }

        [TestMethod]
        public void TestPop()
        {
            LinkedListStack s = new LinkedListStack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);

            s.Pop();
            s.Pop();
            s.Pop();

            Assert.AreEqual(2, s.Peek());
        }
    }
}
