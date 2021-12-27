using System.Windows.Input;

namespace WpfApp
{
    public class ViewModel : ViewModelBase
    {
        public string Title 
        {
            get => title;
            private set
            {
                base.SetProperty(ref title, value);
            } 
        }
        private string title = "Our Class Know Nothing!";


        public void SetTitle(string title)
        {
            Title = title;
        }

        public void SetName(string title)
        {
            Title = title;
        }



        #region RunCommand

        public ICommand SetTitleCommand => new RelayCommand(param => SetTitle("crap"));
        public ICommand SetNameCommand => new RelayCommand(param => SetName("Name"));

        #endregion RunCommand




    }
}
