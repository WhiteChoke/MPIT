/*using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MPTI.ViewModel
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        public ICommand LoginCommand { get; set; }


        static async void Login()
        {

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password)) {
                string connectionString = "Server=localhost;Database=your_database;User ID=your_username;Password=your_password;";

                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $"SELECT COUNT(*) FROM Users WHERE {} = @login AND Имя = @password";
                }
            }
        }
    }
}   
*/
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Maui.Controls;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Input;

namespace MPTI.ViewModel
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _userName;

        [ObservableProperty]
        private string _password;

        public ICommand LoginCommand { get; set; }

        public LoginPageViewModel()
        {
            LoginCommand = new RelayCommand(async () => await Login());
        }

        private async Task Login()
        {
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                string connectionString = "Server=;Database=;User ID=;Password=;";

                using (var connection = new MySqlConnection(connectionString))
                {
                        await connection.OpenAsync();
                        string query = $"SELECT COUNT(*) FROM Users WHERE {UserName} = @login AND {Password} = @password";

                        using (var command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@login", UserName);
                            command.Parameters.AddWithValue("@password", Password);
 
                        }
                    
                }
            }     
        }
    }
}
