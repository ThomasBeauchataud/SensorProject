using System;
using System.Reflection;

namespace SensorProject
{
    public class VisualizerFactory
    {
        public static Visualizer CreateVisualizer(SensorUnity sensorUnity, SensorType sensorType)
        {
            Type finalVisualizerType = null;
            foreach (Type visualizerType in typeof(Visualizer).Assembly.GetTypes())
            {
                VisualizerAttribute visualizerAttribute = (VisualizerAttribute)visualizerType.GetCustomAttribute(typeof(VisualizerAttribute));
                if(visualizerAttribute != null && !visualizerType.IsInterface && visualizerAttribute.type == sensorType )
                {
                    if(visualizerAttribute.unity == sensorUnity)
                    {
                        finalVisualizerType = visualizerType;
                        break;
                    }
                    finalVisualizerType = visualizerType;
                }
            }
            if(finalVisualizerType == null)
            {
                throw new Exception("There is no visualizer supporting the type: " + sensorType.ToString());
            }
            return (Visualizer)Activator.CreateInstance(finalVisualizerType);
        }
    }
}
