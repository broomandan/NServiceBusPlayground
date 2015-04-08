using System;
using NServiceBus;
using Ordering.Messages;

namespace Ordering.Client
{
    public class SendOrder : IWantToRunWhenBusStartsAndStops
    {
        private readonly IBus _bus;

        public SendOrder(IBus bus)
        {
            _bus = bus;
        }

        public void Start()
        {
            Console.WriteLine("Press 'Enter' to send a message.To exit, Ctrl + C");

            while (Console.ReadLine() != null)
            {
                var id = Guid.NewGuid();

                var placeOrder = new PlaceOrder
                {
                    Product = "New shoes",
                    Id = id
                };
                _bus.Send(placeOrder);

                Console.WriteLine("Send a new PlaceOrder message with id: {0}", id.ToString("N"));
            }
        }

        public void Stop()
        {
        }
    }
}