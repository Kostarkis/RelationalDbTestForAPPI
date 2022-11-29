using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RelationalDbTestForAPPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }

        // GET: api/TodoItems
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            return await _context.TodoItems.ToListAsync();
        }
        
        [HttpGet("GetManyPopulatedData")]
        public async Task<ActionResult<ActionResult<string>>> GetManyPopulatedData()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result1 = _context.Name1Items.ToList();
            var result2 = _context.Name2Items.ToList();
            var result3 = _context.Name3Items.ToList();
            var result4 = _context.Name4Items.ToList();
            var result5 = _context.Name5Items.ToList();
            var result6 = _context.Name6Items.ToList();
            var result7 = _context.Name7Items.ToList();
            var result8 = _context.Name8Items.ToList();
            var result9 = _context.Name9Items.ToList();
            var result10 = _context.Name10Items.ToList();
            var result11 = _context.Name11Items.ToList();
            var result12 = _context.Name12Items.ToList();
            var result13 = _context.Name13Items.ToList();
            var result14 = _context.Name14Items.ToList();
            var result15 = _context.Name15Items.ToList();
            var result16 = _context.Name16Items.ToList();
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            return Ok("time: " + elapsedMs);
        }

        [HttpGet("GetSinglePopulatedData")]
        public async Task<ActionResult<ActionResult<string>>> GetSSinglePopulatedData()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = _context.NamesCombined.ToList();
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            return Ok("time: " + elapsedMs);
        }

        [HttpGet("PopulateManyData")]
        public async Task<ActionResult<ActionResult<string>>> PopulateManyData()
        {
            int populationNum = 100000;
            for (int i = 0; i < populationNum; i++)
                _context.Name1Items.Add(new Name1 { Param1 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name2Items.Add(new Name2 { Param2 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name3Items.Add(new Name3 { Param3 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name4Items.Add(new Name4 { Param4 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name5Items.Add(new Name5 { Param5 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name6Items.Add(new Name6 { Param6 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name7Items.Add(new Name7 { Param7 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name8Items.Add(new Name8 { Param8 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name9Items.Add(new Name9 { Param9 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name10Items.Add(new Name10 { Param10 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name11Items.Add(new Name11 { Param11 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name12Items.Add(new Name12 { Param12 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name13Items.Add(new Name13 { Param13 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name14Items.Add(new Name14 { Param14 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name15Items.Add(new Name15 { Param15 = "" + i });
            for (int i = 0; i < populationNum; i++)
                _context.Name16Items.Add(new Name16 { Param16 = "" + i });
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await _context.SaveChangesAsync();
            // the code that you want to measure comes here
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            return Ok("time: "+elapsedMs);
        }

        [HttpGet("PopulateSingleData")]
        public async Task<ActionResult<ActionResult<string>>> PopulateSingleData()
        {
            int populationNum = 100000;
            for (int i = 0; i < populationNum; i++)
                _context.NamesCombined.Add(new NameCombined { 
                    Param1 = "" + i,
                    Param2 = "" + i,
                    Param3 = "" + i,
                    Param4 = "" + i,
                    Param5 = "" + i,
                    Param6 = "" + i,
                    Param7 = "" + i,
                    Param8 = "" + i,
                    Param9 = "" + i,
                    Param10 = "" + i,
                    Param11 = "" + i,
                    Param12 = "" + i,
                    Param13 = "" + i,
                    Param14 = "" + i,
                    Param15 = "" + i,
                    Param16 = "" + i
                });
            
            var watch = System.Diagnostics.Stopwatch.StartNew();
            await _context.SaveChangesAsync();
            // the code that you want to measure comes here
            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            return Ok("time: " + elapsedMs);
        }

        // GET: api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // PUT: api/TodoItems/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(int id, TodoItem todoItem)
        {
            if (id != todoItem.Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TodoItems
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TodoItem>> PostTodoItem(TodoItem todoItem)
        {
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            //    return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Id }, todoItem);
        }

        // DELETE: api/TodoItems/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _context.TodoItems.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.TodoItems.Remove(todoItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TodoItemExists(int id)
        {
            return _context.TodoItems.Any(e => e.Id == id);
        }
    }
}
