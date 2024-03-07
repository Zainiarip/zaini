using SchedApp.Views;
using System.Collections.ObjectModel;

namespace SchedApp.Views
{

    public partial class CreatePage : ContentPage
    {
        public ObservableCollection<String> AgendaItems { get; set; } = new ObservableCollection<string>();

        [Obsolete]
        public CreatePage()
        {
            InitializeComponent();
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                UpdateCurrentTime();
                return true;

            });

        }
        private void UpdateCurrentTime()
        {
            CurrentTimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
