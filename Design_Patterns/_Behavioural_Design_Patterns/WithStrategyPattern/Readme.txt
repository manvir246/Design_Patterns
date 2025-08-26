Problem Statement:
The issue is that we have repetitive code in the OffRoadVehicle and SportsVehicle classes (child classes).
If new functionality is added in the future, this code duplication will increase further.

Key Points:
1. It is a Behavioral Design Pattern.
2. It follows the Open/Closed Principle — you can add new strategies without modifying existing code.

Real-Life Analogy:
Analogy: Think of choosing a mode of travel — car, train, or flight.

You want to get from City A to City B (the context).

The strategy is how you travel (car/train/flight).

You can swap strategies at runtime without changing your destination logic.