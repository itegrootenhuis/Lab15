﻿using System.Collections.Generic;
using System.IO;

namespace Models
{
    public class CountriesModel
    {
        public static string filePath = @"C:\Users\test\Documents\GrandCircus\Lab15\Lab15\counties.txt";
        public static StreamReader reader;
        public static StreamWriter writer;
        public static List<string> lines = new List<string>();

        public static List<string> ReadFile()
        {
            //reader = new StreamReader(filePath);
            using(reader = new StreamReader(filePath)){
                lines.Add(reader.ReadLine());

                if (!reader.EndOfStream)
                {
                    ReadFile();
                }
            }

            reader.Close();
            return lines;
        }

        public static void WriteFile(string countryName)
        {
            writer = new StreamWriter(filePath, true);
            writer.WriteLine(countryName);
            writer.Close();
        }
    }
}