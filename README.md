# SensorProject
Program to learn how to use Reflection to create complex instances in a factory
## How it works ?

There is sensors, visualizer and converter. Sensor *sense* data and *visualize* them threw a Visualizer. The data can be converted if the unity of the visualizer and the sensor are not the same.
When we create new sensor, we will automacilly associate it a visualizer. The choice of the associated visualizer will depends on the sensor and this visualizer attributes (which specify which unity and type of data each one is managing). If there is no sensor compatible with any visualizer, a converter will be created to converte data.
