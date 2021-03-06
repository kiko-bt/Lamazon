using Microsoft.AspNetCore.Mvc;
using SEDC.Lamazon.Services.Interfaces;
using System.Diagnostics;

namespace SEDC.Lamazon.Performance.CheckAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public ExternalController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("performance/getorder")]
        public ActionResult<long> GetUserOrderPerformance()
        {
            //Checking application performance
            string userId = "c9f70697-d31e-477b-84d1-3b51d089d9a2";

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < 10000; i++)
            {
                _orderService.GetCurrentOrder(userId);
            }

            stopwatch.Stop();
            long time = stopwatch.ElapsedMilliseconds;
            return time;
        }
    }
}
