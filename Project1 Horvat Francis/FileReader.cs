﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// File reader class to read in the input from a file.
namespace Project1_Horvat_Francis
{
    class FileReader
    {
        private List<String> wordList;

        public FileReader()
        {

        }

        public void readFile()
        {
            wordList = new List<string>();

            using (StreamReader Reader = new StreamReader("Words5.txt"))
            {
                while (!Reader.EndOfStream)
                {
                    wordList.Add(Reader.ReadLine().ToUpper());
                    Debug.WriteLine(Reader.ReadLine() + " has been added to the list");
                }
                    
            }
        }

        public List<string> getList()
        {
            return wordList;
        }
    }
   
}
