using System.Numerics;

namespace _18._06._24_Class_Work_C__
{
    internal class Program
    {
        static string[] units = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] teens = { "ten" ,"eleven", "twelve", "thirteen", "fourteen" ,"fifteen" ,"sixteen" ,"seventeen" ,"eighteen" ,"nineteen" };
        static string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string[] hundreds = { "", "one hundred", "two hundred", "three hundred", "four hundred", "five hundred", "six hundred", "seven hundred", "eight hundred", "nine hundred" };
        static string[] thousands = { "", "thousand", "thousand", "thousands", "thousands" };

        static void Main(string[] args)
        {
            //двумерный массив
            //int[,] arr = new int[,]
            //{
            //{  1,  2,  3,  4,  5,  6 },
            //{  7,  8,  9, 10, 11, 12 },
            //{ 13, 14, 15, 16, 17, 18 },
            //{ 19, 20, 21, 22, 23, 24 },
            //{ 25, 26, 27, 28, 29, 30 }
            //};

            //for (int y = 0; y < 5; y++)
            //{
            //    for (int x = 0; x < 6; x++)
            //    {                 
            //        Console.Write(arr[y, x] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //2
            int[,] arr = new int[,]
            {
            {  1,  2,  3,  4,  5,  6 },
            {  12,  11,  10, 9, 8, 7 },
            { 13, 14, 15, 16, 17, 18 },
            { 24, 23, 22, 21, 20, 19 },
            { 25, 26, 27, 28, 29, 30 }
            };

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 6; x++)
                {
                    Console.Write(arr[y, x] + "\t");
                }
                Console.WriteLine();
            }

            //одномерный массив
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    string result = NumberToWords(number);
            //    Console.WriteLine(result);
            //}
            //static string NumberToWords(int number)
            //{
            //    if (number == 0)
            //        return "ноль";

            //    int thousandsPart = number / 1000;
            //    int hundredsPart = (number % 1000) / 100;
            //    int tensPart = (number % 100) / 10;
            //    int unitsPart = number % 10;

            //    string result = "";

            //    if (thousandsPart > 0)
            //    {
            //        result += hundreds[thousandsPart] + " " + GetThousandForm(thousandsPart) + " ";
            //    }

            //    if (hundredsPart > 0)
            //    {
            //        result += hundreds[hundredsPart] + " ";
            //    }

            //    if (tensPart == 1)
            //    {
            //        result += teens[unitsPart] + " ";
            //    }
            //    else
            //    {
            //        result += tens[tensPart] + " ";
            //        result += units[unitsPart] + " ";
            //    }

            //    return result.Trim();
            //}

            //static string GetThousandForm(int thousandsPart)
            //{
            //    if (thousandsPart == 1)
            //        return thousands[1];
            //    else if (thousandsPart >= 2 && thousandsPart <= 4)
            //        return thousands[2];
            //    else
            //        return thousands[3];
            //}
        }
    }
}