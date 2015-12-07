# Skype-Message-Editor

Skype Message Editor is a simple program that sends a custom-crafted POST request to the skype and tricks it into changing another's user message

Please keep in mind that this should ***ONLY*** be used to test the vulnerability and you should not modify any messages without the explicit permission of the other person

Instructons on how to use it:

1) Download Fiddler (http://www.telerik.com/download/fiddler)

2) Open it

3) Enable HTTPS Capture (Tools -> Fiddler Options -> HTTPS -> Check Capture HTTPS connects and Decrypt HTTPS traffic) (If you see any warnings click YES on everything)

4) Login with your skype on web.skype.com

5) Send a message to a chat/user

6) Go back to fiddler and press CTRL + F and type the message you sent

7) You should see 2 results select the second one

8) Right click on it and select Copy -> Just URL

9) Paste it into the program where it says "Request URL"

10) On the side select Inspectors -> Headers and find RegistrationToken

11) Right click it -> Copy value only

12) Paste it into the program where it says "Registration Token"

13) Go back to the web skype and highlight the message you want to edit by double clicking it

14) Open up inspect element and you should see id="msg_*********************" copy it

15) Paste it into the program where it says "Message ID" (The program will remove the msg_ part)

16) Type the message you want into the program and click Send ;)

17) Thats it! :)

This just shows how unsecure skype is.. MICROSOFT PLEASE FIX!
