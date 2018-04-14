using System;
using NUnit.Framework;
using System.Linq;
using System.Drawing;
using Checkers;

namespace Checkers.Test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ABoardHas12BlackAnd12WhitePieces()
        {
            Board b = new Board();
            //int blackCount = b.Pieces(Color.Black).Count();
            //int whiteCount = b.Pieces(Color.White).Count();
            int blackCount = b.Pieces(Color.Black).Count();
            int whiteCount = b.Pieces(Color.White).Count();
            Assert.That(blackCount == 12);
            Assert.That(whiteCount == 12);
        }
    }
}
