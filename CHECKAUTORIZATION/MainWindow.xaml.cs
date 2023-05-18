using CaptchaLib;
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
using USQLCSharpProject1;



namespace CHECKAUTORIZATION
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void CapBtn_Click(object sender, RoutedEventArgs e)
        {
            CaptchaTxb.Text = CaptchaClass.CaptchaGen(CaptchaTxb.Text) ;
        }

        private void CaptchaTxb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (CaptchaTxb.Text == CaptchaProverka.Text ){
                MessageBox.Show("Проверка пройдена!");
            }
            else
            {
                MessageBox.Show("Каптча неверная!");
            }
        }
    }
}
