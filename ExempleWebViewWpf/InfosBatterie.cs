using System.ComponentModel;

namespace ExempleWebViewWpf
{
    public class InfosBatterie : INotifyPropertyChanged
    {
        private int _charge = 50;
        private int _seuilDanger = 40;
        private int _seuilAlerte = 70;
        private bool _enCharge = false;

        private void SetField<T>(ref T field, T value, string name) 
        {
            if(field!=null && !field.Equals(value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        public int Charge { 
            get => _charge; 
            set => SetField(ref _charge, value, nameof(Charge));
        }
        public bool EnCharge
        {
            get => _enCharge;
            set => SetField(ref _enCharge, value, nameof(EnCharge));
        }
        public int SeuilDanger
        {
            get => _seuilDanger;
            set => SetField(ref _seuilDanger, value, nameof(SeuilDanger));
        }
        public int SeuilAlerte
        {
            get => _seuilAlerte;
            set => SetField(ref _seuilAlerte, value, nameof(SeuilAlerte));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
