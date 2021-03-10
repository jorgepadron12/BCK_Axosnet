using System;

namespace BCK_Axosnet.Model
{
    public class UsuarioModel
    {
        public Int16 IdUsuario { get; set; }

        public String Usuario { get; set; }

        public String Clave { get; set; }

        public String NombreCompleto { get; set; }

        public Int16 Perfil { get; set; }
    }
}