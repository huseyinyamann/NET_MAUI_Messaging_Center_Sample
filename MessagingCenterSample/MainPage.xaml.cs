using System.Collections.ObjectModel;

namespace MessagingCenterSample
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> Messages { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page, DateTime>(this, "tick", (p, datetime) =>
            {
                // Handle the tick message here
                // You can access the page using 'p' and datetime using 'datetime'
            });
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }

}
