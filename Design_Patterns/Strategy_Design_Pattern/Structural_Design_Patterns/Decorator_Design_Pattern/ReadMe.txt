Problem Statement
When we rely too much on inheritance, we face the problem of Class Explosion.
Every new variation of a feature (toppings, add-ons, behaviors, etc.) forces us to create a new subclass.
As the number of variations grows, the number of classes grows exponentially, making the system rigid and hard to maintain.

🔹 Real-Life Analogies
🍕 Pizza Analogy
You have a Base Pizza.
One customer wants Pizza + Mushrooms → you create a new subclass MushroomPizza.
Another customer wants Pizza + Mushrooms + Cheese Filling → you create another subclass MushroomCheesePizza.
Another wants Pizza + Cheese Filling (without mushrooms) → yet another subclass CheesePizza.
This keeps growing → class explosion.

✅ Solution: Use the Decorator Design Pattern.

Instead of creating new subclasses, you decorate the Base Pizza with toppings at runtime.

Example: pass the BasePizza into a MushroomDecorator, then wrap it again with a CheeseDecorator.

This avoids class explosion while keeping the code flexible.

👉 In short:

Problem: Inheritance → Class Explosion → Hard to maintain.

Solution: Decorator Pattern → Compose behavior dynamically (wrap instead of inherit).

NOTE: "has a" and "is a" both relationship.