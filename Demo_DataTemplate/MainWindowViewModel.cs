using System.Collections.ObjectModel;

namespace MVVM_Persons_Demo
{
    public class MainWindowViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public MainWindowViewModel()
        {
            this.Persons = new ObservableCollection<Person>();
            for (int i = 0; i < 6; i++)
            {
                this.Persons.Add(RandomPersonGenerator.GetInstance().Generate());
            }
        }
    }
}
