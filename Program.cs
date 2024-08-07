using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //1.
            //string rezolt = await GetTaskAsync();
            //Console.WriteLine(rezolt);
            //Console.ReadLine();

            //2.
            //string filePathToString = "D:\\kodcode\\attackServer\\TextFile1.txt";
            //string content = await ReadFileAsync(filePathToString);
            //Console.WriteLine(content);

            //3.
            //Task<string> TaskA = GetDataFromServiceAAsync();
            //Task<string> TaskB = GetDataFromServiceBAsync();

            //await Task.WhenAll(TaskA, TaskB);

            //Console.WriteLine(TaskA.Result);
            //Console.WriteLine(TaskB.Result);

            //4.
            //Node<int> node2 = new Node<int>(5);
            //Node<int> node1 = new Node<int>(3, node2);
            //Console.WriteLine(node2.ToString());
            //Console.WriteLine(node1.ToString());

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Dequeue();
            Console.WriteLine(queue.Dequeue());




        }

        public static async Task<string> GetTaskAsync()
        {
            await Task.Delay(3000);
            return "Recivde Data";


        }

        public static async Task<string> ReadFileAsync(string filPath)
        {
            string result = await Task.Run(()=> File.ReadAllText(filPath));
            return result;
        }



        public static async Task<string> GetDataFromServiceAAsync()
        {
            await Task.Delay(1000);
            return "Data from service A";
        }

        public static async Task<string> GetDataFromServiceBAsync()
        {
            await Task.Delay(2000);
            return "Data from service B";
        }

        
        
    }
}
