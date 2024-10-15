using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MauiMvvmApp.ViewModels
{
    public partial class DataViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<Models.SampleDataModel> _sampleDataList;

        public DataViewModel()
        {
            _sampleDataList = new ObservableCollection<Models.SampleDataModel>();

            GetItems();
        }

        [RelayCommand]
        private void GetItems()
        {
            Stopwatch sw = Stopwatch.StartNew();

            this.SampleDataList.Clear();

            for (int i = 1; i <= 2000; i++)
            {
                string guid = Guid.NewGuid().ToString();

                this.SampleDataList.Add(new Models.SampleDataModel() { Id = guid, Name = string.Format("이름 {0}", guid), Description = string.Format("설명 {0}: 설명은 두줄이 될 만큼 아주 길게 쓸 예정입니다.", guid) });
            }

            Debug.WriteLine(sw.ElapsedMilliseconds.ToString());
        }
    }
}
