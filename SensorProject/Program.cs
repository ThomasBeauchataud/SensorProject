using System;

namespace SensorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SensorManagement sensorManagement = new SensorManagement();
            sensorManagement.AddSensor(SensorFactory.CreateSensor(SensorUnity.Farhaneit, SensorType.Temperature));
            sensorManagement.RunSensors();
            Console.ReadKey();
        }
    }
}
