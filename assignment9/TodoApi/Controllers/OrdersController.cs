using Microsoft.AspNetCore.Mvc;
using OrderManagement;

namespace YourProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrdersController(OrderService orderService)
        {
            _orderService = orderService;  // 依赖注入订单服务
        }

        // GET: api/orders
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(_orderService.GetOrders());
        }

        // POST: api/orders
        [HttpPost]
        public IActionResult PostOrder([FromBody] Order order)
        {
            _orderService.AddOrder(order);
            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        
    }
}
