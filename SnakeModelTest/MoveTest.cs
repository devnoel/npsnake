using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NPSnake.Model
{
    /// <summary>
    /// Summary description for MoveTest
    /// </summary>
    [TestClass]
    public class MoveTest
    {
        public MoveTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestDefaultMoves()
        {
            Assert.AreEqual("[0, -1]", Move.Up.ToString());
            Assert.AreEqual("[0, 1]", Move.Down.ToString());
            Assert.AreEqual("[-1, 0]", Move.Left.ToString());
            Assert.AreEqual("[1, 0]", Move.Right.ToString());
        }

        [TestMethod]
        public void TestRotate()
        {
            Assert.AreEqual(Move.Left, Move.Up.Rotate(Direction.Left));
            Assert.AreEqual(Move.Right, Move.Up.Rotate(Direction.Right));
            Assert.AreEqual(Move.Up, Move.Up.Rotate(Direction.Forward));
            Assert.AreEqual(Move.Up, Move.Left.Rotate(Direction.Right));
            Assert.AreEqual(Move.Up, Move.Right.Rotate(Direction.Left));
            Assert.AreEqual(Move.Right, Move.Down.Rotate(Direction.Left));
        }

        [TestMethod]
        public void TestFrom()
        {
            Assert.AreEqual("[1, -1]", Move.Up.From(new Tile(1, 0)).ToString());
            Assert.AreEqual("[10, 0]", Move.Right.From(new Tile(9, 0)).ToString());
            Assert.AreEqual("[0, 0]", Move.Down.From(new Tile(0, -1)).ToString());
        }
    }
}
