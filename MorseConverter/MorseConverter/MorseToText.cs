using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{

    class MorseToText
    {
        string[] delimiter = { "||" };

        #region
        Dictionary<String, char> morsedict = new Dictionary<String, char>()
            {
                { ".-",'A'},
                { "-...",'B'},
                { "-.-.",'C'},
                {  "-..",'D'},
                { ".",'E'},
                { "..-.",'F'},
                { "--.",'G'},
                { "....",'H'},
                { "..",'I'},
                { ".---",'J'},
                { "-.-",'K'},
                { ".-..",'L'},
                { "--",'M'},
                { "-.",'N'},
                { "---",'O'},
                { ".--.",'P'},
                { "--.-",'Q'},
                { ".-.",'R'},
                { "...",'S'},
                { "-",'T'},
                { "..-",'U'},
                { "...-",'V'},
                {  ".--",'W'},
                {  "-..-",'X'},
                {  "-.--",'Y'},
                {  "--..",'Z'},
                {  "||||",' '},
                { "-----",'0'},
                {  ".----",'1'},
                {  "..---",'2'},
                {  "...--",'3'},
                {  "....-",'4'},
                { ".....",'5' },
                {  "-....",'6'},
                { "--...",'7' },
                {"---..",'8' },
                { "----.",'9' },
            };
        #endregion


        public List<string> RawLinesToParsedMorseCharArray(List<string> rawlines) // This Method Convert Raw lines to Just Morse char list (array)
        {
            string[] temp = null;
           
            var morseCharArray = new List<string>();

            try
            {
                foreach (string key in rawlines)
                {
                    if (!string.IsNullOrEmpty(key)) // not empty

                    {
                        temp = key.Split(delimiter, StringSplitOptions.None);// splitting each char from the morse string (each Line)

                        // loop to add all splitted Char to the list
                        for (int i = 0; i < temp.Length; i++)
                        {
                            morseCharArray.Add(temp[i]);
                        }
                        morseCharArray.Add("\n"); // next line 
                    }


                } // end for each

            } // try

            //Exception handling
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("An index was out of range!" + ex.StackTrace);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Some sort of error occured: " + ex.StackTrace);

            }

            return morseCharArray;


        }   // end method



        public List<string> morseCharArrayTotxtLinesList(List<string> morseCharArray)

        {
            StringBuilder sb = new StringBuilder();
            var textarray =new  List<string>();

            try
            {

                foreach (string key in morseCharArray) // Compare each Morse char from the array
                {
                    if (morsedict.ContainsKey(key)) // check if the char exist in the dictonary
                    {
                        sb.Append(morsedict[key]); // Converting char by char  morse to Eng text and building string 
                    }
                    else if (key == "") // appending space
                    {
                        sb.Append(" ");
                    }

                    else if (key == "\n")
                    {
                        sb.Append(Environment.NewLine); // going to the next line
                        
                    }
                   

                } // end for each

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

            textarray.Add(sb.ToString());
            return textarray;

        } // end method


} // end class




} //end namespace



