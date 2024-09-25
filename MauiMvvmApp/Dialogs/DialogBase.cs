using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Dialogs
{
    public class DialogBase : ContentView
    {
        public void Close()
        {
            ((Border)this.Parent).IsVisible = false;
        }
    }
}
