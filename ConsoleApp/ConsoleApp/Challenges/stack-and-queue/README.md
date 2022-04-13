# Stack And Queue
<!-- Short summary or background information -->
### Stack
- is a data structure that consists of Nodes
- Each Node references the next Node in the stack, but does not reference its previous.
- Stacks follow these concepts ==> (FILO && LIFO)
### Queue 
- is an abstract data structure, somewhat similar to Stacks. 
- Unlike stacks, a queue is open at both its ends.
- Queue follow these concepts ==> (FIFO)

# Challenge
<!-- Description of the challenge -->
### Features
- Using a Linked List as the underlying data storage mechanism, implement both a Stack and a Queue
- Create a Node class that has properties for the value stored in the Node, and a pointer to the next node.
- Create a Stack class that has a top property. It creates an empty Stack when instantiated.
     - push Method.
     - pop method.
     - peek method.
     - IsEmpty method.
 - Create a Queue class that has a front property. It creates an empty Queue when instantiated.
     - enqueue method.
     - dequeue method.
     - peek method.
     - is empty method.

## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
## BigO
### Stack.Push and Queue.Enqueue 

 Time O(1) / Space O(1)

### Stack.Pop and Queue.Dequeue 

 Time O(1) / Space O(1)

### Stack.Peek and Queue.Peek 

Time O(1) / Space O(1)

# API
## Stack Class:
- push: adds a new node with that value to the top of the stack.

- pop: Removes the node from the top of the stack

- peek: return value of the node located at the top of the stack

- is empty: returns boolean indicating whether or not the stack is empty.

## Queue Class :
- enqueue: adds a new node with that value to the back of the queue.

- dequeue: Removes the node from the front of the queue

- peek: returns value of the node located at the front of the queue

- is empty: returns boolean indicating whether or not the queue is empty

