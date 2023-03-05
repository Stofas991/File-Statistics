using File_Statistics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Unit_Test_Project
{
    [TestClass]
    public class ActionsTests
    {
        [TestMethod]
        public void RemoveDiacritics_SentenceWithDiacritics_ReturnRemovedDiacritics()
        {
            //arrange
            var Actions = new Actions();
            ProgressBar progressBar = new ProgressBar();
            BackgroundWorker bw = new BackgroundWorker();
            Actions.FileContent = "Ahoj, krátký text po odstranění diakritiky.";
            bw.WorkerReportsProgress = true;
            //Act
            Actions.RemoveDiacritics(progressBar, bw);

            //Assert
            Assert.AreEqual("Ahoj, kratky text po odstraneni diakritiky.", Actions.FileContent);
        }

        [TestMethod]
        public void RemovePunctuation_SentenceWithPunctuationAndSpaces_ReturnRemovedSpacesAndPunctuationWordsReplacedWithCamelCase()
        {
            //arrange
            var Actions = new Actions();
            ProgressBar progressBar = new ProgressBar();
            BackgroundWorker bw = new BackgroundWorker();
            Actions.FileContent = "Ahoj, krátký text po odstranění diakritiky.";
            bw.WorkerReportsProgress = true;
            //Act
            Actions.RemovePunctuation(progressBar, bw);

            //Assert
            Assert.AreEqual("AhojKrátkýTextPoOdstraněníDiakritiky", Actions.FileContent);
            
        }

        [TestMethod]
        public void RemoveEmptyLines_TextWithEmptyLines_ReturnTextWithoutEmptyLines()
        {
            //arrange
            var Actions = new Actions();
            Actions.FileContent = "Ahoj\r\n\r\njak se máš.";

            //Act
            Actions.RemoveEmptyLines();

            //Assert
            Assert.AreEqual("Ahoj\r\njak se máš.", Actions.FileContent);

        }

    }
}
