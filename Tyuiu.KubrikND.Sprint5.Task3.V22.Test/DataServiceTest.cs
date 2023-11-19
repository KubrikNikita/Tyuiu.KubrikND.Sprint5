using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint5.Task3.V22.Lib;
using System.IO;

namespace Tyuiu.KubrikND.Sprint5.Task3.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.KubrikND.Sprint5\Tyuiu.KubrikND.Sprint5.Task3.V22\bin\Debug\OutPutFileTask3.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}