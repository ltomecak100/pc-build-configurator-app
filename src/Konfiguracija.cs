using System;

namespace Treca_zadaca
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

