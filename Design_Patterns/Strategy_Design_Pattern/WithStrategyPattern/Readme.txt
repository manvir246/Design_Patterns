1. The issue is that we have repetitive code in the OffRoad and SportsVehicle classes.(Child Classes)
If new functionality is added in the future, the code duplication may increase further.

2. It is a Behavioral Design Pattern.
3. It promotes the Open/Closed Principle — you can add new strategies without modifying existing code.

Real life analogy:
Analogy: Think of choosing a travel mode: car, train, flight.

You want to get from City A to City B (the context).

The strategy is how you travel (car/train/flight).

You can swap strategies at runtime without changing your destination logic.