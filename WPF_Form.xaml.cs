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
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.Geometry;

namespace Autocad_WFP_ADD_Cirsle_21_03_2023
{
    // дата создания 21-03-2023 время создания с 8-20  до ...... текущее время 11-53
    // Атор Фишман Денис Борисович 
    /// <summary>
    /// Логика взаимодействия для WPF_Form.xaml
    /// </summary>
    public partial class WPF_Form : Window
    {
        public string onestring;
        public List<string> LayerCircl_name = new List<string>();
        public List<string> LayerCircl_diam = new List<string>();

        public WPF_Form()
        {
            InitializeComponent();
            textplus();
            text_diam_plus();
        }
        public List<string> textplus()
        {
            int lineCount = TextBox1.LineCount;

            for (int line = 0; line < lineCount; line++)
                // GetLineText takes a zero-based line index.
                LayerCircl_name.Add(TextBox1.GetLineText(line));

            return LayerCircl_name;
        }
        public List<string> text_diam_plus()
        {
            int lineCount = TextBox2.LineCount;

            for (int line = 0; line < lineCount; line++)
                // GetLineText takes a zero-based line index.
                LayerCircl_diam.Add(TextBox2.GetLineText(line));
            return LayerCircl_diam;
        }
        private void B8_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in LayerCircl_name)
            {
                //  MessageBox.Show(item.ToString());

                broker_ one = new broker_();
                one.list_broker = LayerCircl_name;
            }
            foreach (var item in LayerCircl_diam)
            {
                //  MessageBox.Show(item.ToString());
                broker_ two = new broker_();
                two.list_broker = LayerCircl_diam;
            }
        }
        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            LayerCircl_name.Add((string)TextBox1.Text);
        }
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            LayerCircl_diam.Add((string)TextBox2.Text);
        }
    }
}
