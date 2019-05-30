# WorkflowEngine
## C# console application that demonstrates the use of interfaces and how they support polymorphic behavior

This is just a simple console application I built to practice working with interfaces to support polymorphism. I created a WorkFlow class which contains a private field IList\<IActivity\>, which contains objects that implement the IActivity interface. This interface includes an Execute() method, which WorkFlow takes advantage of when iterating through the list. I then created a few classes that implement this interface, added them to the list in the WorkFlow object, and was able to run Execute() for all of the activities in the WorkFlow.

