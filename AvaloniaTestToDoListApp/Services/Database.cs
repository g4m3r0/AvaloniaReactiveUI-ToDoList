using System.Collections;
using System.Collections.Generic;
using AvaloniaTestToDoListApp.Models;

namespace AvaloniaTestToDoListApp.Services;

public class Database
{
    public IEnumerable<ToDoItem> GetItems() => new[]
    {
        new ToDoItem { Description = "Exercise" },
        new ToDoItem { Description = "Meditate for 5 minutes" },
        new ToDoItem { Description = "Work on university project" }
    };
}