namespace Class1
{
    public class Class1
    {
        private string name;
        private DateTime birthday;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public int GetAge()
        {
            int age = DateTime.Today.Year - birthday.Year;
            if (
                DateTime.Today.Month < birthday.Month ||
                DateTime.Today.Month == birthday.Month &&
                DateTime.Today.Day < birthday.Month
                )
            {
                age = age - 1;
            }
            return age;
        }
    }
}
