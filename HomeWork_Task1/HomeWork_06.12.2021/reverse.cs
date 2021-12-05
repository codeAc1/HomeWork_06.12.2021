using System;
using System.Linq;

namespace HomeWork_06._12._2021
{
    class Reverse

    {
        public string Word;

        public String Cevir()
        {
            string FinalResult = string.Empty;

            foreach (string item in Word.Split(' '))
            {
                string result = string.Empty;

                foreach (char Char in item.ToCharArray())
                {
                    result = Char + result;
                }
                FinalResult = FinalResult + result + " ";
            }
            return FinalResult;

        }

    }



}
