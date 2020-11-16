<h1 align="center">Pay Way Bill Desk</h1>

<h1 align="center">:blond_haired_man::moneybag:&emsp;:left_right_arrow:&emsp;:globe_with_meridians:&emsp;:left_right_arrow:&emsp;:bearded_person::moneybag:</h1>
<br/>
<br/>

<h1 align="center"><b>Abstract:brain:</b></h1>

This Application is mainly developed to visualize the process of online payment gateways like 
*	getting the user details from the application, 
*	pass them to cross verify with the database, 
*	generates the OTP (One Time Password) for verification
*	Checks amount balance and transfers it to another account
*	Finally it makes a transaction through online.
<br/>
<br/>

<h1 align="center"><b>Features:bulb:</b></h1>

*	This application focus on the awareness and the usage of electronic payment to the users.  
*	To support the users to make use of electronic mode of payments.
*	To support highest level of security during transaction, like 2FA (2-Factor Authentication) using OTP (Onetime Password)
*	To make is easy to use the application for future transactions.

<br/>
<br/>

<h1 align="center"><b>System Design Diagram:world_map:</b></h1>

![image](https://user-images.githubusercontent.com/64122408/99210612-45b22500-27ec-11eb-8b29-d0d6b0f9254a.png)

<br/>
<br/>

<h1 align="center"><b>Built Using:hammer:</b></h1>
* This Application is implemented using  <b>VB (Visual Basic) Application</b> 
* implemented by using <b>.NET Framework 4.7.2</b> 
* The Storage Database used here is <b>Microsoft SQL Server</b> 
* The Messaging Service is implemented Using <b>Twilio API</b>.

<br/>

<h1 align="center"><b>Screenshots :camera_flash:</b></h1>

# Main Page
![image](https://user-images.githubusercontent.com/64122408/99210695-7a25e100-27ec-11eb-9a6f-ae56be088a57.png)

# OTP Page
![image](https://user-images.githubusercontent.com/64122408/99210746-a04b8100-27ec-11eb-82dc-5aedfd607a63.png)

# OTP(Sent by Twilio API to your mobile)
![image](https://user-images.githubusercontent.com/64122408/99210783-bb1df580-27ec-11eb-84e0-43c79c53970b.png)

# Successful Transaction
![image](https://user-images.githubusercontent.com/64122408/99210817-d25ce300-27ec-11eb-9119-caea75c75256.png)

# Successful Transaction (Sender)
![image](https://user-images.githubusercontent.com/64122408/99210860-ed2f5780-27ec-11eb-98ca-6a620159dac9.png)

# Successful Transaction (Reciever)
![image](https://user-images.githubusercontent.com/64122408/99210893-046e4500-27ed-11eb-904f-f28ed398f98e.png)

# Transaction Database (Design and Sample Data)
![image](https://user-images.githubusercontent.com/64122408/99212153-51074f80-27f0-11eb-8a09-c4913cc4e064.png)

# User Database (Design and Sample Data)
![image](https://user-images.githubusercontent.com/64122408/99212454-1651e700-27f1-11eb-965e-96cb2369242e.png)


<br/>
<br/>

<h1 align="center"><b>NOTE :warning:</b></h1>


# Feel free to fork This Project😇

> Before using this apliacation, Replace this code with your twilio API (in Form1.vb file)

```
    Public Sub msgRec(ByVal balSenAcc As String, ByVal balSender As String, ByVal balSenPh As String, ByVal balRecAcc As String, ByVal amt As String)

        Const accountSid = "YOUR_TWILIO_ACCOUNT_SID"^^
        Const authToken = "<YOUR_TWILIO_API_KEY>"
        TwilioClient.Init(accountSid, authToken)
        Dim toNumber = New PhoneNumber(balSenPh)
        Dim message = MessageResource.Create(
                    toNumber, from:=New PhoneNumber("<YOUR_TWILIO_PHONE_NUMBER>"),
                    body:="Reciever - Your Account Number" + balSenAcc.Substring(0, 3) + "XXX" + balSenAcc.Substring(8, 2) + "Has Been Credited With Rs " + amt + " To " + balRecAcc + " On " + System.DateTime.Now.ToString("MMM/dd/yyyy HH:mm:ss") + vbNewLine + "Your Account Balance Is Rs " + balSender + "")
    End Sub
```



<br/>

# CREDITS  
:white_check_mark:**Karthik Raja**
<p align="left">  
<h3 align="left">Connect with me:</h3>  
<a href="https://twitter.com/mranonymousofcl" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/twitter.svg" alt="mranonymousofcl" height="30" width="40" /></a>  
<a href="https://instagram.com/mr.anonymous_official" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/instagram.svg" alt="mr.anonymous_official" height="30" width="40" /></a>  
<a href="https://discord.com/channels/mr_anonymous_2001#4770" target="blank"><img align="center" src="https://cdn.jsdelivr.net/npm/simple-icons@3.0.1/icons/discord.svg" alt="mranonymousofcl" height="30" width="40" /></a>
</p>  

