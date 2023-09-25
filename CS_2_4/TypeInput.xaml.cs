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

namespace CS_2_4
{
    /// <summary>
    /// Логика взаимодействия для TypeInput.xaml
    /// </summary>
    public partial class TypeInput : Window
    {
        private string _typedName;
        public string typedName
        {
            get { return _typedName;  }
            set
            {
                if (value == "")
                {
                    MessageBox.Show("Empty input!");
                }
                else
                {
                    _typedName = value;
                }
            }
        }
        public bool isResponse = false;
        public TypeInput()
        {
            InitializeComponent();
        }

        private void saveInputed_Click(object sender, RoutedEventArgs e)
        {
            typedName = typeInner.Text;
            if (typedName != null)
            {
                isResponse = true;
                Close();
            }
        }
    }
}
