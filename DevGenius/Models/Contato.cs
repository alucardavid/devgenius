using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DevGenius.devgenius_DataSetTableAdapters;
using System.Net.Mail;
using System.Text;

namespace DevGenius.Models
{
    public class Contato
    {
        public string nome { get; set; }
        public string email { get; set; }
        public string tel { get; set; }
        public string msg { get; set; }

        public Contato()
        {

        }

        public string SalvarContato()
        {
            taContato ta = new taContato();

            ta.Insert(nome, email, tel, msg, DateTime.Now);

            MandarEmail();

            return "Contato enviado com sucesso, aguarde que entraremos em contato por e-mail ou telefone, obrigado!";
        }
        
        private void MandarEmail()
        {
            SmtpClient client = new SmtpClient();
            MailMessage nMail = new MailMessage();


            client.Port = 25;
            client.Host = "relay-hosting.secureserver.net";
            client.EnableSsl = false;
            client.Timeout = 40000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("contato@devgenius.com.br", "DevGenius@123");

            nMail.To.Add("contato@devgenius.com.br");
            nMail.From = new MailAddress("contato@devgenius.com.br");
            nMail.Subject = "Novo Contato";
            nMail.BodyEncoding = UTF8Encoding.UTF8;
            nMail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            nMail.IsBodyHtml = true;
            nMail.Body = "<p><b>Nome: </b> " + nome + "</p>" +
                       "<p><b>Email: </b> " + email + "</p>" +
                       "<p><b>Telefone: </b> " + tel + "</p>" +
                       "<p><b>Data: </b> " + DateTime.Now + "</p>" +
                       "<p><b>Texto: </b> " + msg + "</p>";
            client.Send(nMail);

        }

    

    }
}