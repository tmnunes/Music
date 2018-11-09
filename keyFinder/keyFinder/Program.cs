using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            string input = "C";

            string output;

            switch (input)
            {
                case "C":
                    output = GetNotes(input, Common.Major, Common.keyboard);
                    break;
            }

        }

        static string GetNotes(string input, string tone, List<string> keyboard)
        {
            string response = input + ";";
            int keyIndex = keyboard.IndexOf(input);

            List<string> tonelist = new List<string>();
            tonelist = tone.ToArray().ToList();

            foreach (char ton in tonelist)
            {
                int sum = keyIndex + Convert.ToInt32(ton);

                if (sum > 11)
                    sum = sum - 12;

                response = response + keyboard[sum];
            }

            return response;
        }
    }

    public class Common
    {
        public static List<string> keyboard = new List<string>()
        {
            "C", 
            "C#",
            "D",
            "D#", 
            "E",
            "F",
            "F#",
            "G",
            "G#",
            "A", 
            "A#",
            "B"
        };

        public static string Major = "2212221";
    }
}
