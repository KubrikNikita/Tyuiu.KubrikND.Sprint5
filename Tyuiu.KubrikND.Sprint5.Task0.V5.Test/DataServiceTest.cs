using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KubrikND.Sprint5.Task0.V5.Lib;
using System.IO;

namespace Tyuiu.KubrikND.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Nikita\source\repos\Tyuiu.KubrikND.Sprint5\Tyuiu.KubrikND.Sprint5.Task0.V5\bin\Debug\OutPutFileTask0.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileexists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileexists);
        }
    }
}
