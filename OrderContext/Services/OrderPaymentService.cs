using OrderContext.Model;

namespace OrderContext.Services
{
    public class OrderPaymentService
    {
        public bool PayForOrder(Order order)
        {
            //Makes call to external service to receive payment.
            //true on success?
            return true;
        }

        public bool RefundPayment(Order order)
        {
            //Authorizes Refund with external service for order.
            return true;
        }
    }
}
