using java.util;
using org.apache.rocketmq.client.consumer.listener;
using org.apache.rocketmq.common.message;
using System.Collections.Generic;
using System.Text;
using System;

namespace Consumer
{
    internal class TestListener : MessageListenerConcurrently
    {
       

        public ConsumeConcurrentlyStatus consumeMessage(List list, ConsumeConcurrentlyContext ccc)
        {
            for(int i = 0 ; i < list.size(); i++ ) 
              {
                var msg = list.get(i) as Message;
                byte[] body = msg.getBody();
                var str = Encoding.Default.GetString(body);
                Console.WriteLine(str);

            }
            return ConsumeConcurrentlyStatus.CONSUME_SUCCESS;
        }
    }
}