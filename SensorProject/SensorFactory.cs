using System;

namespace SensorProject
{
    public class SensorFactory
    {
        public static Sensor createSensor(SensorUnity sensorUnity, SensorType sensorType)
        {
            Sensor sensor = new BasicSensor(null);
            Attribute[] sensorAttributes = Attribute.GetCustomAttributes(sensor.GetType());
            foreach(Attribute attribute in sensorAttributes)
            {
                if(attribute is SensorAttribute)
                {
                    ((SensorAttribute)attribute).type = sensorType;
                    ((SensorAttribute)attribute).unity = sensorUnity;
                }
            }
            return sensor;
        }
    }
}
