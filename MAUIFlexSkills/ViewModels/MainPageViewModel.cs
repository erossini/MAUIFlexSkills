using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIFlexSkills.ViewModels
{
    public class MainPageViewModel
    {
        private ObservableCollection<string>? _skills;

        public MainPageViewModel()
        {
            Skills = new ObservableCollection<string>() { "test1", "test2" };
        }

        public ObservableCollection<string>? Skills
        {
            get
            {
                return _skills;
            }
            set
            {
                _skills = value;
            }
        }
    }
}
