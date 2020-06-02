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

namespace Lab5wpf
{
    /// <summary>
    /// Логика взаимодействия для PersonCard.xaml
    /// </summary>
    public partial class PersonCard : UserControl
    {
        public PersonCard()
        {
            InitializeComponent();

        }

        public static readonly DependencyProperty FNameProperty = DependencyProperty.Register(
                                                 "name", // имя параметра в разметке
                                                 typeof(string), // тип данных параметра
                                                 typeof(PersonCard), // тип данных элемента управления
                                                 new PropertyMetadata(string.Empty, NameChanged));

        public string FName
        {
            get { return (string)GetValue(FNameProperty); }
            set { SetValue(FNameProperty, value); }
        }

        private static void NameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.name.Text = loginForm.FName.ToString();
        }





        public static readonly DependencyProperty SerNameProperty = DependencyProperty.Register(
                                               "sername", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonCard), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, SerNameChanged));

        public string SerName
        {
            get { return (string)GetValue(SerNameProperty); }
            set { SetValue(SerNameProperty, value); }
        }

        private static void SerNameChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.sername.Text = loginForm.SerName.ToString();
        }





        public static readonly DependencyProperty AgeProperty = DependencyProperty.Register(
                                               "age", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonCard), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, AgeChanged));

        public string Age
        {
            get { return (string)GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }

        private static void AgeChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.age.Text = loginForm.Age.ToString();
        }





        public static readonly DependencyProperty JobProperty = DependencyProperty.Register(
                                               "myjob", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonCard), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, JobChanged));

        public string MyJob
        {
            get { return (string)GetValue(JobProperty); }
            set { SetValue(JobProperty, value); }
        }

        private static void JobChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.myjob.Text = loginForm.MyJob.ToString();
        }





        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register(
                                               "job", // имя параметра в разметке
                                               typeof(string), // тип данных параметра
                                               typeof(PersonCard), // тип данных элемента управления
                                               new PropertyMetadata(string.Empty, ImageChanged));

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        private static void ImageChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var loginForm = obj as PersonCard;
            loginForm.photo.Source = new BitmapImage(new Uri($"pack://application:,,,/{loginForm.Image}"));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Контакт добавлен!");
        }

        private void call_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Абонент недоступен!");
        }

        private void write_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сообщения недоступны!");
        }
    }
}
