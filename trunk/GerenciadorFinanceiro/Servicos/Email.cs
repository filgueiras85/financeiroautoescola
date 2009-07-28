using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
// ===========================================================
// Auctor : <Alcenir Moretto>
// Data Criação: 27/10/2008
// objetivo, enviar email para clientes solicitando a confirmação
// do recebimento e leitura.
// ===========================================================

namespace GerenciadorFinanceiro.Servicos
{
    class Email
    {
       
        public void enviaMensagemEmail(string emailRemetente, string remetente, string destinatario, 
                                              string assunto, string mensagem, string servidorSMTP, string autenticacao, 
                                              List<System.Net.Mail.Attachment> anexos)
        {
            try {
                
                MailMessage mMailMessage = new MailMessage();
                mMailMessage.From = new MailAddress(emailRemetente, remetente);
                // Define o destinario da mensagem
                mMailMessage.To.Add(new MailAddress(destinatario));
                // verifica se o valor para cc é nulo ou uma string vazia
                // Define o assunto 
                mMailMessage.Subject = assunto;
                // Define o corpo da mensagem
                mMailMessage.Body = mensagem.Trim();
                // Define a prioridade da mensagem como normal
                mMailMessage.Priority = MailPriority.Normal;                
                //Definir formato html para o email
                mMailMessage.IsBodyHtml = true;                                
                if ((anexos != null)) {
                    for (int i = 0; i < anexos.Count; i++) {
                        mMailMessage.Attachments.Add(anexos[i]);
                    }
                }
                // Cria uma instância de SmtpClient - Nota - Define qual o host a ser usado para envio 
                // o nome do servidor
                SmtpClient mSmtpClient = new SmtpClient(servidorSMTP);
                // Envia solicitação de confirmação de recebimento do email.
                mMailMessage.Headers.Add("Disposition-Notification-To", "<" + emailRemetente + ">");
                // Autenticação no servidor
                mSmtpClient.UseDefaultCredentials = false;
                mSmtpClient.Credentials = new System.Net.NetworkCredential(emailRemetente, autenticacao);
                // Envia o email
                mSmtpClient.Send(mMailMessage);
            }
            catch (Exception ex) {
               throw new Exception("Não foi possível enviar o email.",ex);
            }
         }
    }
}
