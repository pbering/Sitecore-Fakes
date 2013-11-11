using System;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;
using Sitecore.Data;
using Sitecore.Data.Serialization;
using Xunit;

namespace Sitecore.Fakes.Tests
{
    public class SerializationTests
    {
        [Fact]
        public void CanSerializeItemToDisk()
        {
            //// Arrange
            var fakeItem = new FakeItem(new FieldList());
            var location = Directory.GetCurrentDirectory();
            var x = new DirectoryInfo(Path.Combine(location, "x"));

            x.Create();

            //// Act
            Manager.DumpItem(x.FullName, fakeItem);

            //// Assert
        }
    }
}