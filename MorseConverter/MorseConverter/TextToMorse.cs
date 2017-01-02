using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseConverter
{
    public class TextToMorse
    {
        public string input = null;

        #region
        Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {'A' , ".-"},
                {'B' , "-..."},
                {'C' , "-.-."},
                {'D' , "-.."},
                {'E' , "."},
                {'F' , "..-."},
                {'G' , "--."},
                {'H' , "...."},
                {'I' , ".."},
                {'J' , ".---"},
                {'K' , "-.-"},
                {'L' , ".-.."},
                {'M' , "--"},
                {'N' , "-."},
                {'O' , "---"},
                {'P' , ".--."},
                {'Q' , "--.-"},
                {'R' , ".-."},
                {'S' , "..."},
                {'T' , "-"},
                {'U' , "..-"},
                {'V' , "...-"},
                {'W' , ".--"},
                {'X' , "-..-"},
                {'Y' , "-.--"},
                {'Z' , "--.."},
                {'0' , "-----"},
                {'1' , ".----"},
                {'2' , "..---"},
                {'3' , "...--"},
                {'4' , "....-"},
                {'5' , "....."},
                {'6' , "-...."},
                {'7' , "--..."},
                {'8' , "---.."},
                {'9' , "----."},
            };
        #endregion

        public TextToMorse(string input) //constructor 
        {
            if (!string.IsNullOrEmpty(input))
            {
                this.input = input.ToUpper();
            }
            else
            {
                Console.WriteLine("Enter Text input please.");  
            }


        }


       

        public string GetMorseFromText(string english)

    {
            StringBuilder sb = new StringBuilder();

            try
            {

                foreach (char character in english)
                {
                    if (morse.ContainsKey(character))
                    {
                        sb.Append(morse[character] + "||" );
                        
                    }
                    else if (character == ' ')
                    {
                        sb.Append("||");
                    }
                    else
                    {
                        sb.Append(character + " ");
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

            return sb.ToString();

        } // end of method

        
    


    }//End of Class





}
