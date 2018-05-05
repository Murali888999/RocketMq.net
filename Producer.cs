using org.apache.rocketmq.client.producer;
using org.apache.rocketmq.common.message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producer
{
    class Producer
    {
        static void Main(string[] args)
        {
            DefaultMQProducer p = new DefaultMQProducer("ProducerGroup");
            p.start();
            for (int i = 0; i < 100; i++)
            {
                try
                {
                    var data = Encoding.Default.GetBytes("Hello To All" + i);
                    Message m = new Message("defaulttopic", data);

                    SendResult sendResult = p.send(m);

                    Console.WriteLine(sendResult);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    break;
                }
            }
            p.shutdown();
            Console.ReadKey();
        }
    }
}