using AnxietyNZ.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnxietyNZ
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class newContributorPage : ContentPage
	{
		public newContributorPage ()
		{
			InitializeComponent ();
		}

        private void Save_Contributor(object sender, EventArgs e)
        {
            //CREATES A NEW INSTANCE OF THE CONTRIBUTOR (CURRENTLY FOR TESTING PURPOSES)
            contributor_test contributor = new contributor_test()
            {
                contributor_name = name_entry.Text,
                contributor_address = address_entry.Text,
                contributor_email = email_entry.Text,
                contributor_phone_number = ph_number_entry.Text
            };

            using (SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection((App.DB_PATH)))
            {
                conn.CreateTable<contributor_test>();
                var numberOfRows = conn.Insert(contributor);

                if(numberOfRows > 0)
                {
                    DisplayAlert("Success!", "Contributor Inserted [TEST]", "Confirm.");
                } else
                {
                    DisplayAlert("Faliure!", "Contributor not insereted [TEST].", "Confirm.");
                }
            };

            
        }
    }
}