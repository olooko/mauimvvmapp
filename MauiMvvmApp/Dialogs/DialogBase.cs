using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Dialogs
{
    public class DialogBase : ContentView
    {
        private TaskCompletionSource<object> _taskCompletionSource;
        private CancellationToken _token;

        public DialogBase()
        {
            _taskCompletionSource = new TaskCompletionSource<object>();
            _token = new CancellationToken();
        }

        public async Task Show()
        {
            ((Border)this.Parent).IsVisible = true;

            await _taskCompletionSource.Task.WaitAsync(_token);
        }

        public void Close()
        {
            ((Border)this.Parent).IsVisible = false;
            _taskCompletionSource.SetResult(new object());

        }
    }
}
