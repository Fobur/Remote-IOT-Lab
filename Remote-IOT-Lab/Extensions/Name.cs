namespace Extensions
{
    public class Name
    {
        private readonly string _name;
        private readonly string _surname;

        public string FirstName { get => _name; }
        public string LastName { get => _surname; }

        public Name(string name, string surname)
        {
            _name = name;
            _surname = surname;
        }
    }
}
