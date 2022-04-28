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
using System.Windows.Shapes;

namespace DEMOEKZAMEN
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        public Window1(string id, string name, int role)
        {
            InitializeComponent();

            //Разделение имени
            string[] arrayForName = new string[3];
            arrayForName = name.Split(' ');

            //Получение данных о пользователе
            for (int i = 0; i < arrayForName.Length; i++)
            {
                if (i == 0)
                    LabelWelcomeSurname.Content = arrayForName[i];
                else if (i == 1)
                    LabelWelcomeName.Content = arrayForName[i];
                else
                    LabelWelcomeLastname.Content = arrayForName[i];
            }

            //Ожидание 5 секунд
            Task.Delay(5000).ContinueWith(_ =>
            {
                Application.Current.Dispatcher.Invoke(() =>
                {
                    if (role == 3)
                    {
                        //Открытие главной формы
                        Window2 form = new Window2();
                        form.Show();
                        this.Close();
                    }
                    else if (role == 2)
                    {
                        //Открытие формы кладовщика
                        Window5 form = new Window5();
                        form.Show();
                        this.Close();
                    }
                    else
                    {
                        //Открытие формы менджера
                        Window4 form = new Window4();
                        form.Show();
                        this.Close();
                    }

                });

            });


        }

    }
    
}

