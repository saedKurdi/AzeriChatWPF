using AzeriChat.Classes;
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

namespace AzeriChat.windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Message> ? AllMessages { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            AllMessages = new List<Message>()
            {
            new Message("@Saed2005","Salam",new TimeOnly(12,44)),
              new Message("@Aslanboi1","Salam",new TimeOnly(13,52)),
                new Message("@JagaQU","Salam",new TimeOnly(18,23)),
                  new Message("@MAga","Salam", new TimeOnly(20,20)),
                  new Message("@Javid","Salam",new TimeOnly(11,21)),
                  new Message("@saipa123","Salam" ,new TimeOnly(22,10)),
                  new Message("@bukq","Salam", new TimeOnly(18,10)),
                  new Message("@anarl12","Salam", new TimeOnly(12,30)),
                  new Message("@Saed2005","Salam",new TimeOnly(12,44)),
              new Message("@Aslanboi1","Salam",new TimeOnly(13,52)),
                new Message("@JagaQU","Salam",new TimeOnly(18,23)),
                  new Message("@MAga","Salam", new TimeOnly(20,20)),
                  new Message("@Javid","Salam",new TimeOnly(11,21)),
                  new Message("@saipa123","Salam" ,new TimeOnly(22,10)),
                  new Message("@bukq","Salam", new TimeOnly(18,10)),
                  new Message("@anarl12","Salam", new TimeOnly(12,30)),
            };
            DataContext = this;
        
        }
    }
}
