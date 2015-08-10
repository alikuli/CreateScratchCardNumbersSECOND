using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScratchCardNumbers.MyPrograms
{
    public static class PrintNumber
    {
        public static string Print(long number)
        {
            switch (Models.Global.lengthOfNumber)
            {
                case 11:
                    return number.ToString("00000000000");

                case 12:
                    return number.ToString("000000000000");

                case 13:
                    return number.ToString("0000000000000");

                case 14:
                    return number.ToString("00000000000000");

                case 15:
                    return number.ToString("000000000000000");

                case 16:
                    return number.ToString("0000000000000000");

                default:
                    return number.ToString("0000000000000000");
                    
            }

        }
    }
}
