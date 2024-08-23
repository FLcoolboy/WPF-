using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMDemo1.Commands
{
    /// <summary>
    /// 命令实现
    /// </summary>
    internal class DelegateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
          

           
           return CanExecuteFunc != null ? CanExecuteFunc(parameter) : true;
            
        }

        public void Execute(object parameter)
        {
            //if (ExecuteAction ==null )
            //{
            //    return;
            //}
          this.ExecuteAction(parameter);
        }

        public Action<object> ExecuteAction { get; set; }
        public Func<object, bool> CanExecuteFunc { get; set; }
      
    }
}
