using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.ComponentModel;

namespace GerenciadorFinanceiro.Servicos
{
    class Email
    {

       /* MailMessage Email = new MailMessage();  

        SmtpClient cliente = new SmtpClient("smtp.hotmail.com", 587);
        
        MailAddress remetente = new MailAddress("sua.conta@gmail.com", "Seu Nome");
        MailAddress destinatario = new MailAddress("fulano@mailinator.com", "Fulano");
        MailMessage mensagem = new MailMessage("remetente","destinatãrio");
        
        mensagem.Body = "Envio de emaill";
        mensagem.Subject = "Teste";

        NetworkCredential credenciais = new NetworkCredential("sua.conta@gmail.com","sua.senha.secreta","");

        cliente.Credentials = credenciais;

        try {
        cliente.Send(mensagem);
         MessageBox.Show("Email enviado com sucesso!.", "Aviso");
        }
        catch (Exception e) {
         MessageBox.Show("Erro ao enviar email!", "Erro");
        }

  
        //Atribui ao método From o valor do Remetente  
        Email.From = "seuemail@seudominio";  
          
        //Atribui ao método To o valor do Destinatário  
        Email.To = "destinatario@dominio";  
          
        //Atribui ao método Cc o valor do com Cópia  
        Email.Cc = "email@dominio";  
          
        //Atribui ao método Bcc o valor do com Cópia oculta  
        Email.Bcc = "outroemail@dominio";  
          
        //Atribui ao método Subject o assunto da mensagem  
        Email.Subject = "Assunto da Mensagem";  
          
        //Define o formato da mensagem que pode ser Texto ou Html  
        Email.BodyFormat = MailFormat.Html;  
          
        //Atribui ao método Body a texto da mensagem  
        Email.Body = "Conteudo do Email";  
          
        //Inclui o arquivo especificado em anexo  
        ;;Email.Attachments.Add(new MailAttachment("g:\\virtual\\dominio\\www\\arquivo.jpg"));  
          
        //Define qual servidor smpt deve ser usado para envio de mensagens  
        SmtpMail.SmtpServer = "smtp.insite.com.br";  
          
        //Envia a mensagem baseado nos dados do objeto Email  
        SmtpMail.Send(Email);  */

    }
}
