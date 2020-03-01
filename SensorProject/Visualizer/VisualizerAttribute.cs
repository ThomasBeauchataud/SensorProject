using System;

namespace SensorProject
{
    public class VisualizerAttribute : Attribute
    {
        public SensorType type;
        public SensorUnity unity;
        private SensorType temperature;
        private SensorUnity celsuis;

        public VisualizerAttribute() { }

        public VisualizerAttribute(SensorType temperature, SensorUnity celsuis)
        {
            this.temperature = temperature;
            this.celsuis = celsuis;
        }
    }
}
