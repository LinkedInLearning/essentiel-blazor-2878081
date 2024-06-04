using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace ExempleWebViewWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private InfosBatterie _infos = new InfosBatterie();
        private ServiceCollection _services;
 
        public MainWindow()
        {
            _services = new ServiceCollection();

            _services.AddWpfBlazorWebView();
            _services.AddSingleton(_infos);
#if DEBUG
            _services.AddBlazorWebViewDeveloperTools();
#endif
            InitializeComponent();
            blazorWebView.Services = _services.BuildServiceProvider();
            DataContext = _infos;
        }
    }
}