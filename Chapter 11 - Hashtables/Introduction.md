Advantages and limitations of arrays or linked lists

# Arrays:
- a single data type continuously in memory
- every element is associated with its own index
- quick and easy random access to all the elements in the array with a single command
- a limitation is that it is fixed in size because it stores items continuously in memory

# Linked Lists:
- can store data non continuously in memory, so they are dynamic and can grow.
- each element contains the data we want, and a pointer to the location of the next item in the list
- we can't access its elements randomly - if we want to find an item, we have to start at the beginning

# Hashtables:
- most commonly used when speed of lookup is a priority
- in effect, it is simply an array which is coupled together with a hash function

The hash function takes in a key then chucks out a hash value which maps our initial key to a fixed index in the hash table
You use the hash function to find out where to store the data given the key, and later we can use the same method to find the location of the item

The Hash function is a mathematical function which only has one different answer for each key given in.

The numbers of keys are passed one at a time into our hash function.

Eg. when Dave is thrown in, it generates value of 1 and is then placed at the position 1. When we ask the hashtable to retrieve it, we give it the key Dave and it will return the position of where to find Dave in the hashtable

Collisions can happen if the hash function returns the same index for multiple keys. A good hash function will reduce the amount of collisions.
When a collision happens, we use the next available space in the hash table - this is called clustering.

Using linked lists, we have an overflow which points to another node in the hashtable like a linked list, and allows us to have a "chain" of nodes with the correct order.