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
using System.Data;
using System.Data.Sql;

namespace Pavilion
{ 
 
    public partial class Manager_C : Page
    {
        
        public Manager_C()
        {

            InitializeComponent();
          
        }

        private void View_SC_Click(object sender, RoutedEventArgs e)
        {
            Manager.connection.Open();
            string cmd = "SELECT tc_name AS Название, status AS Статус ,count_pavilions AS [Количество павильонов],city AS Город,price AS Стоимость,value_added_ratio AS КДС , floor AS Этажность FROM TTs"; // Из какой таблицы нужен вывод
            SqlCommand createCommand = new SqlCommand(cmd, Manager.connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("TTs"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DataGridView.ItemsSource = dt.DefaultView; // Сам вывод
            Manager.connection.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void View_Pavilion_Click(object sender, RoutedEventArgs e)
        {
            Manager.connection.Open();
            string cmd = "SELECT dbo.TTs.tc_name AS [Название торгового центра], dbo.TTs.status AS [Статус торгового центра], dbo.Pavilions.floor AS Этаж, " +
            "dbo.Pavilions.area AS [Площадь павильона], dbo.Pavilions.status AS [Статус павильона], dbo.Pavilions.value_added_ratio AS [кдс], " +
            "dbo.Pavilions.price_for_area AS [Цена за метр] FROM Pavilions INNER JOIN " +
            "dbo.TTs ON Pavilions.tc_id = TTs.tc_id"; // Из какой таблицы нужен вывод
            SqlCommand createCommand = new SqlCommand(cmd, Manager.connection);
            createCommand.ExecuteNonQuery();

            SqlDataAdapter dataAdp = new SqlDataAdapter(createCommand);
            DataTable dt = new DataTable("Pavilions"); // В скобках указываем название таблицы
            dataAdp.Fill(dt);
            DataGridView.ItemsSource = dt.DefaultView; // Сам вывод
            Manager.connection.Close();
        }

        private void Remove_Field_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGridView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Change_SC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Remove_SC_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_Pavilion_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new InterfacePavilion());
        }

        private void Change_Pavilion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Add_SC_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new InterfaceTC());
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
