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

namespace Lab02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Proceed_Click(object Sender, EventArgs e)
        {
            if (!Person.IsDateCorrect((DateTime)datePicker.SelectedDate))
            {
                MessageBox.Show("Date is incorrect");
                return;
            }
            Person person = new Person(firstName.Text, lastName.Text, email.Text, (DateTime)datePicker.SelectedDate);
            if (person.IsBirthday)
            {
                MessageBox.Show("Happy Birthday!");
            }
            outFirstName.Text = person.FirstName;
            outLastName.Text = person.LastName;
            outEmail.Text = person.Email;
            outBirthday.Text = person.Birthday.ToString("dd/MM/yyyy");
            outIsAdult.Text = "Is adult: " + person.IsAdult;
            outSunSign.Text = person.SunSign;
            outChineseSign.Text = person.ChineseSign;
            outIsBirthday.Text = "Is birthday: " + person.IsBirthday;
        }

        private void DatePicker_DateChanged(object Sender, SelectionChangedEventArgs e)
        {
            changeButtonState();
        }

        private void TextChanged(object Sender, EventArgs e)
        {
            changeButtonState();
        }

        private void changeButtonState()
        {
            if(firstName.Text.Length != 0 && lastName.Text.Length != 0 && email.Text.Length != 0 && datePicker.SelectedDate.HasValue)
            {
                proceed.IsEnabled = true;
            }
            else
            {
                proceed.IsEnabled = false;
            }
        }
    }
}
