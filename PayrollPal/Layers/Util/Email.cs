using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;

namespace PayrollPal.Layers.Util
{
    class Email
    {
        private static readonly log4net.ILog _MyLogControlEventos =
                             log4net.LogManager.GetLogger("MyControlEventos");

        private static MailMessage correo;
        private static Attachment dato;
        private static StringBuilder mensaje = new StringBuilder();
        private static string asunto;

        public String ContrasenaGeneradaGmail = "tcprbobjrnevtoyx";

        public static void Enviar(string cuerpo, string pNombreColaborador, string correoColaborador, string adjunto)
        {

            // mensaje            
            mensaje.AppendFormat("Estimado: ");
            mensaje.AppendFormat(pNombreColaborador);
            mensaje.AppendFormat("\n\nAdjunto encontrará la planilla de pago correspondiente");
            mensaje.AppendFormat("\n\nEstamos para servirle.");

            // Asunto
            asunto = "Envio de planilla";

            try
            {

                correo = new MailMessage();
                correo.To.Add(new MailAddress(correoColaborador));
                // Persona que va a enviar el mensaje
                correo.From = new MailAddress("yt2023br@gmail.com");
                // Establecer el asunto del mensaje
                correo.Subject = asunto;
                // Establer el cuerpo del mensaje
                correo.Body = mensaje.ToString();
                correo.IsBodyHtml = false;

                if (!string.IsNullOrEmpty(adjunto))
                {
                    dato = new Attachment(adjunto, MediaTypeNames.Application.Octet);
                    correo.Attachments.Add(dato);
                }

                SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587);
                using (cliente)
                {
                    cliente.Credentials = new System.Net.NetworkCredential("yt2023br@gmail.com", "tcprbobjrnevtoyx");
                    cliente.EnableSsl = true;
                    cliente.Send(correo);
                }
            }
            catch (Exception msg)
            {

                //Salvar un mensaje de error en la tabla Bitacora_Log4Net
                //de la base de datos
                //_MyLogControlEventos.Error((Utilitarios.CreateGenericErrorExceptionDetail(MethodBase.GetCurrentMethod()
                //    , msg)));

                //Mostrar mensaje al usuario
                MessageBox.Show("Se ha producido el siguiente error: " + msg.Message, "Error");

            }

        }
        
    }
}
