# DesignPattern for Singleton
#### This program is demonstrating the Singleton Design Pattern in C#. The purpose of the Singleton pattern is to ensure that a class has only one instance and provides a global point of access to that instance.

## Here’s a breakdown of the program:

### Namespace and Class Declaration:

### The namespace `DemoDesignPattern` defines a scope to organize code.
### The internal class `Program` contains the Main method, which serves as the entry point for the application.
## Singleton Pattern:

### We can infer that the Singleton class should have:
- A private static variable that holds a single instance of the class.
- A private constructor to prevent other classes from instantiating it.
- A public static method (GetInstance()) that returns the single instance of the class.
### Main Method:

- In the Main method, two variables (s1 and s2) are assigned the instance returned by Singleton.GetInstance().
- Because the Singleton pattern only allows a single instance, both s1 and s2 should refer to the same object.
- The if statement checks if s1 and s2 reference the same instance.
- If they don’t, it prints "Not Sharing the same resource", but since this is a Singleton, they should be the same instance, so it prints "Sharing the same resource".
