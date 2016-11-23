using System;
using System.Collections;
using System.Collections.Generic;

namespace CodingDojoBankOCR
{
    internal class BankMachine
    {
        Dictionary<string, string> dict;

        public BankMachine()
        {
            dict = new Dictionary<string, string>();
            dict.Add(" _ "+
                     "| |"+
                     "|_|","0");
            dict.Add("   " +
                     "  |" +
                     "  |", "1");
            dict.Add(" _ " +
                     " _|" +
                     "|_ ", "2");
            dict.Add(" _ " +
                     " _|" +
                     " _|", "3");
            dict.Add("   " +
                     "|_|" +
                     "  |", "4");
            dict.Add(" _ " +
                     "|_ " +
                     " _|", "5");
            dict.Add(" _ " +
                     "|_ " +
                     "|_|", "6");
            dict.Add(" _ " +
                     "  |" +
                     "  |", "7");
            dict.Add(" _ " +
                     "|_|" +
                     "|_|", "8");
            dict.Add(" _ " +
                     "|_|" +
                     " _|", "9");
        }

        internal string ComputeInput(string line1, string line2, string line3)
        {
            var result = "";

            for( var num=0; num<9; num++)
            {
                 result += ParseNumber(line1, line2, line3, num);
            }

            return result;
        }

        internal string ParseNumber(string line1, string line2, string line3, int pos)
        {
            var line1Num = line1.Substring(pos * 3, 3);
            var line2Num = line2.Substring(pos * 3, 3);
            var line3Num = line3.Substring(pos * 3, 3);

            return dict[line1Num + line2Num + line3Num];
        }

        internal bool IsValid(string accountNumber)
        {
            int sum = 0;
            for ( int i = 0, length = accountNumber.Length - 1; i <= length; i++)
            {
                int factor = i + 1;
                sum += factor * int.Parse(accountNumber[length - i].ToString());
            }
            return sum % 11 == 0;
        }
    }
}