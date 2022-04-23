# Code Challenge: Class 14 (Mock Interviews)
# getMax In Stack
## Challenge Summary
 - ‘Max Stack’ which is defined as a Stack with an additional getMax() member function which returns the ‘biggest’ element in the Stack.
-  This ‘getMax()’ member function can be approached in several ways as well:
         - Modifying the traditional push and pop methods to keep track on the maximum value so far.
         - Use a maxStack instance variable, and each time you push a number, you check if it’s >= the peek on maxStack; if so, push it onto both maxStack and            - the actual stack. Then when popping, check if equal to max on maxStack, and if so, also pop maxStack.
         - This solution takes O(1) time to both maintain and retrieve the maximum value.
 
 ## Whiteboard Process
 ![](../../img/GetMax.png)

## Approach & Efficiency 
### Big O Complexity
- Time O(1)
- Space O(n)

# API
### PUSH
each time you push a number, you check if it’s >= the peek on maxStack; if so, push it onto both maxStack and the actual stack.
### PUP
 check if equal to max on maxStack, and if so, also pop maxStack.
