using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo1.ViewModels
{
    //具有通知能力  Notification：通知
    internal class NotificationObject : INotifyPropertyChanged
    {
        //DataBinding就是盯着属性事件，当属性值改变时，触发事件
        public event PropertyChangedEventHandler PropertyChanged;
        //触发属性改变事件 Raise: 触发 传递两侧参数：事件名称sender、事件参数
        public void RaisePropertyChanged(string propertyName)
        {
            //执行这个事件
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}

