using MAUIFlexSkills.ViewModels;

namespace MAUIFlexSkills
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel vm;

        public MainPage()
        {
            InitializeComponent();

            vm = new MainPageViewModel();
            BindingContext = vm;
        }

        void OnAddSkillClicked(System.Object sender, System.EventArgs e)
        {
            vm.Skills.Add(SkillEntry.Text);
            SkillEntry.Text = "";
        }

        void OnDeleteSkillClicked(System.Object sender, System.EventArgs e)
        {
            string skill = (sender as Image).BindingContext as string;

            if (!string.IsNullOrEmpty(skill))
            {
                vm.Skills.Remove(skill);
            }
        }
    }
}