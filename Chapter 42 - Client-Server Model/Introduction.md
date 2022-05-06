## Client-Server model

The client-server model is a methodology for connecting computers together, usually over a network where one computer provides access to resources for other computers that are connected to it. Typically this might involve having a main server with large amounts of processing power and storage capaicty with any number of other computers attached to it that then use the resources of the server.

Examples of different servers include:
- File server containing files
- Web serve used to serve web pages for an Intranet
- Proxy server where each client is provided with a gateway to the internet through the server
- Print server gets sent print requests where they are prioritised, buffered and then printed
- Database server will store the contents of databases and access to the data will come from the indivual clients
- Application server executes all of the procedures needed to run applications

The client-server model works on the basic principle of sender and receiver - to initiate any communication and sharing of resources, the client must make a request to the server. In turn the server responds to that request and then provides the service that is being requested.

The model is also used on the internet - **eg.**, email is built on this model with each user being the client, sending requests to their email provider who responds to each request as it is received. FTP services also use the model with the client making a request to upload a file, which is then handled by the FTP server.

## Application Program interface (API)

In order to communicate with each other effectively, protocols are needed to define the rules by which the communication will take place. All of these requests and the corresponding transfer of services from server to cliuent take place in the application layer of the TCP/IP stack.
In addition to hte protocols, an **application program interface** is used. An API defines the way in which programs can work together. They are usually made up of standardised subroutines that can be customised to provide an interface between one program and anoter. When using web services, an API can also define the protocols that will be used.

**Application program interface (API)** - a set of subroutines that enable one program to interface with another program

## Websocket protocol

One of these is the **websocket protocol**, whichcreates a connection between a client and a server., The client first sends a handshakiong request to the server in order to establish the connection. In response, teh server creates a full duplex connection on a single socket. This allows simultaneous exchange of data in both directions enabling the client and server to communicate on an ongoing basis without hte need to constantly refresh a full web page. Effectively, the websocket has created a dedicated link between the two computers. This is routed through port 80, the dedicated HTTP port, meaning that it will work in situations where non-web Internet connections have been blocked using a firewall.

**Websocket protocol** - a set of rules that creates a persistent connection bvetween two computers on a network to enable real-time collaboration

Data is sent in packets called messages, with minimal header information, allowing for very fast transfer of data in both directions. As these are all going down a persistent connection it allows for real-time collaboartion between client and server. This is of a particular value for certain web applications, where data is constantly changing and time is critical.

For example, an online travel agent needs to respond instantly to ensure that one holiday is not sold to two different people at the same time; a share dealer requires an instantaneous share price in order to make a trade.

Provides a modern, persistent bi-directional, fast, realtime and interaction communication steam!

Overheads are so smal lcompared to traditional techniques that often less hardware are needed - this saves further transmission time, bandwidth, space and cost.

Great for online gaming, instant messaging, remote cloud based document collaboration and any other real time systems.