using org.apache.rocketmq.client.consumer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class ScheduledMessageConsumer
    {
        static void Main(string[] args)
        {
            
            DefaultMQPushConsumer consumer = new DefaultMQPushConsumer("ExampleConsumer");
            
            consumer.subscribe("TestTopic", "*");
            
            consumer.registerMessageListener(new TestListner());
         
         consumer.start();
        }
    }
}
