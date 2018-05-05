using java.lang;
using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    class OrderProducer
    {
        static void Main(string[] args)
        {
            MQProducer producer = new DefaultMQProducer("example_group_name");
            //Launch the instance.
            producer.start();
            string[] tags = new string[] { "TagA", "TagB", "TagC", "TagD", "TagE" };
            for (int i = 0; i < 100; i++)
            {
                int orderId = i % 10;
              
                Message msg = new Message("TopicTestjjj", tags[i % tags.Length], "KEY" + i,
                        Encoding.Default.GetBytes("Hello RocketMQ " + i));
                SendResult sendResult = producer.send(msg, new MessageQueueSelector1()
                , orderId);

	            Console.WriteLine(sendResult);
      }
         producer.shutdown();
        }
    }
}
