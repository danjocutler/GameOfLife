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
        [Test]
        public void Board_GivenDimensions_CanBeCreated()
        {
            var board = new GameOfLifeBoard(10, 10);

            Assert.That(board.Width, Is.EqualTo(10));
            Assert.That(board.Height, Is.EqualTo(10));
        }
    }
}
