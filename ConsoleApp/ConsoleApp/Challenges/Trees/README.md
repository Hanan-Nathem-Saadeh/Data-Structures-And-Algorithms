# Code Challenge: Class 15: Binary Tree and BST Implementation
# Trees
A tree is a non-linear and hierarchical data structure that is a collection of multiple nodes connected by edges. A tree is an abstract data type (ADT) that follows the hierarchical pattern of data collection. Using a tree, programmers and data science professionals can structure their data such that each node can reference any number of child nodes, but a child can have reference to only one node. The only exception is the root (first) node, which cannot reference a child node. Trees data structure plays an essential role because of the non-linear arrangement. This ensures a faster response time during a search query.

### A Binary Search Tree (BST)

is a tree in which all the nodes follow the below-mentioned properties 

   - The value of the key of the left sub-tree is less than the value of its parent (root) node's key.

   - The value of the key of the right sub-tree is greater than or equal to the value of its parent (root) node's key.

   # Challenge Summary
   - Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
   - Create a Binary Tree class
Define a method for each of the depth first traversals:

         - pre order

         - in order

         - post order

 which returns an array of the values, ordered appropriately.

 - Create a Binary Search Tree class

This class should be a sub-class (or your languages equivalent) of the Binary Tree Class, with the following additional methods:

    - Add : 
       - Arguments: value
       - Return: nothing
       - Adds a new node with that value in the correct location in the binary search tree.
    - Contains
         - Argument: value
         - Returns: boolean indicating whether or not the value is in the tree at least once.


# Approach & Efficiency

- BinaryTree Traversal :

      - Time Complexity : O(n)

      - Space Cmplexity : O(n)

- BinarySearchTree Add  O(Log n)

- BinarySearchTree Contains O(Log n)

#  API
- Binary Tree Class
   - Pre Order : In pre-order traversal we traverse to parent node, then left child and then right child.

   - In Order : In in-order traversal we traverse to left child, then parent and then right child.

   - Post Order : In post-order traversal we traverse to left child, then right child and then to parent node.

   Binary Search Tree Class

   - Add Method : Adds a new node with that value in the correct location in the binary search tree.

   - Contains : Returns: boolean indicating whether or not the value is in the tree at least once.


