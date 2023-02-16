using Prism.Mvvm;

namespace SimpleWPFApp.Model
{
    public class Package : BindableBase
    {
        private long id;
        private string name;
        private string description;
        private int weight;

        public long Id { get => id; set => SetProperty(ref id, value); }

        public string Name { get => name; set => SetProperty(ref name, value); }

        public string Description { get => description; set => SetProperty(ref description, value); }

        public int Weight { get => weight; set => SetProperty(ref weight, value); }
    }
}
