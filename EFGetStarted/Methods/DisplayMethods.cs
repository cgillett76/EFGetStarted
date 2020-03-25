using System;
using System.Collections.Generic;
using System.Text;

namespace EFGetStarted.Methods
{
    class DisplayMethods
    {
        public static void DisplayHeader(string title)
        {
            for (int i = 0; i < 52; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();

            string titleBorder = "#####";

            int paddingLength = (40 - title.Length) / 2;

            string paddingText = "";

            for (int i = 0; i < (paddingLength + 1); i++)
            {
                paddingText += " ";
            }

            Console.WriteLine("{0}{1}{2}{3}{4}", titleBorder, paddingText, title, paddingText, titleBorder);

            for (int i = 0; i < 52; i++)
            {
                Console.Write("#");
            }

            Console.WriteLine();
        }

    }
}
