using System;
using System.Collections.Generic;
using System.Text;

namespace GPSGatewaySimulator.RandomPoints
{
    public class GeneryRandomString
    {
        #region public methods

        public static string GetRandomString(RandomStringType randomType, int stringLength,int seed)
        {
            string[] sCaptions = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string[] sNumbers = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Random rnd = new Random(seed);
            string sResult = string.Empty;

            for (int i = 0; i < stringLength; i++)
            {
                if (randomType == RandomStringType.OnlyNumber)
                {
                    sResult += sNumbers[rnd.Next(0, 9)];
                }
                else if (randomType == RandomStringType.OnlyChar)
                {
                    sResult += sCaptions[rnd.Next(0, 25)];
                }
                else if (randomType == RandomStringType.NumberAndChar)
                {
                    sResult += sNumbers[rnd.Next(0, 9)] + sCaptions[rnd.Next(0, 25)];
                    sResult = sResult.Remove(rnd.Next(0, sResult.Length - 1), 1);
                }
            }

            return sResult;
        }

        #endregion
    }
}
