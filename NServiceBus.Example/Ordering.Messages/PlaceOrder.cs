using System;
using System.Data.Common;
using NServiceBus;

namespace Ordering.Messages
{
    public class PlaceOrder : ICommand
    {
        public Guid Id { get; set; }
        public string Product { get; set; }
    }
}