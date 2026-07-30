using System.Windows;

namespace StructureViewsPlugin
{
    /// <summary>
    /// Interaction logic for OptionsDialogView.xaml
    /// </summary>
    public partial class OptionsDialogView : Window
    {
        public OptionsDialogView()
        {
            InitializeComponent();
            //DataContext = new MainViewModel();
        }

        private void OnCreateViews(object sender, RoutedEventArgs e) 
        {
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
