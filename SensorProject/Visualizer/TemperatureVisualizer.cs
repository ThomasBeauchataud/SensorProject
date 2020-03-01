using System;

namespace SensorProject
{
    [Visualizer(SensorType.Temperature, SensorUnity.Celsuis)]
    public class TemperatureVisualizer : Visualizer
    {
        public void Visualize(object data)
        {
            Console.WriteLine(data);
        }
    }
}
