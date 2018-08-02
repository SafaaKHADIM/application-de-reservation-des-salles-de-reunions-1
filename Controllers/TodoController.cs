using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Vue2Spa.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
		 private readonly ITodoItemService _todoItemService;

    public TodoController(ITodoItemService todoItemService)
    {
        _todoItemService = todoItemService;
    }
        // Handles GET /api/todo
        [HttpGet]
        public async Task<IActionResult> GetAllTodos()
        {
            // TODO: Get to-do items and return to frontend
        }
    }
}