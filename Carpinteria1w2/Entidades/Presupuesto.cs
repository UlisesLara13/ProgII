using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Carpinteria1w2.Entidades
{
    internal class Presupuesto
    {
        public int PresupuestoNro { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public double CostoMO { get; set; }

        public double Descuento { get; set; }

        public DateTime FechaBaja { get; set; }

        public List<DetallePresupuesto> Detalles { get; set; }

        public Presupuesto(int presupuestoNro, DateTime fecha, string cliente, double costoMO, double descuento, DateTime fechaBaja, List<DetallePresupuesto> detalles)
        {
            PresupuestoNro = presupuestoNro;
            Fecha = fecha;
            Cliente = cliente;
            CostoMO = costoMO;
            Descuento = descuento;
            FechaBaja = fechaBaja;
            Detalles = detalles;
        }
    }
}
