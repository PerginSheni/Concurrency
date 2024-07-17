using Microsoft.AspNetCore.Mvc;

namespace Multithread.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MultithreadController : ControllerBase
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.WriteLine(" Method 1");
                    // Do something
                    Task.Delay(100).Wait();
                }
            });
        }

        
        
    }
}
