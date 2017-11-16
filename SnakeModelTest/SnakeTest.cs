using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NPSnake.Model
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class SnakeTest
    {
        private Snake snake;
        private Snake oneLengthSnake;
        private List<Tile> testBody;
        private List<Tile> nullBody;
        private List<Tile> emptyBody;
        private List<Tile> oneLengthBody;

        public SnakeTest()
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

        [TestInitialize()]
        public void TestInit()
        {
            testBody = new List<Tile> { new Tile(0, 0), new Tile(0, 1), new Tile(1, 1), new Tile(2, 1) };
            nullBody = null;
            emptyBody = new List<Tile>();
            oneLengthBody = new List<Tile> { new Tile(0, 0) };
            snake = new Snake(testBody);
            oneLengthSnake = new Snake(oneLengthBody);
        }

        [TestMethod]
        public void TestConstructor()
        {
            AssertBodiesAreEqual(testBody, snake.Body); 
            Assert.ThrowsException<ArgumentException>(() => new Snake(nullBody));
            Assert.ThrowsException<ArgumentException>(() => new Snake(emptyBody));
        }

        private void AssertBodiesAreEqual(List<Tile> body, IEnumerable<ITile> bodyToCheck)
        {
            var bodyEnum = body.GetEnumerator();
            var bodyToCheckEnum = bodyToCheck.GetEnumerator();
            while (bodyEnum.MoveNext() && bodyToCheckEnum.MoveNext())
            {
                Assert.AreEqual(bodyEnum.Current, bodyToCheckEnum.Current);
            }
            Assert.AreEqual(bodyEnum.MoveNext(), bodyToCheckEnum.MoveNext());
        }

        [TestMethod]
        public void TestLength()
        {
            Assert.AreEqual(4, snake.Length);
            Assert.AreEqual(1, oneLengthSnake.Length);
        }

        [TestMethod]
        public void TestMove()
        {
            AssertSnakeEqualsAfterMove(
                snake,
                new List<Tile> { new Tile(0, -1), new Tile(0, 0), new Tile(0, 1), new Tile(1, 1) });
            AssertSnakeEqualsAfterMove(
                snake,
                new List<Tile> { new Tile(0, -2), new Tile(0, -1), new Tile(0, 0), new Tile(0, 1) });
            AssertSnakeEqualsAfterMove(
                snake,
                new List<Tile> { new Tile(0, -3), new Tile(0, -2), new Tile(0, -1), new Tile(0, 0) });
            AssertSnakeEqualsAfterMove(
                oneLengthSnake,
                new List<Tile> { new Tile(0, -1) });
        }

        private void AssertSnakeEqualsAfterMove(Snake snake, List<Tile> bodyAfterMove)
        {
            snake.MoveOn();
            AssertBodiesAreEqual(bodyAfterMove, snake.Body);
        }

        [TestMethod]
        public void TestTurn()
        {
            AssertSnakeEqualsAfterTurns(
                new List<Tile> { new Tile(-1, 0), new Tile(0, 0), new Tile(0, 1), new Tile(1, 1) },
                Direction.Left);
            AssertSnakeEqualsAfterTurns(
                new List<Tile> { new Tile(-1, -1), new Tile(-1, 0), new Tile(0, 0), new Tile(0, 1) },
                Direction.Right);
            AssertSnakeEqualsAfterTurns(
                new List<Tile> { new Tile(-1, -2), new Tile(-1, -1), new Tile(-1, 0), new Tile(0, 0) },
                Direction.Forward);
        }

        private void AssertSnakeEqualsAfterTurns(List<Tile> bodyAfterTurnsAndMove, params Direction[] directions)
        {
            foreach(Direction dir in directions)
            {
                snake.Turn(dir);
            }
            snake.MoveOn();
            AssertBodiesAreEqual(bodyAfterTurnsAndMove, snake.Body);
        }

        [TestMethod]
        public void TestMultipleTurnsBeforeMoveOn()
        {
            AssertSnakeEqualsAfterTurns(
                new List<Tile> { new Tile(-1, 0), new Tile(0, 0), new Tile(0, 1), new Tile(1, 1) },
                Direction.Right,
                Direction.Forward,
                Direction.Right,
                Direction.Left);

            AssertSnakeEqualsAfterTurns(
                new List<Tile> { new Tile(-1, -1), new Tile(-1, 0), new Tile(0, 0), new Tile(0, 1) },
                Direction.Right,
                Direction.Right,
                Direction.Right);
        }

        [TestMethod]
        public void TestGrow()
        {
            AssertSnakeEqualsAfterGrow(
                snake,
                new List<Tile> { new Tile(0, -1), new Tile(0, 0), new Tile(0, 1), new Tile(1, 1), new Tile(2, 1) });
            
            AssertSnakeEqualsAfterGrow(
                oneLengthSnake,
                new List<Tile> { new Tile(0, -1), new Tile(0, 0) });
        }

        private void AssertSnakeEqualsAfterGrow(Snake snake, List<Tile> bodyAfterGrow)
        {
            snake.MoveOnAndGrow();
            AssertBodiesAreEqual(bodyAfterGrow, snake.Body);
        }
    }
}
