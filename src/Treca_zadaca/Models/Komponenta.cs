using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treca_zadaca.Models
{
    public class Komponenta
    {
        public int IdKomponente { get; set; }
        public string Naziv { get; set; }
        public string Tip { get; set; }
        public string Proizvodac { get; set; }
        public float Cijena { get; set; }
        public int IdZaposlenika { get; set; }
        public override string ToString()
        {
            return $"{Naziv}({Proizvodac})";

        }

    }

}
