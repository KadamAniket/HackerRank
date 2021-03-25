using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Algorithms
{
    public class Encryption
    {
        // Complete the encryption function below.
        static string encryption(string s)
        {
            string output = string.Empty;


            string inputWithoutSpace = s.Replace(" ", "");
            int rowCount = Convert.ToInt32(Math.Floor(Math.Sqrt(inputWithoutSpace.Length)));
            int columnCount = Convert.ToInt32(Math.Ceiling(Math.Sqrt(inputWithoutSpace.Length)));
            string[] encryptionMatrix = new string[columnCount];

            for (int i = 0; i < inputWithoutSpace.Length; i = i + columnCount)
            {
                // Create Final String
                for (int j = 0; j < columnCount; j++)
                {
                    if (i + j < inputWithoutSpace.Length)
                    {
                        encryptionMatrix[i % columnCount + j] += inputWithoutSpace[i + j];
                    }
                }


            }

            for (int i = 0; i < columnCount; i++)
            {
                output += encryptionMatrix[i] + " ";
            }


            return output.Trim();
        }

        //static string encryption(string s)
        //{
        //    string output = string.Empty;


        //    string inputWithoutSpace = s.Replace(" ", "");
        //    int rowCount = Convert.ToInt32(Math.Floor(Math.Sqrt(inputWithoutSpace.Length)));
        //    int columnCount = rowCount + 1;

        //    string[] encryptionMatrix = new string[rowCount];
        //    int j = 0;

        //    for (int i = 0; i < inputWithoutSpace.Length; i = i + columnCount)
        //    {
        //        // Create encyrption Matrix
        //        if (i + columnCount > inputWithoutSpace.Length)
        //        {
        //            encryptionMatrix[j] = inputWithoutSpace.Substring(i);
        //        }
        //        else
        //        {
        //            encryptionMatrix[j] = inputWithoutSpace.Substring(i, columnCount);
        //        }
        //        j++;
        //    }


        //    return output.Trim();
        //}

        public static void calculate()
        {
            string input = "if man was meant to stay on the ground god would have given us roots";
            Console.WriteLine(encryption(input));
        }
    }
}
