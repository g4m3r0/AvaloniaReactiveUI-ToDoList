using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;

namespace AvaloniaTestToDoListApp.Models;

public class ToDoItem
{
    public string Description { get; set; }
    public bool IsChecked { get; set; }
}