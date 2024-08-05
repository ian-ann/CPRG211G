using NUnit.Framework;
using System.Reflection.Metadata;
using Utility; 

namespace UtilityTests
{
    [TestFixture]
    public class SLLTests
    {
        private SLL<string> _list;

        [SetUp]
        public void Setup()
        {
            _list = new SLL<string>();
            // populate initial data
            _list.Add("Joe Blow");
            _list.AddLast("Joe Schmoe");
            _list.AddLast("John Smith");
            _list.AddLast("Jane Doe");
            _list.AddLast("Bob Bobberson");
            _list.AddLast("Sam Sammerson");
            _list.AddLast("Dave Daverson");
        }

        public void Prepend_AddInitialItems()
        {
            _list.AddFirst("Adrian Capuno");
            Assert.AreEqual("Adrian Capuno", _list.GetValue(0));
        }

        [Test]
        public void Prepend_AddsItemToFrontOfList()
        {
            _list.AddFirst("Adrian Capuno");
            Assert.AreEqual("Adrian Capuno", _list.GetValue(0));
        }

        [Test]
        public void Append_AddsItemToEndOfList()
        {
            _list.AddLast("Adrian Capuno");
            Assert.AreEqual("Adrian Capuno", _list.GetValue(_list.Count()-1));
        }

        [Test]
        public void RemoveAt_RemovesItemAtIndex()
        {
            _list.Remove(0);
            Assert.AreEqual("Joe Schmoe", _list.GetValue(0));
        }

                [Test]
        public void RemoveAt_RemoveItemsAtStart()
        {
            _list.RemoveFirst();
            Assert.AreEqual("Joe Schmoe", _list.GetValue(0));
        }

        [Test]
        public void RemoveAt_RemoveItemsAtEnd()
        {
            _list.RemoveLast();
            Assert.AreEqual("Sam Sammerson", _list.GetValue(_list.Count()-1));
        }

        [Test]
        public void RemoveAt_ListIsEmpty_ThrowsException()
        {
            _list.Clear();
            Assert.Throws<InvalidOperationException>(() => _list.RemoveLast(), "List is empty.");
        }

        [Test]
        public void InsertAt_InsertsItemAtSpecificIndex()
        {
            _list.InsertAt(1, "Adrian Capuno");
            Assert.AreEqual("Adrian Capuno", _list.GetValue(1));
        }

        [Test]
        public void Size_ReturnsCorrectSize()
        {
            Assert.AreEqual(7, _list.Count());
        }

        [Test]
        public void Clear_ClearsTheList()
        {
            _list.Clear();
            Assert.AreEqual(0, _list.Count());
        }

        [Test]
        public void Contains_ReturnsTrueIfItemExists()
        {
            _list.AddLast("Adrian Capuno");
            Assert.IsTrue(_list.Contains("Adrian Capuno"));
        }

        [Test]
        public void IsEmpty_Initially_ReturnsTrue()
        {
            _list = new SLL<string>();
            Assert.IsTrue(_list.IsEmpty(), "List should be empty initially.");
        }

        [Test]
        public void IsEmpty_AfterAddingItem_ReturnsFalse()
        {
            _list.Clear();
            _list.AddLast("Adrian Capuno");
            Assert.IsFalse(_list.IsEmpty(), "List should not be empty after adding an item.");
        }

        [Test]
        public void GetFirst_ReturnsFirstItem()
        {
            Assert.AreEqual("Joe Blow", _list.GetValue(0), "Getvalue should return value of first item.");
        }

    }
}
