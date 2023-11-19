using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KubrikND.Sprint5.Task2.V20.Lib;

namespace Tyuiu.KubrikND.Sprint5.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Test2()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.KubrikND.Sprint5\Tyuiu.KubrikND.Sprint5.Task2.V20\bin\Debug\OutPutFileTask2.csv";
            FileInfo fileinfo = new FileInfo(path);
            bool fileex = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileex);
        }
    }
}
