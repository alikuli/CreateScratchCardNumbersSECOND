using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScratchCardNumbers.Models
{
    public static class Global
    {

        //max number
        private static string _maxNo;
        public static string MaxNo 
        {
            get
            {
                return _maxNo;
            }

            //set
            //{
            //    _maxNo = value;
            //}
        }

        private static int _lengthOfNumber;
        public static int lengthOfNumber 
        { 
            get 
            { 
                return _lengthOfNumber; 
            }
            set 
            { 
                _lengthOfNumber = value;
                string number = "";
                for(int i=0;i<_lengthOfNumber;i++)
                {
                    number += "9";
                }

                _maxNo = number;
            }
        }
    }
}
