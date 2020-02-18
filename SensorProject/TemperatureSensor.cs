using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    public class TemperatureSensor : Sensor
    {
        private Visualizer visualizer;

        public TemperatureSensor(Visualizer visualizer)
        {
            this.visualizer = visualizer;
        }

        public void Sense()
        {
            Random random = new Random();
            object data = random.Next(0, 1000);
            this.visualizer.Visualize(data);
        }
    }
}
