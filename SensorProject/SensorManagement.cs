using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Reflection;

namespace SensorProject
{
    public class SensorManagement
    {
        private List<Sensor> sensors;
        private bool running;

        public SensorManagement()
        {
            this.sensors = new List<Sensor>();
            this.running = false;
        }

        public void AddSensor(Sensor sensor)
        {
            this.sensors.Add(sensor);
        }

        public void RemoveSensor(Sensor sensor)
        {
            sensors.Remove(sensor);            
        }

        public void RunSensors()
        {
            running = true;
            while(running)
            {
                foreach(Sensor sensor in this.sensors)
                {
                    ThreadStart threadMain = delegate () {
                        sensor.GetType().GetMethod("Sense").Invoke(sensor, null);
                    };
                    new Thread(threadMain).Start();
                }
                Thread.Sleep(500);
            }
        }
    }
}
