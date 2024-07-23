# Interface Segregation Principle

## Good Design

In the good example, each interface has its own definition specifically for the tasks each position needs to perform : ILead.cs, IManager.cs and IProgrammer.cs.

As a result, the Manager can lead without having to worry about performing common tasks from another domain. 

On the other hand, a leader can indeed perform such tasks and also lead their programmers.