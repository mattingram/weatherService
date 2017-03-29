# WeatherStation

This project consists of an Adafruit Feather HUZZAH ESP8266 running NodeMCU/Lua with a BME280 Temperature/Humidity/Pressure sensor that POSTS JSON data to the WeatherService.

WeatherService is a ASP.NET Core Web API app hosted in Azure that writes to a SqlLite database to store and serve the sensor data.
