using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace CrashOnDisconnectedItem
{
    public partial class MainViewModel
    {
        public ObservableCollection<string> Destinations { get; } = ["loc1", "loc2", "loc3"];

        [RelayCommand]
        public void Move(string? destination)
        {
            if (string.IsNullOrEmpty(destination))
            {
                throw new ArgumentNullException(nameof(destination));
            }

            //do something here
            MessageBox.Show($"Moved something to {destination}");
        }
    }
}
