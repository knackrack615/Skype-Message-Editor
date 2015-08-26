# Skype-Message-Editor

Skype Message Editor is a simple program that sends a custom-crafted POST request to the skype and tricks it into changing another's user message

Instructons on how to use it:

1) Download Fiddler

2) Open it

3) Enable HTTPS Capture (Tools -> Fiddler Options -> HTTPS -> Check Capture HTTPS connects and Decrypt HTTPS traffic)

4) Login with your skype on web.skype.com

5) Send a message to a chat/user

6) Edit your message (You don't have to change it)

7) Go back to fiddler and press CTRL + F and type the message you sent

8) You should see 2 results select the second one

9) Right click on it and select Copy -> Just URL

10) Paste it into the program where it says "Request URL"

11) On the side select Inspectors -> Headers and find RegistrationToken

12) Right click it -> Copy value only

13) Paste it into the program where it says "Registration Token"

14) Go back to the web skype and highlight the message you want to edit by double clicking it

15) Open up inspect element and you should see id="msg_*********************" copy it

16) Paste it into the program where it says "Message ID" (The program will remove the msg_ part)

17) Type the message you want into the program and click Send ;)

18) Thats it! :)


This just shows how unsecure skype is.. MICROSOFT PLEASE FIX!
