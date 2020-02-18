using System;
using System.Reflection;

namespace SensorProject
{
    public class SensorFactory
    {
        public static Sensor CreateSensor(SensorUnity sensorUnity, SensorType sensorType)
        {
            Visualizer visualizer = VisualizerFactory.CreateVisualizer(sensorUnity, sensorType);
            Sensor sensor = CreateSensorIntenral(sensorUnity, sensorType);
            VisualizerAttribute visualizerAttribute = (VisualizerAttribute)visualizer.GetType().GetCustomAttribute(typeof(VisualizerAttribute));
            if (visualizerAttribute.unity != sensorUnity)
            {
                sensor = (Sensor)ConverterFactory.CreateConverter(visualizerAttribute.unity, sensorUnity, sensor, visualizer);
            } 
            return sensor;
        }

        private static Sensor CreateSensorIntenral(SensorUnity sensorUnity, SensorType sensorType)
        {
            Sensor sensor = null;
            foreach (Type sensorClass in typeof(Sensor).Assembly.GetTypes())
            {
                SensorAttribute sensorAttribute = (SensorAttribute)sensorClass.GetCustomAttribute(typeof(SensorAttribute));
                if (sensorAttribute != null && sensorAttribute.type == sensorType && sensorAttribute.unity == sensorUnity)
                {
                    sensor = (Sensor)Activator.CreateInstance(sensorClass);
                }
            }
            if (sensor == null)
            {
                throw new Exception("There is no sensor class corresponding the this criteria, type: " + sensorType + ", unity: " + sensorUnity);
            }
            return sensor;
        }
    }
}
