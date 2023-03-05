## Communication Basics

Basically every component needs to communicate with every other component. In this topic, we're concerned with the communication between computers on networks, both local and wide. It will also include description of the infrastructure of the internet.

### Serial and parallel transmission

In **serial** transmission, computers send and receive data one bit at a time in sequence. They are used to connect most of the peripherals to the computer such as the mouse and keyboard, and serial cables connect computers together to form a network.

In **parallel** transmission, it uses a number of wirses to send a number of bits simultaneously. The more wires there are, the more data can be sent at any one time. 

- Parallel cables use more wires and are therefore more expensive.
- Signal will also degrade as distance or speed increases due to interference between wires.
- Timing the signals is also a problem as they need to arrive to the end at the correct time and in sequence with the other data (*synchronisation*)

### Bandwidth

**Bandwidth** is the term used to describe the amount of data that can be transmitted along a channel. -> range of frequencies, so measured in Hz.

### Bit rate

**Bit rate** is the term used to describe the speed of a particular transmission. It is linked to the bandwidth, and measured in Bits per second.

### Baud rate

One baud represents one electronic state change per second. Traditionally, one bit is sent on each state change so one baud roughly equals one bit per second. However, it is possible to send more than one bit per state change by using different voltage levels to represent the bits. In this case rather than sending bits, you are sending symbols, which may have any number of bits in them. The baud rate is determined by the transmission medium.

- If 400 bits of data were transmitted at a bit-rate of 400bps then it would take 1 second.
- If 4 bits were encoded into each symbol, the data would be transferred in a quarter of a time, so the baud rate would be 100 baud, however this depends on teh transmission medium.

### Latency

Latency is the time delay that occurs when a computer system is responding to an instruction. This is because the signal has to travel through calbes, through buses, logic gates, all of which takes time.

@TotaledToast tf u can at people in vscode lmao

Three general causes of latency:
- Propagation latency, which is the amount of time it takes for a logic gate within a circuit to transmit the data.
- Transmission latency: the amount of time it takes to pass through a particular communication medium, for example, fibre optic would have a lower latency than copper cable.