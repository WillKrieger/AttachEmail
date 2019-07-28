using System;

namespace EnvioCorreo
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.Correo mail = new Utilidades.Correo();

            mail.CorreoRemitente = "guijac2000@gmail.com";
            mail.CorreoDestinatario = "gui_jac2000@hotmail.com";
            mail.Contrasena = "WillStyle";
            mail.NombreRemitente = "Will Krieger";
            mail.Asunto = "Asunto";
            mail.Mensaje = "Mensaje de prueba";
            mail.ArchivoAdjunto = System.IO.Path.GetFullPath(@"/Users/willkrieger/Projects/EnvioCorreo/EnvioCorreo/bin/Debug/netcoreapp2.2/EnvioCorreo.deps.json");

            mail.ServidorSmtp = "smtp.gmail.com";
            mail.Puerto = 587;
            mail.SSL = true;

            mail.Enviar();
        }
    }
}
