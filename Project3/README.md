## C# .NET 6.0

### Commons aspects between inheritance and interfaces

* #### Relationship "is a":

:arrow_right: A Circle or a Rectangle inherits from Shape abstract class. A Circle or a Rectangle is a Shape. Both Rectangle and Circle inherit attributes and operations from Shape when an object is created.


:arrow_right: Another example with interface: If there is a TaxService interface with a tax operation, concret classes as BrazilTaxService and UsaTaxService must implement it inside them, unless they are created as abstract class too. In the same way, BrazilTaxService or UsaTaxService is a TaxService.


* #### Generalization/specialization

:arrow_right: A Circle and a Rectangle are specialized classes from a generic class (Shape)

:arrow_right: BrazilTaxService and UsaTaxService are specialized classes from a generic interface (TaxService).


* #### Polymorphism

:arrow_right: A shape type variable created can refers to a inherited Rectangule or Circle concret class which has been instantiated.

:arrow_right: A TaxService type variable can refers to a concret class as BrazilTaxService or UsaTaxService since they implement TaxService interface.

### Important Difference (inheritance and interface)

* Inheritance : Reuse
* Interface : contract to be accomplished


### Inheritance Example 

![uml1](https://user-images.githubusercontent.com/88597534/234418797-cd7a7c9e-561c-468d-b7dd-c1d1666fe47f.png)


### What if is it necessary to implement Shape as interface, but I want to define a common reusable structure for all shapes?

The strategy is: 

![uml2](https://user-images.githubusercontent.com/88597534/234418802-43d56ac4-3b8c-4d0b-8479-689c50ed97ef.png)

:arrow_right: If a Shape interface is created, the color attribute can't be there. But in this case, will I have to put the color attribute in both specialized classes (Rectangle and Circle)? Not necessarily.

:arrow_right: An abstract Shape class can be created to define color attribute. Because it is an abstract class it won't implement area method. Concrete classes that inherit from AbstractShape class will implement the area method in each of them.

:arrow_right: Why is it more interesting to have Shape as Interface? Because in this way, I can have concrete classes that don't have color but are figures.

:arrow_right: All this structure is more flexible than the previous one and it allows to match inheritance and interface.









