namespace MVVM
{
    public class DataViewModel
    {
        public DataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static DataViewModel()
        {
            All = new List<DataViewModel>
            {
  

                // Data Bindings and MVVM

                //Get current date and time.
                new DataViewModel(typeof(DateTimePage), "DateTime", "Obtain the current DateTime and display it"),

            };
        }
        public static IList<DataViewModel> All { private set; get; }

    }
}
