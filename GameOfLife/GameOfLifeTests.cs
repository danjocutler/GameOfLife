using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GameOfLife
{
    [TestFixture]
    public class CreateBoardTests
    {
        private GameOfLifeBoard _board;

        [SetUp]
        public void Setup()
        {
            _board = new GameOfLifeBoard(10, 20);
        }

        [Test]
        public void Board_GivenDimensions_CanBeCreated()
        {
            Assert.That(_board.Width, Is.EqualTo(10));
            Assert.That(_board.Height, Is.EqualTo(20));
        }

        [Test]
        public void Board_Created_HasRows()
        {
            Assert.That(_board.Rows.Count, Is.EqualTo(20));
        }

        [Test]
        public void Board_Created_HasCells()
        {
           Assert.That(_board.Rows[0][0], Is.TypeOf<Cell>());
        }

        [Test]
        public void Board_WithDeadCells_ShowAsDashes()
        {
            // use the text output console in NUnit to
            // get a visual representation of the board
            var output = _board.Render(_board);

            Assert.That(output.First(), Is.EqualTo("----------"));

            foreach (var line in output)
            {
                Console.WriteLine(line);
            }
        }

        [Test]
        public void Board_WithAliveCells_ShowAsHashes()
        {
            var cell = new List<Cell>();
            cell.Add(new Cell { IsAlive = false});

            var output = _board.Render(_board);

            Assert.That(output.First(), Is.EqualTo("##########"));
        }        
    }
}
