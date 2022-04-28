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

namespace DEMOEKZAMEN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Users> listUsers = null;
        public MainWindow()
        {
            InitializeComponent();
            listUsers = StoreDBEntities.GetContext().Users.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach(Users user in listUsers)
                        {
                if (user.Login == TextBoxLogin.Text)
                {
                    if (user.Password == PasswordBox.Password)
                    {
                        //Открытие формы приветствия
                        Window1 form = new Window1(user.Id, user.Name, user.id_Roles);
                        form.Show();
                        this.Close();

                        break;
                    }
                    else
                    {
                        //Сброс пароля
                        PasswordBox.Password = "";

                        MessageBox.Show("Указан неверный пароль!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        break;
                    }

                }
            }
        }
    }
}
