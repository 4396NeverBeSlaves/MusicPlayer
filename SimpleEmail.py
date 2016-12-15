from email.mime.text import MIMEText
import smtplib
msg = MIMEText('hello, send by Python...', 'plain', 'utf-8')
from_addr = "123@qq.com"
password = "****" #如果是qq邮箱需要去邮箱设置授权码
smtp_server = "smtp.qq.com"
to_addr = "123@qq.com"
smpt_port="465"

server = smtplib.SMTP_SSL(smtp_server,smpt_port) # SMTP协议默认端口是25
server.set_debuglevel(1)
server.login(from_addr, password)
server.sendmail(from_addr, [to_addr], msg.as_string())
server.quit()
