﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;

namespace WeMoveU.LandingPage.Web.Models
{
    public class EnviaEmail
    {
        #region enviaEmailSenha
        public string enviaEmailSenha(string destinatario)
        {
            string retorno = "";
            try
            {
                

                string emailRemetente = "";
                string emailRemetenteSenha = "";
                //string emailResposta = resposta;
                string emailDestinatario = destinatario;
                //string emailOculto = credencial[0].ToString();

                //crio objeto responsável pela mensagem de email

                MailMessage objEmail = new MailMessage();

                //rementente do email

                objEmail.From = new MailAddress(emailRemetente);

                //email para resposta(quando o destinatário receber e clicar em responder, vai para:)

                //objEmail.ReplyTo = new MailAddress(emailResposta);

                //destinatário(s) do email(s). Obs. pode ser mais de um, pra isso basta repetir a linha

               // objEmail.CC.Add(credencial[0].ToString());
                //abaixo com outro endereço

                objEmail.To.Add(emailDestinatario);

                //se quiser enviar uma cópia oculta pra alguém, utilize a linha abaixo:

                //objEmail.Bcc.Add(emailOculto);

                //prioridade do email

                objEmail.Priority = MailPriority.Normal;

                //utilize true pra ativar html no conteúdo do email, ou false, para somente texto

                objEmail.IsBodyHtml = true;

                //Assunto do email

                objEmail.Subject = "Envio de senha";

                //corpo do email a ser enviado

                objEmail.Body = "<html><body>Bem vindo ao sistema <b>Controle de Estoque</b>. <br><br> " +
                "<br>Para sua primeira utilização, foi gerada a credencial: <br>" +
                "<br>Usuário: </b>" + emailDestinatario + "<br>" +
                "<br>Senha: </b>"  + "<br><br>" +
                "<br>Acesse: </b>" + "http://estoque.g10software.com.br" + "<br><br>" +
                "<br>Boa utilização e bons negócios, G10 Software.</b></body></html>";

                //codificação do assunto do email para que os caracteres acentuados serem reconhecidos.

                objEmail.SubjectEncoding = Encoding.GetEncoding("ISO-8859-1");

                //codificação do corpo do emailpara que os caracteres acentuados serem reconhecidos.

                objEmail.BodyEncoding = Encoding.GetEncoding("ISO-8859-1");

                //cria o objeto responsável pelo envio do email

                SmtpClient objSmtp = new SmtpClient();

                //endereço do servidor SMTP(para mais detalhes leia abaixo do código)

               // string[] variavel = credencial[0].Split('@');

                //string smtpHost = variavel[1].ToString();

                objSmtp.Host = "wemoveu.com.br";
                objSmtp.EnableSsl = false;
                objSmtp.Port = 587;

                //objSmtp.UseDefaultCredentials = true;

                //para envio de email autenticado, coloque login e senha de seu servidor de email

                //para detalhes leia abaixo do código

                objSmtp.Credentials = new NetworkCredential(emailRemetente, emailRemetenteSenha);

                try
                {
                    objSmtp.Send(objEmail);
                    retorno = "OK";

                }
                catch (Exception ex)
                {
                    retorno = ex.Message;
                }
                finally
                {
                    //excluímos o objeto de e-mail da memória
                    objEmail.Dispose();
                    //anexo.Dispose();
                }
            }
            catch (Exception ex)
            {
                retorno = ex.Message;
            }

            return retorno;
        }
        #endregion
    }
}