using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;


namespace ЛР_11
{
     abstract public class File
     {
        public static OpenFileDialog MyStr { get; protected set; }
        public File(OpenFileDialog myStr)
        {

            MyStr = myStr;
        }
        public abstract string PrintText();
     
     }
    public class TextFile:File
    {
        public TextFile(OpenFileDialog myStr): base(myStr)
        { }
        public override string PrintText()
        {
            Stream stream = MyStr.OpenFile();
            StreamReader myRead = new StreamReader(stream, System.Text.Encoding.UTF8);
            return myRead.ReadToEnd();
        }
    }

    abstract public class FileDecorator : File
    {
        protected File file;
        public FileDecorator(File file, OpenFileDialog myStr) : base(myStr)
        {
            this.file = file;
        }
    }

    public class FileName : FileDecorator
    {
        public FileName(File file/*, Stream myStr*/) : base(file, MyStr)
        {
            this.file = file;
        }
        public override string PrintText()
        {
           
            return "Название файла: "+MyStr.SafeFileName + Environment.NewLine + Environment.NewLine + file.PrintText();
        }
    }

    public class FileData : FileDecorator
    {
        public FileData(File file) : base(file, MyStr)
        {
            this.file = file;
        }
        public override string PrintText()
        {
            string s = System.IO.File.GetCreationTime(MyStr.FileName) + Environment.NewLine + Environment.NewLine + file.PrintText();
            return System.IO.File.GetCreationTime(MyStr.FileName) + Environment.NewLine + Environment.NewLine + file.PrintText();
        }
    }
    public class FileNumStr : FileDecorator
    {
        public FileNumStr(File file) : base(file, MyStr)
        {
            this.file = file;
        }
        public override string PrintText()
        {
            string s="";
            string[] lines = file.PrintText().Split(new[] { "\n" }, StringSplitOptions.None);
            for (int i = 0; i < lines.Length; i++)
                s += (i+1) +": "+lines[i]+ "\n";

            return s;
        }
    }

}
