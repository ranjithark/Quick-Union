using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace quickUnion
{
    class Program
    {
        static void Main(string[] args)
        {
            string theInputFile = @"F:\Holidays Project\Algorithms\quickUnion\data.txt";
            int wordPointer = 0;

            if (File.Exists(theInputFile))
            {

                System.IO.StreamReader myFile = new System.IO.StreamReader(theInputFile);
                string fileContents = myFile.ReadToEnd();

                myFile.Close();
                string[] words = fileContents.Split(' ', '\n');

                //create objects
                quickUnion quickUnionObj = new quickUnion(Convert.ToInt32(words[wordPointer++]));

                while (wordPointer < words.Length)
                {
                    if (!quickUnionObj.connected(Convert.ToInt32(words[wordPointer]), Convert.ToInt32(words[wordPointer + 1])))
                    {
                        quickUnionObj.union(Convert.ToInt32(words[wordPointer]), Convert.ToInt32(words[wordPointer + 1]));
                    }
                    wordPointer = wordPointer + 2;

                }



                //Check whether Nodes 4 and 7 are connected
                Console.Out.WriteLine(quickUnionObj.connected(4, 7));


                //Check whether Nodes 0 and 9 are connected
                Console.Out.WriteLine(quickUnionObj.connected(0, 9));




            }
            else
            {

                Console.Out.Write("Reconfigure the File path in Program.cs file");


            }
            Console.Read();

        }
    }
}
