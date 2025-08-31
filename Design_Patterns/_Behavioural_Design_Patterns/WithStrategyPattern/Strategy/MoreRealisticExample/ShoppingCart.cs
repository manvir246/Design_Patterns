// Context
public class ShoppingCart {
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy strategy) {
        _paymentStrategy = strategy;
    }

    public void Checkout(double amount) {
        _paymentStrategy.Pay(amount);
    }
}