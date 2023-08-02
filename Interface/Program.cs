public interface IShape // interface is abstract 
{
    // It specifies what a class should do but not how it should do it.
    // Interfaces allow you to achieve polymorphism
    // cannot be created an object
    // method overloading is also an example of polymorpholism
    // part of Interface Segregation SOLID principle
    void Draw(); // Method signature without implementation
    double Area { get; } // Read-only property

    // : Shape, Color multiple Inheritance
}
