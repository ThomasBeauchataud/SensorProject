using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    [Converter(SensorUnity.Farhaneit, SensorUnity.Celsuis)]
    public class FarToCelConverter : Converter
    {
        public FarToCelConverter(Sensor sensor, Visualizer visualizer) : base(sensor, visualizer) { }
 
        protected override object Convert(object data)
        {
            return ((int)data - 32) * 5 / 9;
        }
    }
}
