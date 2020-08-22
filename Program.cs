using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace morseCode1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, String> morse = new Dictionary<char, String>()
            {
                {' ', " "},
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

            Console.Write("Escriba la oración que desea llevar a código morse:");
            String normaltext = Console.ReadLine();
            normaltext = normaltext.ToUpper();

            for (int i = 0; i < normaltext.Length; i++)
            {
                if (i > 0)
                    Console.Write('/');

                char c = normaltext[i];
                if (morse.ContainsKey(c))
                {
                    Console.Write(morse[c]);
                    sound(morse[c]);
                    Thread.Sleep(400);
                }       
            }
            Console.ReadKey();
        }
     
        static void dot()
        {
            Console.Beep(1000, 200);
        }
        static void dash()
        {
            Console.Beep(1000, 600);
        }

        static void sound(string letterMorse)
        {
         
            for (int i = 0; i < letterMorse.Length; i++)
            {

                char c = letterMorse[i];
                switch (c)
                {
                    case '.':
                        dot();
                        Thread.Sleep(200);
                        break;
                    case '-':
                        dash();
                        Thread.Sleep(200);
                        break;

                    case ' ':
                        Thread.Sleep(800);
                       
                        break;
                }

            }
        }
    }
}
