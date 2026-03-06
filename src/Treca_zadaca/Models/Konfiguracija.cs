using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treca_zadaca.Models
{
    public class Konfiguracija
    {
        public int IdKonfiguracije { get; set; }
        public string Naziv { get; set; }
        public override string ToString()
        {
            return $"{Naziv}";
        }
    }

}
