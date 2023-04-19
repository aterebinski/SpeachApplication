using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace SpeachApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Utworzenie obiektu SpeechSynthesizer
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        public MainWindow()
        {
            InitializeComponent();

            // Ustawienie wybranego wariantu głosowego
            synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            // Synteza mowy tekstu wpisanego w polu TextBox
            synthesizer.Speak(textBox.Text);
        }
    }
}
