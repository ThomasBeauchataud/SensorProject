using System;

namespace SensorProject
{
    public class SensorAttribute : Attribute
    {
        public SensorType type;
        public SensorUnity unity;

        public SensorAttribute() { }

        public SensorAttribute(SensorType type, SensorUnity unity)
        {
            this.type = type;
            this.unity = unity;
        }
    }
}
