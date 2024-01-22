using System;
using System.Windows;
using System.Windows.Controls;

namespace Kalkulator
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            AcButton.Click += AcButtonOnClick;
            PlusButton.Click += PlusButtonOnClick;
            MinusButton.Click += MinusButtonOnClick;
            EqualButton.Click += EqualButtonOnClick;
            
            ZeroButton.Click += NumberButtonOnClick;
            OneButton.Click += NumberButtonOnClick;
            TwoButton.Click += NumberButtonOnClick;
            ThreeButton.Click += NumberButtonOnClick;
            FourButton.Click += NumberButtonOnClick;
            FiveButton.Click += NumberButtonOnClick;
            SixButton.Click += NumberButtonOnClick;
            SevenButton.Click += NumberButtonOnClick;
            EightButton.Click += NumberButtonOnClick;
            NineButton.Click += NumberButtonOnClick;
        }

        private void EqualButtonOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MinusButtonOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void PlusButtonOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AcButtonOnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
        
        private void NumberButtonOnClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                ResultLabel.Content += button.Content.ToString();
            }
        }
    }
}