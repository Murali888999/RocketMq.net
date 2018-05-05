using java.util.concurrent.atomic;
using org.apache.rocketmq.client.consumer;
using org.apache.rocketmq.common.consumer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer
{
    class OrderConsumer
    {
        static void Main(string[] args)
        {
            DefaultMQPushConsumer consumer = new DefaultMQPushConsumer("example_group_name");

            consumer.setConsumeFromWhere(ConsumeFromWhere.CONSUME_FROM_FIRST_OFFSET);

            consumer.subscribe("TopicTest", "TagA || TagC || TagD");

            consumer.registerMessageListener(new TestListener1());

        consumer.start();

        Console.WriteLine("Consumer Started");
}
    }
}
