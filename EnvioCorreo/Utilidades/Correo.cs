using System;
using System.Net.Mail;

namespace EnvioCorreo.Utilidades
{
    public class Correo
    {
        public string ServidorSmtp { get; set; }
        public int Puerto { get; set; }
        public bool SSL { get; set; }
        public string CorreoRemitente { get; set; }
        public string NombreRemitente { get; set; }
        public string CorreoDestinatario { get; set; }
        public string Asunto { get; set; }
        public string Mensaje { get; set; }
        public string Contrasena { get; set; }
        public string ArchivoAdjunto { get; set; }

        public void Enviar()
        {
            try
            {
                MailMessage correo = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                correo.From = new MailAddress(CorreoRemitente, NombreRemitente, System.Text.Encoding.UTF8);
                correo.To.Add(CorreoDestinatario);

                correo.Subject = Asunto;
                correo.SubjectEncoding = System.Text.Encoding.UTF8;

                correo.Body = Mensaje;
                correo.BodyEncoding = System.Text.Encoding.UTF8;

                correo.IsBodyHtml = false;
                correo.Priority = MailPriority.Normal;

                correo.Attachments.Add(new Attachment(ArchivoAdjunto));

                smtp.Credentials = new System.Net.NetworkCredential(CorreoRemitente, Contrasena);
                smtp.Port = Puerto;
                smtp.Host = ServidorSmtp;
                smtp.EnableSsl = SSL;

                smtp.Send(correo);


            }
            catch (Exception ex)
            {
                
            }
        }
    }
}
