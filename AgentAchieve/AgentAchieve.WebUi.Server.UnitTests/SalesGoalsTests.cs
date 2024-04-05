﻿using AgentAchieve.WebUi.Server.Components.Pages.Sales;
using AgentAchieve.WebUi.Server.UnitTests.Common;
using Bunit;
using Microsoft.Extensions.Logging;
using Xunit;
using Xunit.Abstractions;

namespace AgentAchieve.WebUi.Server.UnitTests;

public class SalesGoalsTests(ITestOutputHelper outputHelper) : TelerikTestContext(outputHelper)
{
    [Fact]
    [Trait("Description", "Verifies that the grid has an Excel export button")]
    public void GridHasExcelExportButton()
    {
        LogDescription();

        // Arrange

        // Act
        Logger.LogInformation("Rendering Sales component");
        var cut = RenderComponent<Sales>();

        // Assert
        Logger.LogInformation("Finding grid toolbar and Excel export button");
        var gridToolbar = cut.Find(".k-grid-toolbar");
        Assert.NotNull(gridToolbar.QuerySelector("button:contains('Export to Excel')"));

        Logger.LogInformation("The grid has an Excel export button");
    }
}