using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class DesignerPdfViewer
    {
        // Complete the designerPdfViewer function below.
        static int designerPdfViewer(int[] h, string word)
        {
            int maxHeight = 0,charHeight;

            foreach(char c in word){
                charHeight = h[Convert.ToInt32(c) - 97];
                if (charHeight > maxHeight)
                {
                    maxHeight = charHeight;
                }
            }

            return maxHeight * word.Length;

        }

        public static void calculate()
        {
            int[] alphabetHeight = new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            string word = "abc";

            Console.WriteLine(designerPdfViewer(alphabetHeight,word));
        }
    }
}
