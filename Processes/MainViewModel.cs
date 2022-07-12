using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//var processes = Process.GetProcesses();

namespace Processes
{
    [INotifyPropertyChanged]
    public  partial class MainViewModel
    {
        Process[] processes = Process.GetProcesses();

        [ObservableProperty]
        private ObservableCollection<Process>? _processes;

        public MainViewModel()
        {
            Processes = new ObservableCollection<Process>(); 
            foreach(var v in processes)
            {
                Processes.Add(v);
            }
        }

    }
}
