using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace TestEnumRadio
{
    public enum Numbers { Uno, Due, Tre}
		
    public class MainWindowViewModel : ViewModelBase
    {
        private RelayCommand _showValueCmd;
        public RelayCommand ShowValueCmd => _showValueCmd ?? (_showValueCmd = new RelayCommand(
                () => MessageBox.Show(Number.ToString()),
                () => { return 1 == 1; },
                keepTargetAlive: true
                ));

        private Numbers _number = Numbers.Uno;
        public Numbers Number { get => _number; set { Set(() => Number, ref _number, value); }}
    }
}
