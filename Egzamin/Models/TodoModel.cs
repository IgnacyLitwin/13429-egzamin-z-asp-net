using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Egzamin.Models
{
    public class TodoModel
    {
        public int IdZad { get; set; }
        public string Nazwa { get; set; }
        public string  Opis { get; set; }
        public bool Zrob { get; set; }
    }
}
