using System;

namespace SensorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Sensor sensor = SensorFactory.createSensor(SensorUnity.Celsuis, SensorType.Temperature);
            Console.ReadKey();
        }
    }
}
