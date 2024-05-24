using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24.Lib;

namespace Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileInPut()
        {
            string path = @"C:\Users\ASUS\source\repos\Tyuiu.NedospasovaAE.Sprint5.Review\Tyuiu.NedospasovaAE.Sprint5.TaskReview.V24\bin\Debug\InPutDataFileTask7V24.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
