﻿using CatFactory.CodeFactory.Scaffolding;
using CatFactory.Tests.Models;
using Xunit;

namespace CatFactory.Tests
{
    public class ProjectTests
    {
        [Fact]
        public void TestBuildFeaturesForProject()
        {
            // Arrange
            var project = new Project<ProjectSettings>
            {
                Name = "OnLineStore",
                Database = Databases.OnLineStore
            };

            // Act
            project.BuildFeatures();

            // Assert
            Assert.True(project.Features.Count == 4);
        }
    }
}
