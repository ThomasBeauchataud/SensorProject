using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    [Converter(SensorUnity.Farhaneit, SensorUnity.Celsuis)]
    public abstract class FartoCelConverter : Sensor, Visualizer
    {
        private Sensor sensor;

        public FartoCelConverter(Sensor sensor)
        {
            this.sensor = sensor;
        }

        public void Sense()
        {
            this.sensor.Sense();
        }

        public void Visualize(object data)
        {
            sensor
        }

        private object Convert(object data)
        {
            return (32 * (int)data - 32) * 5 / 9;
        }
    }
}
