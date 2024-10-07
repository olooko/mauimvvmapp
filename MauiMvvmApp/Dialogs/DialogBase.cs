using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.Dialogs
{
    public class DialogBase : ContentView
    {
        private TaskCompletionSource<bool> _taskCompletionSource;
        private CancellationToken _token;

        public DialogBase()
        {
            _taskCompletionSource = new TaskCompletionSource<bool>();
            _token = new CancellationToken();
        }

        public async Task<bool> Modal()
        {
            ((Border)this.Parent).IsVisible = true;
            return await _taskCompletionSource.Task.WaitAsync(_token);
        }

        public void Close(bool result)
        {
            ((Border)this.Parent).IsVisible = false;
            _taskCompletionSource.SetResult(result);
        }
    }
}
