using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace Pavilion
{
 
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-SE9D8MI\SQLEXPRESS"; 
            builder.InitialCatalog = "уп 2.0";
            builder.IntegratedSecurity = true;
            Manager.connection = new SqlConnection(builder.ConnectionString);
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(new login());
        }
    }
}
