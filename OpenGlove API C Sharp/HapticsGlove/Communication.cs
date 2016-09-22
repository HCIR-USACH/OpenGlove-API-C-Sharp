using System.IO.Ports;

namespace HapticsGlove
{
    /// <summary>
    /// Represents  a comunication instance between the API and the glove. 
    /// Provide methods for send and receive data through serial port
    /// </summary>
    class Communication
    {
        /// <summary>
        /// Serial port communication field. 
        /// </summary>
        private SerialPort port = new SerialPort();

        /// <summary>
        /// Initialize an instance of Communication class without open the communication with the device.
        /// </summary>
        public Communication()
        {
        }
        /// <summary>
        /// Initialize an instance of Communication class, opening the communication using the specified port and baudrate.
        /// </summary>
        /// <param name="portName">Name of the serial port to open a communication </param>
        /// <param name="baudRate">Data rate in bits per second. Use one of these values: 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, or 115200</param>
        public Communication(string portName, int baudRate)  
        {
            this.port.PortName = portName;
            this.port.BaudRate = baudRate;
            this.port.Open();
        }
        /// <summary>
        /// Returns an array with all active serial ports names
        /// </summary>
        /// <returns>An array with the names of all active serial ports</returns>

        public string[] GetPortNames() {

            return SerialPort.GetPortNames();
        }
        /// <summary>
        /// Open a new connection with the specified port and baudrate
        /// </summary>
        ///<param name = "portName" > Name of the serial port to open a communication</param>
        /// <param name="baudRate">Data rate in bits per second. Use one of these values: 300, 600, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, or 115200</param>
        public void OpenPort(string portName, int baudRate)
        {
           
            this.port.PortName = portName;
            this.port.BaudRate = baudRate;
            this.port.Open();
        }
        /// <summary>
        /// Send the string to the serial port
        /// </summary>
        /// <param name="data">String data to send</param>
        public void Write(string data)
        {
            this.port.Write(data);
        }
        /// <summary>
        /// Read the input buffet until a next line character
        /// </summary>
        /// <returns>A string without the next line character</returns>
        public string ReadLine()
        {
            return this.port.ReadLine();
        }
        /// <summary>
        /// Close the serial communication
        /// </summary>
        public void ClosePort()
        {
            this.port.Close();

        }

       


    }
}
