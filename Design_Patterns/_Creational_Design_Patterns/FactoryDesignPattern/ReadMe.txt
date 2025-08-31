Definition:
Factory Pattern is a creational design pattern that provides an interface for creating objects without exposing the object creation logic to the client.
Instead of using new directly, you delegate object creation to a factory class/method.

Where / When to Use:
When object creation depends on some condition or input.
When you don’t want client code full of if-else or switch statements to decide which object to create.
When you want loose coupling — client code depends on an abstract type/interface, not a concrete class.

Without factory:
if(type == "Car") obj = new Car();
else if(type == "Bike") obj = new Bike();

With factory:
IVehicle vehicle = VehicleFactory.Create("Car");



// Abstract Factory:
// It is a "factory of factories."
// Instead of creating just one product, it provides an interface
// to create families of related objects without specifying their exact classes.
//
// Example:
// Suppose we have two factories:
//   1. LuxuryCarFactory  → creates LuxurySedan, LuxurySUV, LuxurySportsCar
//   2. NormalCarFactory  → creates NormalSedan, NormalSUV, NormalHatchback
//
// Now, the Abstract Factory acts as a super-factory
// that lets us pick which family of cars we want (Luxury or Normal).
// Each of these factories then creates multiple related car objects.
// This ensures consistency and avoids mixing objects from different families.