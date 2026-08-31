using BackNavigationTest.Models;
using CommunityToolkit.Mvvm.Input;

namespace BackNavigationTest.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}