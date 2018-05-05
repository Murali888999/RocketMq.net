using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    class ScheduledMessageProducer
    {
        static void Main(string[] args)
        {
            DefaultMQProducer producer = new DefaultMQProducer("ExampleProducerGroup");
          
            producer.start();
            int totalMessagesToSend = 100;
            for (int i = 0; i < totalMessagesToSend; i++)
            {
                Message message = new Message("TestTopic", Encoding.Default.GetBytes("Hello scheduled message " + i));
                
                message.setDelayTimeLevel(3);
                
                producer.send(message);
            }

            
            producer.shutdown();
        }
    }
}
