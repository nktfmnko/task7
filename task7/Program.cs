using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace task7
{
    public class Program
    {
        public static double MultiplyBy2(double x)
        {
            return x * 2;
        }
        static void Main(string[] args)
        {

            
            string token = "y0_AgAAAABpte-yAATuwQAAAAD0l16X-a2qI29xSGCi8ROP9yidJ0Wk1v0";

            
            using (var client = new HttpClient())
            {
            
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("OAuth", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            
                var taskData = new
                {
                    queue_id = "bpfgia3hvhv162pv07k3",
                    summary = "Build failed",
                    description = "Build failed in TeamCity",
                    assignee = "nktfmnko@gmail.com"
                };

            
                var response = client.PostAsync("https://api.tracker.yandex.net/v2/issues/", new StringContent(JsonConvert.SerializeObject(taskData), Encoding.UTF8, "application/json")).Result;

            
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Task created successfully!");
                }
                else
                {
                    Console.WriteLine("Error creating task: " + response.StatusCode);
                }
                Console.WriteLine(MultiplyBy2(4));

                ломаем билд
            }
        }
    }
}

