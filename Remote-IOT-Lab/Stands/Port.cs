namespace Stands
{
    public class Port
    {
        private PortType _type;
        private int _raspbPortNumber;
        private readonly string _controllerPortNumber;
        private DisplayType _dType;

        public PortType Type { get => _type; }
        public int RaspbPortNumber { get => _raspbPortNumber; }
        public string ControllerPortNumber => _controllerPortNumber;
        public DisplayType DType { get => _dType; }

        public Port(PortType type, int raspbPortNumber, string controllerPortNumber, DisplayType dType)
        {
            _type = type;
            _raspbPortNumber = raspbPortNumber;
            _controllerPortNumber = controllerPortNumber;
            _dType = dType;
        }

        public Port(string controllerPortNumber)
        {
            _controllerPortNumber = controllerPortNumber;
        }
    }
}