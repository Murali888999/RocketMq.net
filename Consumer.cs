using org.apache.rocketmq.client.consumer;
using org.apache.rocketmq.client.consumer.listener;
using org.apache.rocketmq.common.consumer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class Consumer
    {
        static void Main(string[] args)
        {
            DefaultMQPushConsumer consumer = new DefaultMQPushConsumer("ConsumerGroup");
            consumer.setConsumeFromWhere(ConsumeFromWhere.CONSUME_FROM_FIRST_OFFSET);
            consumer.subscribe("defaulttopic", "*");
            consumer.registerMessageListener(new TestListener());
            consumer.start();
            Console.WriteLine("Consumer Started.");
        }
    }
}
