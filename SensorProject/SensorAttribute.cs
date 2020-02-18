using System;
using System.Collections.Generic;
using System.Text;

namespace SensorProject
{
    public class SensorAttribute : Attribute
    {
        public SensorType type;
        public SensorUnity unity;

        public SensorAttribute() { }
    }
}
