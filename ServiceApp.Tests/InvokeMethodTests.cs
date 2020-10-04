using System;
using System.Threading.Tasks;
using Xunit;

namespace ServiceApp.Tests
{
    public class InvokeMethodTests
    {
        [Fact]
        public void InvokeMethodTest()
        {
            Task task = ServiceApp.Program.InvokeMethod("test", "test", "false");

            Assert.Equal(TaskStatus.WaitingForActivation, task.Status);

        }
    }
}
