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
using Whois.NET;

namespace domain
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string qdomail = houzhui.Text;//获取文本框内容
            //qdomail = "baidu.com";
            //qdomail = 2454545457 + "." + qdomail;

            

            var qresult = WhoisClient.Query(qdomail);
            result.Text = "";
            if (much.IsChecked == true)
            {
                int i;
                
                string[] dom = new string[3] { ".com", ".net", ".me" };
                string qdomain;

                for (i = 0; i < 3; i++)
                {
                    qdomain = qdomail + dom[i];
                    qresult = WhoisClient.Query(qdomain);

                    if (qresult.OrganizationName == null)

                        result.AppendText(qdomain + " " + "可以注册");
                    else
                        result.AppendText(qdomain + " " + "已注册");

                    result.AppendText("\n");
                }


            }

            else {
                if (list.Text != "其他")
                {

                    qdomail = qdomail + list.Text;//组建域名

                }//后缀列表不含有本域名
                if (qresult.OrganizationName == null)

                    result.Text = qdomail + " " + "可以注册";
                else
                    result.Text = qdomail + " " + "已注册";

            }


            //string qdomail = houzhui.Text;
            ////qdomail = "baidu.com";
            ////qdomail = 2454545457 + "." + qdomail;
            //var qresult = WhoisClient.Query(qdomail);
            //if (qresult.OrganizationName == null)

            //    result.Text = qdomail + "" + "可以注册";
            //else
            //    result.Text = qdomail + "" + "已注册";


        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Single_Checked(object sender, RoutedEventArgs e)
        {
            
               
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //list.SelectedItem = ".com";
        }

        private void ComboBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
    
}
