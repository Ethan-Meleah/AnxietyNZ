using AnxietyNZ.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnxietyNZ
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //READ FROM THE DATABASE
            using(SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.DB_PATH))
            {
                conn.CreateTable<contributor_test>();

                //TRANSFORM TABLE INTO A LIST, READY TO DISPLAY
                var contributors = conn.Table<contributor_test>().ToList();
                contributorListView.ItemsSource = contributors;
            };
        }

        private void navigate_newContributor(object sender, EventArgs e)
        {
            Navigation.PushAsync(new newContributorPage(null));
        }

        private async void Edit_Contributor(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            await Navigation.PushAsync(new newContributorPage(btn.BindingContext));
        }
    }
}
