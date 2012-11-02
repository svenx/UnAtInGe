using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnAtInGeCore
{
    using System.IO;

    using UnAtInGeCore.Commands;

    public class CreateBatch
    {

        public void CreateFile(string path, string name)
        {
            path = "D:\\Users\\Sven\\Desktop\\";
            name = "install.bat";

            string filepath = path + name;

            if (!File.Exists(filepath))
            {
                File.Delete(filepath);
            }
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(filepath))
            {
                CommandText title = new CommandText("sdfajlk");
                title.Text = "Hello";
                
                sw.WriteLine("@echo off");
                sw.WriteLine(title.Titel());
                sw.WriteLine("pause");
            }
        }

    }
}
