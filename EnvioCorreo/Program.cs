using System;

namespace EnvioCorreo
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.Correo mail = new Utilidades.Correo();

            mail.CorreoRemitente = "guillermo.guerrero@mobiik.com";
            mail.CorreoDestinatario = "smaguilar@brainupco.com";
            mail.Contrasena = "Jacquelinda29";
            mail.NombreRemitente = "Will Krieger";
            mail.Asunto = "Asunto";
            mail.Mensaje = "Mensaje de prueba";
            mail.ArchivoAdjunto = System.IO.Path.GetFullPath(@"/Users/willkrieger/Projects/EnvioCorreo/EnvioCorreo/bin/Debug/netcoreapp2.2/EnvioCorreo.deps.json");

            mail.ServidorSmtp = "smtp.office365.com";
            mail.Puerto = 587;
            mail.SSL = true;

            mail.Enviar();
        }
    }
}
