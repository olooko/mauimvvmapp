using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMvvmApp.ViewModels
{
    public partial class DataViewModel : ViewModelBase
    {
        [ObservableProperty]
        private ObservableCollection<Models.SampleDataModel> _sampleDataList;

        public DataViewModel()
        {
            _sampleDataList = new ObservableCollection<Models.SampleDataModel>();

            for (int i = 1; i <= 2000; i++)
            {
                _sampleDataList.Add(new Models.SampleDataModel() { Id = i, Name = string.Format("이름 {0}", i), Description = string.Format("설명 {0}: 설명은 두줄이 될 만큼 아주 길게 쓸 예정입니다.", i) });
            }
        }
    }
}
