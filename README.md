# learningC#
Anything Related to C# coding

#Solid

 Now I mentioned in the previous video that part of refactoring involves removing duplicate code and cleaning up code for legibility. But that's really at a surface level. At a deeper level, hard core refactoring comes from following the SOLID principles. That's an acronym, and one you should know inside and out, because it often comes up in technical interviews. SOLID stands for single responsibility principle, the open/closed principle, Liskov substitution principle, the interface segregation principle, dependency inversion principle.

One side note I want to mention is that we're not going to dive deep into these. I'll give a reference to read up on if you want to get more information on this, but I will explain them and give some examples later on in the course through some of the programs that we write. Just know that not all of these will be applicable for every program that you write. But it is good to just be familiar with them. The first one, the single responsibility principle. Think of it like this. You might have a class that's responsible for calculating a mortgage.

Well if that's the case, that's all it should do. It should not handle writing output files or writing any reports, which is unrelated to its core purpose of calculating. Another class should do that. This also applies at the method level. Each method should have one role, one reason to change. The next principle, open/closed principle. Think of it like this. Our mortgage class should be extendable by, let's say, being inherited by another class which adds the functionality of getting the latest interest rates.

But changes to the base class isn't permitted. In other words, it's open for extension but it's closed for modification. The Liskov Substitution Principle. It states that the derived classes must be substitutable for their base class. Another way to think about it is, objects in a program should be replacable with instances of their subtypes, without altering the correctness of that program. The interface segregation principle. This basically means that you are better off having several interfaces with unique roles, rather than one big interface with a bunch of different roles.

Again, with our mortgage example, don't have an interface that implements both calculating and reporting. They should be in two separate interfaces, because they're unrelated. So, in other words, it's similar to the single responsibility principle, except that we're dealing with interfaces. Dependency inversion. It states that we should depend on abstractions and not concretions. So what do we mean by abstractions and concretions? Well, interfaces are abstractions.

That is, they don't have implementations like methods with logic in them. Only method signatures. Now, standard classes that we create, those are concretions. That is, they do have methods with logic. So, it's possible that I could have a class called Customer, and it'll have a message in it called GetName that returns the value of the customer name. That's a concretion. It has logic in it. Conversely, though, if I had an interface called ICustomer, that can only have a message signature for GetName.

That is an abstraction. So all they're saying is, if I needed to inherit from one of these, rather than inheriting a class that has implementation, it's better to implement an interface so that you have a flexibility to create your own implementation. This is really about preventing your code from being coupled. These principles were made by Robert Martin, also known as Uncle Bob. So, for more information about all these object-oriented design principles, definitely check out his article.

It's a really good read.
