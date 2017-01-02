using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{

    class ReadAndParseFile
    {

        char[] delimiters = { '\t',' ' };
        List<string> linelist = new List<string>();


        public List<string> ArrayOfLinesFromFile(string filepath)
        {

            try
            {
                int tempindex = 0;
                if (new FileInfo(filepath).Length == 0) // Checking if the file is empty.
                {
                    Console.WriteLine("The File is Empty");
                }
                else

                {
                    // Read one line each time from file till the EOF.
                    foreach (string line in File.ReadLines(filepath))
                    {
                        string[] temp = null;

                        if (!(string.IsNullOrEmpty(line))) // exclude empty line
                        {

                            temp = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); //deleting \t and "  "
                            linelist.Add(temp[tempindex]);//building linelist (array) of just Morse string 

                        }
                    }



                }
            }
            //Exception handling
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An index was out of range!" + ex.StackTrace);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some sort of error occured: " + ex.StackTrace);

            }

         
            
            return linelist;

           
        }

    }// end of class



} // end of namespace
