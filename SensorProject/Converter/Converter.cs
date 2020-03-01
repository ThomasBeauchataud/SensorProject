using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    public abstract class Converter : Visualizer, Sensor
    {
        protected Sensor sensor;
        protected Visualizer visualizer;

        public Converter(Sensor sensor, Visualizer visualizer)
        {
            this.sensor = sensor;
            this.visualizer = visualizer;
            this.sensor.SetVisualizer(this);
        }

        public void Sense()
        {
            this.sensor.Sense();
        }

        public void SetVisualizer(Visualizer visualizer)
        {
            this.visualizer = visualizer;
        }

        public void Visualize(object data)
        {
            this.visualizer.Visualize(Convert(data));
        }

        protected abstract object Convert(object data);
    }
}
