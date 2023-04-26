## C# .NET 6.0

### Multiple inheritance and diamond problem

Some programming languages (C# included) don't allow multiple iheritance.

In the next figure, a unique comboDevice class inherits from both classes (Scanner and Printer class), which is known as multiple iheritance. This way, an error will be shown at compile time.

![uml3](https://user-images.githubusercontent.com/88597534/234433902-e8b30477-ea64-43c9-8a35-7abb8245bc70.png)

Notice that applying multiple inheritance in above figure, there is a common method called processDoc. But which method should ComboDevice class inherit from? There is an ambiguity or a conflict which can't be handled in this way. That's the diamond problem.

To solve this problem, we have to dissociate methods semantically which are specific to each class (Printer and Scanner classes) by creating interfaces. 

Arranging all, we have:

* A Printer class will inherit from Device class and implement an interface IPrinter; 
* In the same way, a Scanner class will inherit from Device and implement an interface IScanner.
* Following the same idea, ComboDevice will inherit from Device and implement IPrinter and IScanner at the same time. A class can implement more than one interface. 

![uml4](https://user-images.githubusercontent.com/88597534/234441579-68ac33ea-6db2-498c-b0dd-ba1d72a32e00.png)




