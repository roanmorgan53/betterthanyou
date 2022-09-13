using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

namespace betterThanYou
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool editing = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void benchmax_MouseEnter(object sender, MouseEventArgs e)
        {
            if(benchmax.Text == "Input Your Bench Max"){
                benchmax.Text = "";
            }
        }

        private void benchmax_MouseLeave(object sender, MouseEventArgs e)
        {
            if (benchmax.Text == "")
            {
                if (!benchmax.IsFocused)
                {
                    benchmax.Text = "Input Your Bench Max";
                }
            }
        }


        private void enterbutton_Click(object sender, RoutedEventArgs e)
        {
            if (double.Parse(benchmax.Text) < 225)
            {
                MessageBox.Show("You're a weak loser weenie");
            }
            else if (double.Parse(benchmax.Text) == 225)
            {
                MessageBox.Show("Damn, I was fr gonna roast you");
            }
            else
            {
                MessageBox.Show("Lets Kiss");
            }
        }

        private void benchmax_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void benchmax_MouseEnter_1(object sender, MouseEventArgs e)
        {
            if (benchmax.Text == "Input Your Bench Max")
            {
                benchmax.Text = "";
            }
        }

        private void benchmax_MouseLeave_1(object sender, MouseEventArgs e)
        {
            if (benchmax.Text == "")
            {
                if (!benchmax.IsFocused)
                {
                    benchmax.Text = "Input Your Bench Max";
                }
            }
        }
    }
}
