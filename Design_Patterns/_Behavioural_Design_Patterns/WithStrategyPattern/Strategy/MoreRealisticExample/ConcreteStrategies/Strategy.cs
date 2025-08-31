// Concrete Strategies
public class CreditCardPayment : IPaymentStrategy {
    public void Pay(double amount) {
        Console.WriteLine($"Paid {amount} using Credit Card.");
    }
}

public class PayPalPayment : IPaymentStrategy {
    public void Pay(double amount) {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}

public class CryptoPayment : IPaymentStrategy {
    public void Pay(double amount) {
        Console.WriteLine($"Paid {amount} using Cryptocurrency.");
    }
}