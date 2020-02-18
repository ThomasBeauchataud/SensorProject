using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    public class BasicSensor : Sensor
    {
        private Visualizer visualizer;

        public BasicSensor(Visualizer visualizer)
        {
            this.visualizer = visualizer;
        }

        public void Sense()
        {
            throw new NotImplementedException();
        }
    }
}
