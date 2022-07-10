using AvaloniaTestToDoListApp.Models;
using ReactiveUI;
using System.Reactive;

namespace AvaloniaTestToDoListApp.ViewModels;

public class AddItemViewModel : ViewModelBase
{
    private string _description;

    public AddItemViewModel()
    {
        var addEnabled = this.WhenAnyValue(
            x => x.Description,
            x => !string.IsNullOrWhiteSpace(x));

        Add = ReactiveCommand.Create(
            () => new ToDoItem { Description = Description }, addEnabled);
        Cancel = ReactiveCommand.Create(() => { });
    }

    public string Description
    {
        get => _description;
        set => this.RaiseAndSetIfChanged(ref _description, value);
    }
    
    public ReactiveCommand<Unit, ToDoItem> Add { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }
}