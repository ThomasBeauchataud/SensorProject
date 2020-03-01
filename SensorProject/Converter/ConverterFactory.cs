using System;
using System.Reflection;

namespace SensorProject
{
    public class ConverterFactory
    {
        public static Converter CreateConverter(SensorUnity expectedUnity, SensorUnity realUnity, Sensor sensor, Visualizer visualizer)
        {
            foreach (Type converterType in typeof(Converter).Assembly.GetTypes())
            {
                ConverterAttribute converterAttribute = (ConverterAttribute)converterType.GetCustomAttribute(typeof(ConverterAttribute));
                if (converterAttribute != null && converterAttribute.inputUnity == realUnity && converterAttribute.outputUnity == expectedUnity)
                {
                    return (Converter)Activator.CreateInstance(converterType, sensor, visualizer);
                }
            }
            throw new Exception("There is no converter supporting this conversion, expected: " + expectedUnity.ToString() + ", real: " + realUnity); 
        }
    }
}
