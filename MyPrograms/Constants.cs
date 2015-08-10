using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliKuli
{
    public static class Constants
    {
        public const string excludeFileName="Exclude.txt";
        
        public static  string backUpExcludeFile= string.Format("ExcludeBackup_{0}.txt",DateTime.Now.Ticks.ToString());
    }
}
