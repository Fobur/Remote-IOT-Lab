using Microsoft.IdentityModel.Tokens;
using Remote_IOT_Lab.Data;

namespace Stands
{
    public class Stand
    {
        private readonly string _id;
        private readonly string _name;
        private string _description;
        private Videostream _videostream; //Link to WebRTC stream
        private string _ansibleScript;  //Route to script file?
        private StandBoard _standBoard;
        private Light _light;
        private SerialPort _serialPort;


        public string Id { get => _id; }
        public string Name { get => _name; }
        public string Description { get => _description; }

        public Stand(string name, string description, Videostream videostream, string ansibleScript)
        {
            _id = Guid.NewGuid().ToString();
            _name = name;
            _description = description;
            _videostream = videostream;
            _ansibleScript = ansibleScript;
        }

        public Stand(string name)
        {
            _id = Guid.NewGuid().ToString();
            _name = name;
        }
    }
}