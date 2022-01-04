using System.Windows.Input;
using TinyMvvm;

namespace ShinyDotNetLogging.ViewModels
{
    public class AboutViewModel : ViewModelBase
    {

        public ICommand Home => new TinyCommand(async () =>
        {
            await Navigation.NavigateToAsync("//TabHome/home");
        });

    }
}
