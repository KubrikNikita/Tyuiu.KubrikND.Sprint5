using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KubrikND.Sprint5.Task1.V24.Lib;

namespace Tyuiu.KubrikND.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.KubrikND.Sprint5\Tyuiu.KubrikND.Sprint5.Task1.V24\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
