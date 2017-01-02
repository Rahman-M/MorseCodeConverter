using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{
    class CaseProcess
    {
       
        List<string> parsedMorseCharArray = new List<string>();
        List<string> txtLinesList = new List<string>();



       public void RawMorseLinesToTextProcessorandOutput(List<string> rawlines)
        {

            try
            {
                MorseToText mtextu = new MorseToText();
                parsedMorseCharArray = mtextu.RawLinesToParsedMorseCharArray(rawlines);  // passing inputed raw lines to get Just Morse char list (array) 
                txtLinesList = mtextu.morseCharArrayTotxtLinesList(parsedMorseCharArray);//passing Morse char list (array) to get appended strings
                Console.WriteLine("Converted English Code : ");
                foreach (var text in txtLinesList)  // Output to screen
                {

                    Console.WriteLine(text);
                }

            }

            // Exception handling
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An index was out of range!" + ex.StackTrace);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some sort of error occured: " + ex.StackTrace);

            }


        }

    }

}
