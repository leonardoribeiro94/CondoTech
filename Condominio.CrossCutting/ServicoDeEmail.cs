using System.Net;
using System.Net.Mail;

namespace Condominio.CrossCutting
{
    public static class ServicoDeEmail
    {
        public static void EnviaEmail(string destinatario, string assunto, string conteudo)
        {
            var mailMessage = new MailMessage();
            const string email = "condotech.noreply@gmail.com";
            mailMessage.To.Add(destinatario);
            mailMessage.From = new MailAddress(email);
            mailMessage.Subject = assunto;
            mailMessage.Body = conteudo;
            mailMessage.IsBodyHtml = true;
            mailMessage.Priority = MailPriority.High;


            var smtpClient = new SmtpClient
            {
                Credentials = new NetworkCredential(email, "condotech@2017"),
                Port = 587,
                Host = "smtp.gmail.com",
                EnableSsl = true
            };
            //Porta de envio do gmail.
            //provedor do gmail

            smtpClient.Send(mailMessage);
        }
    }
}
