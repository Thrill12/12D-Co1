One way of getting from A to B in a graph the quickest way

In the array set each point as to not be visited and set their shortest distance from start to infinity except the start node, whose distance will be 0.

Find each connected node to the start.
Calculate distance from A to this second Node. The distance is 2 Plus shortest distance we came from. So 2 + 0 = 2
For each point we also record the previous vertex that we came from.

Next step is we identify another node that we have not visited with the shortest distance from the start.

