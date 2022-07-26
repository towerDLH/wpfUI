using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WpfUI.View
{
    /// <summary>
    /// SendMail 的摘要说明
    /// </summary>
    public class SendMail
    {
        public static void SendEMail(string mailServer, string fromUser, string fromPassword, string toMail, string mailSubject, string mailBody, string mailAttachment)
        {
            //System.Net.Mail.SmtpClient client = new SmtpClient(mailServer);
            //client.UseDefaultCredentials = false;
            //client.Credentials = new System.Net.NetworkCredential(fromUser, fromPassword);
            //client.DeliveryMethod = SmtpDeliveryMethod.Network;

            //System.Net.Mail.MailMessage message = new MailMessage(fromUser, toMail, mailSubject, mailBody);
            //message.BodyEncoding = System.Text.Encoding.UTF8;
            //message.IsBodyHtml = true;

            //client.Send(message);

            MailMessage mail = new MailMessage(fromUser, toMail);
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Subject = mailSubject;
            mail.IsBodyHtml = true; //是否允许内容为 HTML 格式
            mail.BodyEncoding = Encoding.UTF8;
            mail.Body = mailBody;
            if (!string.IsNullOrEmpty(mailAttachment))
                mail.Attachments.Add(new Attachment(mailAttachment)); //添加一个附件

            SmtpClient smtp = new SmtpClient(mailServer);
            smtp.Credentials = new NetworkCredential(fromUser, fromPassword); //SMTP 验证
            smtp.Send(mail);

        }
    }
}
