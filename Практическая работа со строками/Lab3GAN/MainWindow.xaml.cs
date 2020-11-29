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

namespace Lab3GAN
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        InsertOperatorClass IOC = new InsertOperatorClass();
        OperationOnStringMass OOSM = new OperationOnStringMass();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(CmboBox1.SelectedIndex == 0)
            {
                TxtBox2_Result.Text = "";
                string[] CreatedBuffer = IOC.ClassInsert(TxtBox1_Insert.Text);
                string[] ResultArray = OOSM.ChangeForRule(CreatedBuffer);
                for (int i = 0; i < ResultArray.Length; i++)
                {
                    TxtBox2_Result.Text += ResultArray[i] + " ";
                }
            }
            if (CmboBox1.SelectedIndex == 1)
            {
                TxtBox2_Result.Text = "";
                string[] ArrayResult = IOC.ClassInsert(TxtBox1_Insert.Text);
                int CountResult = OOSM.CountFirstAndSecond(ArrayResult);
                for (int i = 0; i < ArrayResult.Length; i++)
                {
                    if (i == ArrayResult.Length - 1)
                    {
                        TxtBox2_Result.Text += ArrayResult[i] + " ";
                        TxtBox2_Result.Text += "\n Количество слов удовлетворяющих условию: " + CountResult;
                    }
                    else
                    {
                        TxtBox2_Result.Text += ArrayResult[i] + " ";
                    }
                }
            }
            if (CmboBox1.SelectedIndex == 2)
            {
                TxtBox2_Result.Text = "";
                string result = Microsoft.VisualBasic.Interaction.InputBox("Введите номер слова в тексте:");
                string[] ArrayTemp = IOC.ClassInsert(TxtBox1_Insert.Text);
                string[] ResultArray = OOSM.CopyChart(ArrayTemp, Convert.ToInt32(result) - 1);
                for (int i = 0; i < ResultArray.Length; i++)
                {
                    TxtBox2_Result.Text += ResultArray[i] + " ";
                }
            }
        }
    }
}
