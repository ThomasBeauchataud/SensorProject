using System;

namespace SensorProject
{
    [Sensor(SensorType.Temperature, SensorUnity.Farhaneit)]
    public class TemperatureSensor : Sensor
    {
        private Visualizer visualizer;

        public TemperatureSensor () { }

        public TemperatureSensor(Visualizer visualizer)
        {
            this.visualizer = visualizer;
        }

        public void Sense()
        {
            Random random = new Random();
            object data = random.Next(-4, 68);
            this.visualizer.Visualize(data);
        }

        public void SetVisualizer(Visualizer visualizer)
        {
            this.visualizer = visualizer;
        }
    }
}
