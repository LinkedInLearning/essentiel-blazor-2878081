using ExempleWebViewForms;
using ExempleWebViewForms.Components;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace ExempleWebView
{
    public partial class FrmMain : Form
    {
        private InfosBatterie _infos = new InfosBatterie();
        private ServiceCollection _services;

        public FrmMain()
        {
            _services = new ServiceCollection();

            _services.AddWindowsFormsBlazorWebView();
            _services.AddSingleton(_infos);
            #if DEBUG
            _services.AddBlazorWebViewDeveloperTools();
            #endif
            InitializeComponent();
            blazorWebView.Services = _services.BuildServiceProvider();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            trackCharge.Value = _infos.Charge;
            cbEnCharge.Checked = _infos.EnCharge;
            numAlerte.Value = _infos.SeuilAlerte;
            numDanger.Value = _infos.SeuilDanger;

            blazorWebView.RootComponents.Add<Routes>("#app");
        }

        private void MajBatterie(object sender, EventArgs e)
        {
            _infos.Charge = trackCharge.Value;
            _infos.EnCharge = cbEnCharge.Checked;
            _infos.SeuilAlerte = (int)numAlerte.Value;
            _infos.SeuilDanger = (int)numDanger.Value;
            lblCharge.Text = $"Charge : { _infos.Charge }%";
        }


    }
}
