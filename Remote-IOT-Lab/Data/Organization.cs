using Microsoft.IdentityModel.Tokens;
using Stands;

namespace Remote_IOT_Lab.Data
{
    public class Organization
    {
        private string _id;
        public string Id { get => _id; }
        public readonly string OrgName;
        private List<Stand> _stands = new List<Stand>();
        public readonly DateTime UtcCreateTime;

        public Organization(string orgName, List<Stand> stands)
        {
            _id = Guid.NewGuid().ToString();
            OrgName = orgName;
            _stands = stands.IsNullOrEmpty()? _stands : stands;
            UtcCreateTime = DateTime.UtcNow;
        }

        public void AddNewStand(Stand stand) => _stands.Add(stand);

        public bool DeleteStand(Stand stand)
        {
            return _stands.Remove(stand) 
                ? true
                : throw new Exception("There's no such stand in this Organization");
        }
    }
}
