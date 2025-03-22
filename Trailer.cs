using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    internal class Trailer : Vehiculo
    {
        private string numerodeejes;
        private string gasolina;
        public Trailer(int anio, string elColor, string elModelo, string numerodeejes, string gasolina) : base(anio, elColor, elModelo)
        {
            TiposLicenciaAceptado = new List<string> { "A" };
            this.numerodeejes = numerodeejes;
            this.gasolina = gasolina;
        }

        public override void acelerar(int cuanto)
        {
            base.acelerar(cuanto);
            
        }
    }
}
