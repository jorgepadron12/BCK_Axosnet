using System;

namespace BCK_Axosnet
{
    public class Recibo
    {
        public Int16 IdRecibo { get; set; }

        public Int16 IdProveedor { get; set; }

        public Decimal Monto { get; set; }

        public Int16 IdDivisa { get; set; }

        public String Comentario { get; set; }

        public DateTime FechaCreacion { get; set; }

        public Int16 IdUsuarioCreacion { get; set; }
    }
}
