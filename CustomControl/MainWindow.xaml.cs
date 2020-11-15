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
using System.Collections.ObjectModel;

namespace CustomControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> SampleItems { get; private set; } = new ObservableCollection<string>();

        public MainWindow()
        {
            InitializeComponent();

            this.ListBoxOriginal.DataContext = this.SampleItems;
            this.ListBoxCustom1.DataContext = this.SampleItems;
            this.ListBoxCustom2.DataContext = this.SampleItems;
            this.ListBoxCustom3.DataContext = this.SampleItems;

            this.SampleItems.Add("item1");
            this.SampleItems.Add("item2");
            this.SampleItems.Add("item3");

        }
    }
}
