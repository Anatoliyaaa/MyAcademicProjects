using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ЛР_11;
using System.IO;
using System.Windows.Forms;

namespace DecoratorforFileTest
{
    [TestClass]
    public class MyFileTest
    {
        [TestMethod]
        public void TextFileTest()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "C:/Users/MSI GF63/Desktop/мусор (нет)/универ/Лабы/4 семестр/МООП/ЛР№11/TextTest.txt";
            ЛР_11.File file = new TextFile(openFileDialog);
            string exeption = "qwe";
            Assert.AreEqual(exeption,file.PrintText());
        }
        [TestMethod]
        public void TextFileNameTest()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "C:/Users/MSI GF63/Desktop/мусор (нет)/универ/Лабы/4 семестр/МООП/ЛР№11/TextTest.txt";
            ЛР_11.File file = new TextFile(openFileDialog);
            string exeption = "Название файла: TextTest.txt\r\n\r\nqwe";
            file = new FileName(file);
            Assert.AreEqual(exeption, file.PrintText());
        }
        [TestMethod]
        public void TextFileDataTest()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "C:/Users/MSI GF63/Desktop/мусор (нет)/универ/Лабы/4 семестр/МООП/ЛР№11/TextTest.txt";
            ЛР_11.File file = new TextFile(openFileDialog);
            string exeption = "25.04.2021 19:04:44\r\n\r\nqwe";
            file = new FileData(file);
            Assert.AreEqual(exeption, file.PrintText());
        }
    }
}
