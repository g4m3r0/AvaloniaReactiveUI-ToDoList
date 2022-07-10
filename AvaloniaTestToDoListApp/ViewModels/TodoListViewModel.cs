using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AvaloniaTestToDoListApp.Models;

namespace AvaloniaTestToDoListApp.ViewModels;

public class TodoListViewModel : ViewModelBase
{
    public TodoListViewModel(IEnumerable<ToDoItem> items)
    {
        Items = new ObservableCollection<ToDoItem>(items);
    }

    public ObservableCollection<ToDoItem> Items { get; }
}