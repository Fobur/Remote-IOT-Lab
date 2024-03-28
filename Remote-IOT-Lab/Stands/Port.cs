namespace Stands
{
    public class Port
    {
        private PortType _type;
        private int _raspbPortNumber;
        private readonly string _controllerPortNumber;
        private DisplayType _dType;

        public PortType Type { get => _type; set => _type = value; }
        public int RaspbPortNumber { get => _raspbPortNumber; set => _raspbPortNumber = value; }
        public string ControllerPortNumber => _controllerPortNumber;
        public DisplayType DType { get => _dType; set => _dType = value; }

        public Port(PortType type, int raspbPortNumber, string controllerPortNumber, DisplayType dType)
        {
            Type = type;
            RaspbPortNumber = raspbPortNumber;
            _controllerPortNumber = controllerPortNumber;
            DType = dType;
        }

        public Port(string controllerPortNumber)
        {
            _controllerPortNumber = controllerPortNumber;
        }
    }
}