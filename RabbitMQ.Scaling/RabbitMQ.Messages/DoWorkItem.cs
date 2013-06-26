using System;
using MassTransit;

namespace RabbitMQ.Messages
{
    public class DoWorkItem :CorrelatedBy<Guid>
    {
        public DoWorkItem()
        {
            CorrelationId = Guid.NewGuid();
        }

        public Guid CorrelationId { get; private set; }
        public string Text { get; set; }
    }
}
