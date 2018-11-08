using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BenchMark
{
    public class ViewModel
    {
		public ObservableCollection<Model> SeriesData { get; set; }

        public ViewModel()
        {
            SeriesData = new ObservableCollection<Model>();
            SeriesData.Add(new Model("Group A", 50));
            SeriesData.Add(new Model("Group B", 60));
            SeriesData.Add(new Model("Group C", 70));
        }
    }
}
