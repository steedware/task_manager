using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;   // Dodaj tę linię dla IEnumerable<>
using System.Threading.Tasks;      // Dodaj tę linię dla Task<>
using Microsoft.EntityFrameworkCore;  // Dodaj tę linię dla DbContext
using TaskManagementApp.Data;
using TaskManagementApp.Models;  // Dodaj tę linię dla AppDbContext


[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    private readonly AppDbContext _context;

    public TasksController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<TaskItem>>> GetTasks()
    {
        return await _context.Tasks.ToListAsync();
    }

    [HttpPost]
    public async Task<ActionResult<TaskItem>> CreateTask(TaskItem task)
    {
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetTasks), new { id = task.Id }, task);
    }
}
