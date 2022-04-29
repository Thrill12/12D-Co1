# Intro to protocols

**Protocol** : *"A set of rules which govern communication"*

As long as two devices have the same **protocol** on they can communicate in some way.

Different **protocols** allow devices to communicate in different ways, and as such many devices have multiple **protocols** installed.

## File Transfer Protocol (FTP)

Very efficient way to transfer data across the network.

High level **protocol** operating at the **Application** layer.

Some commands include:
- PWD - print working directory
- LIST - return file or directory details
- CDUP - change to the parent directory
- PASV - enter passive mode
- MKDIR - make a new directory within the current directory
- PUT - copy one file from the local machine to the remote machine

These can be issued from a command line interface. Often though people use **FTP Clients**. Thee are software applications which sit on top of the actual **FTP Protocol**. You interact with the program and it generates and sends the appropiate **FTP** commands.

## SSH

Secure shell is a protocol typically used for:
1. Providing secure remote access to computers.
2. Providing secure remote access for automated processes.
3. Issuing remote commands.
4. Mnaging a network away from work / home

It uses public key encryption to authenticate the user and prevent unauthorised access.

Steps:
1. Client initiates the connection by contacting server.
2. Server sends public key to client.
3. Server and client agree communication rules and open a secure channel.
4. User can now login to the remote server host operating system.

An **SSH client** can also be used in conjunction with other application level protocols like HTTP, POP3, etc.

the **SSH client** can make a TCP connection on a remote port and send commands to that port using the appropriate protocol.

In this way **SSH** can be used to "tunnel" through a company firewall on port 22, then you can send other requests such as a HTTP "GET" request through the securely encrypted **SSH tunnel** even if your normal firewall restrictions block sure traffic! This gives great levels of control to offsite systems administrators.

## Email Servers

**Mail servers** act like a virtual online post office for all incoming and outgoing email.

Uses 3 main protocols:
- **Post Office Protocol V3** (POP3): Retrieves emails from a mail server. Remove it from server and transfers to your device.
- **Internet Mesage Access Protocol** (IMAP): Keeps emails on the mail server, allowing synchronicity between devices.
- **Simple Mail Transfer Protocol** (SMTP): Transfers outgoing emails from one server to another / from an email client to a server.

## Web servers and web browsers

**Web servers** carry out many functions, but by far their most common is:
- Hosting websites
- Dealing with client requests, eg. HTTP get requests for a page / resource

The webpage, stored as text(HTML, CSS, Javascript) is sent to a browser which uses rules to render it correctly for the user.

1. URL request by browser from user, eg. www.craigndave.org/index.html.
2. Browser extracts the Fully Qualified Domain Name (FQDN) and sends it to a DNS server.
3. DNS server maps the FQDN to an IP address and returns it to the browser.
4. GET request for the web resource specified URL. The request is sent to web server.
5. The file returns to the client.
6. Browser renders contents according to HTML rules.
7. If the file being rendered contains other URLs / graphics etc then the browser issues additional GET requests.