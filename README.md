# Command

Here we can see the implementation and usage of the Command design pattern.

In this implementation, the Command abstract class defines a method Execute that all concrete commands must implement. 

The Receiver class contains the action that will be performed when a command is executed. 

The ConcreteCommand class is a concrete implementation of the Command class, and it holds a reference to a Receiver object. 

The Invoker class is responsible for executing a command.

When the program is run, a Receiver object is created, then a ConcreteCommand object is created and passed the Receiver object as a parameter. 

An Invoker object is then created, and the ConcreteCommand object is set as the command to be executed. 

Finally, the Invoker object is told to execute the command, which in turn calls the Execute method on the ConcreteCommand object, which calls the Action method on the Receiver object.