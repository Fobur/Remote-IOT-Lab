namespace Remote_IOT_Lab.Data
{
    public class Group
    {
        private readonly string _id;
        private string _name;
        private string _description;

        public string Id => _id;
        public string Name { get => _name;}
        public string Description { get => _description;}

        public Group(string name, string descriprion)
        {
            _id = Guid.NewGuid().ToString(); 
            _name = name;
            _description = descriprion;
        }
    }
}