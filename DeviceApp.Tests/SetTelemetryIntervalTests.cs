using Microsoft.Azure.Amqp.Framing;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using System;
using System.Text;
using Xunit;

namespace DeviceApp.Tests
{
    public class SetTelemetryIntervalTests
    {
        [Theory]
        [InlineData("SetTelementryInterval", "10", 200)]

        public void SetTelementryInterval_ShouldReturnStatusCodeFailCase(string methodName, string payload, int statusCode)
        {
            var array = Encoding.UTF8.GetBytes("5");
            var response = Program.SetTelemetryInterval(new MethodRequest(methodName, array), null).GetAwaiter().GetResult();
            Assert.Equal(200, response.Status);
        }

        [Theory]
        [InlineData("SetTelementryInterval", "10", 500)]

        public void SetTelementryInterval_ShouldReturnStatusCode(string methodName, string payload, int statusCode)
        {
            var array = Encoding.UTF8.GetBytes("test");
            var response = Program.SetTelemetryInterval(new MethodRequest(methodName, array), null).GetAwaiter().GetResult();
            Assert.Equal(501, response.Status);
        }
    }
}