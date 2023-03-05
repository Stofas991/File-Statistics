using File_Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Test_Project
{
    [TestClass]
    public class AnalyserTests
    {
        [TestMethod]
        public void Count_OneLine23Characters_Returns1Line23Characters1Sentence5Words()
        {
            //arrange
            var Analyser = new Analyser();

            //Act
            Analyser.Count("Hello, This is a test. ");

            //Assert
            Assert.AreEqual(23, Analyser.characters);
            Assert.AreEqual(5, Analyser.words);
            Assert.AreEqual(1, Analyser.sentences);
            Assert.AreEqual(1, Analyser.lines);
        }

        [TestMethod]
        public void Count_5EmptyLines_Returns5Lines5Characters0Sentence0Words()
        {
            //arrange
            var Analyser = new Analyser();

            //Act
            Analyser.Count("\n\n\n\n\n");

            //Assert
            Assert.AreEqual(5, Analyser.characters);
            Assert.AreEqual(0, Analyser.words);
            Assert.AreEqual(0, Analyser.sentences);
            Assert.AreEqual(6, Analyser.lines);
        }

        [TestMethod]
        public void Count_TabWithTextNewLineAnotherText_Return36Chars6Words3Sentences2Lines()
        {
            //arrange
            var Analyser = new Analyser();

            //Act
            Analyser.Count("    Ahoj.\nJak se máš? Pět mezer.");

            //Assert
            Assert.AreEqual(32, Analyser.characters);
            Assert.AreEqual(6, Analyser.words);
            Assert.AreEqual(3, Analyser.sentences);
            Assert.AreEqual(2, Analyser.lines);
        }
    }
}
