using Xunit;

namespace Aurochses.Module.Data.Autofac.Tests
{
    public class DataModuleBaseTests
    {
        [Fact]
        public void Inherit_Module()
        {
            // Arrange & Act
            var dataModuleBase = new DataModuleBase();

            // Assert
            Assert.IsAssignableFrom<global::Autofac.Module>(dataModuleBase);
        }
    }
}