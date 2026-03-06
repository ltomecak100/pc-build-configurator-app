using System;

namespace Treca_zadaca
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

