using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MVVMDemo1.Commands;

namespace MVVMDemo1.ViewModels
{
    internal class MainWindowViewModel:NotificationObject
    {
		private double input1;

		public double Input1
		{
			get { return input1; }
			set { input1 = value;
                //当值改变时执行，触发PropertyChangedEventHandler事件，通知UI层绑定的这个属性
                this.RaisePropertyChanged("Input1");
			}
		}

        private double input2;

        public double Input2
        {
            get { return input2; }
            set
            {
                input2 = value;
                this.RaisePropertyChanged("Input2");
            }
        }

        private double result;

        public double Result
        {
            get { return result; }
            set
            {
                result = value;
                this.RaisePropertyChanged("Result");
            }
        }

        public DelegateCommand AddCommand { get; set; }
        private void Add(object parameter)
        {
            Result = Input1 + Input2;
        }
        public MainWindowViewModel()
        {
            this.AddCommand = new DelegateCommand();
            this.AddCommand.ExecuteAction = new Action<object>(Add);
        }
    }
}
