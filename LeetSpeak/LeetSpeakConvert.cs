using System;
namespace LeetSpeak
{
    public class LeetSpeakConvert
    {
        public string Convert(string input)
        {           
            string converted = "";
            for (int i = 0; i < input.Length; i++)
            {
                converted += 
                    (input[i] == 'e' || input[i] == 'E') ? '3' : 
                    (input[i] == 'o' || input[i] == 'O') ? '0' :
                    (input[i] == 't' || input[i] == 'T') ? '7' :
                    ((input[i] == 's' || input[i] == 'S') && i != 0) ? 'Z' :
                    input[i];
            }
            return converted;
        }
    }
}
