using System;

namespace SensorProject
{
    public class ConverterAttribute : Attribute
    {
        public SensorUnity inputUnity;
        public SensorUnity outputUnity;

        public ConverterAttribute() { }

        public ConverterAttribute(SensorUnity inputUnity, SensorUnity outputUnity)
        {
            this.inputUnity = inputUnity;
            this.outputUnity = outputUnity;
        }
    }
}
