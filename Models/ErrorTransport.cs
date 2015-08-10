using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateScratchCardNumbers.Models
{
    public class ErrorTransport
    {

        public ErrorTransport()
        {
            Error = false;
        }
        public bool Error { get; set; }
        public string Message { get; set; }
    }
}
