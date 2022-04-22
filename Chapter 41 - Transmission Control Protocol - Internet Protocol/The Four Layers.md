pg 347, Craig n dave TCP IP stack and Mac Addresses

# Layers

## Layer 4 - Application Layer

The application layer handles the Domain Name System and a series of other procotols.
EG. Incoming and outgoing data are converted from one presentation format to another; presentation formats are standardised so that diferent types of data (sound, graphics, video, etc.) can be understood by the receiving device; data that have been compressed or encrypted can be interpreted.

Takes a message and uses an appropiate relating to whatever the application is being used to transmit data.
*Eg, HTTPS to access a website.*

## Layer 3 - Transport Layer 

This contains most of the configuration and coordination associated with teh transmission that ensures that all the packets have arrived and that there are no errors in the packets. It also handles the way in which connections are made to create a path for data to travel between nodes. The sender and receiver are identified and authenticated and the communication is set up, coordinated, and terminated. Network resources are identified to ensure that they are sufficient for the communication to take place.

It is responsible for establishing an "end-to-end" connection.
Once the connection is made it splits the data to be transmitted into packets.

It adds to each packet:
1. The number of the packet (its sequence), so that it can be reconstructed correctly at the destination and reorderd; can also check whether the message is complete or not.
2. The total number of packets.
3. The port number the packet should use.

## Layer 2 - Network or internet layer

Defines the IP addresses of devices that send and receive data and handles the creation and routing of packets being sent and received.

Uses the IP part.

It adds to each packet:
1. The source IP address.
2. The destination IP address.

All routers operate at this layer. They use the IP address to know the destination the packets are heading to.

**socket = IP address + port**, eg. 127.56.87.2:80

Together, we now know:
1. What device the packet is going to (IP address).
2. What application on that device needs the packet (port).

## Layer 1 - Link Layer

This layer provides synchronisation of devices so that the receiving device can manage the flow of data being received. It identifies what network topology is being used and controls the physical signals that transmit the strings of bits around the network, that is, the actual transmission of 0s and 1s. It also controls physical characteristics such as data transmission rates and the physical connections in a network. On wireless networks it handles the CSMA/CA protocol.

Represents the actual physical connection between various network nodes. 

it is responsible for adding:
1. The unique MAC address of the source device.
2. The unique MAC address of the destination device.

## General info

The highest level is closer to the user in that the processes are usually handled using either the operating system or application software. The lower layers are handled using a combination of hardware and software includiong the physical referred to as a stack because of the way in which teh request from the client machine passes down up through the layers of the server side. This means that the last action that takes place in the link layer on the client computer becomes the first action in the link layer in the server. This is an example of the last in first out (LiFo) structure that characterises a stack.