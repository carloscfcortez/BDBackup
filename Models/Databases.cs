using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBak.Models
{
    public class Databases
    {
        public string name { get; set; }

        public bool backup { get; set; }

        public string directory { get; set; }

        public string times { get; set; }

        public Databases()
        {


        }
    }
}
