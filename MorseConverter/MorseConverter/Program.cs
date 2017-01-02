using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{
    class Program
    {
        static void Main(string[] args)
        {


            string inputstring = null;
            string morsestring = null;
            List<string> rawLineLists = new List<string>();
            CaseProcess presentcase = new CaseProcess();
            int option = 0;

            try
            {
                #region

                Console.WriteLine("1: Translate From English Text to morse code");
                Console.WriteLine("2: Translate From morse code *******'FLAT FILE'****** to English Text");
                Console.WriteLine("3: Translate From morse code (User input) to English Text");
                //option = Convert.ToInt32(Console.ReadLine());
                string selection = Console.ReadLine();
                Int32.TryParse(selection, out option); // safer than  Convert.ToInt32


                switch (option) // user prefered choice to be executed.

                {

                    case 1: // English to Morse

                        Console.WriteLine("Enter English Text Here : ");
                        inputstring = Console.ReadLine();
                        TextToMorse textmrs = new TextToMorse(inputstring);
                        inputstring = textmrs.input;
                        morsestring = textmrs.GetMorseFromText(inputstring);
                        Console.WriteLine("Text Entered : " + inputstring);
                        Console.WriteLine("Converted Morse Code : " + morsestring);


                        break;



                    case 2: // Morse FLAT FILE to English

                        string filepath = "C:\\Users\\mandol\\Documents\\GitHub\\MorseCodeConverter\\Morsecode.txt";
                        ReadAndParseFile pfile = new ReadAndParseFile();
                        rawLineLists = pfile.ArrayOfLinesFromFile(filepath);
                        presentcase.RawMorseLinesToTextProcessorandOutput(rawLineLists); // All conversion and presentation


                        break;


                    case 3: // Morse user input  to English
                        Console.WriteLine("Enter Morse Code Here : ");
                        rawLineLists.Add(Console.ReadLine()); // Getting user input as Morse code
                        presentcase.RawMorseLinesToTextProcessorandOutput(rawLineLists);
                        break;


                }

                #endregion
            }

            catch (Exception ex)
            {
                Console.WriteLine(" There is Exception that need to be taken care of : " + ex.Message);

            }


            finally
            {
                Console.WriteLine("Press Enter to Exit : ");
                Console.ReadLine();// End of the program
            }



            }


        }



    }

