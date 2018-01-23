using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PCITC.OA.Common
{
    public class LogHelper
    {
        static Queue<string> queue = new Queue<string>();
        static List<IBaseLog> list = new List<IBaseLog>();
        static LogHelper()
        {
            list.Add(new FileLog());

            ThreadPool.QueueUserWorkItem(o =>
            {
                if (queue.Count > 0)
                {
                    lock (queue)
                    {
                        string str = queue.Dequeue();
                        foreach (IBaseLog item in list)
                        {
                            item.WriteLog(str);
                        }
                    }
                }
                else
                {
                    Thread.Sleep(30);
                }

            });
        }
        public static void WriteLog(string exception)
        {
            lock (queue)
            {
                queue.Enqueue(exception);
            }
        }
    }
}
