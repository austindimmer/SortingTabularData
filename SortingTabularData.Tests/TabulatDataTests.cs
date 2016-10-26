using FluentAssertions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace SortingTabularData.Tests
{
    public class TabulatDataTests:IDisposable
    {
        public TabulatDataTests()
        {
            //Test Setup
        }

        [Theory]
        [InlineData("Data/Test1-UnsortedWithHeaders.csv")]
        void CanLoadTestData(string inputPath)
        {
            // Arrange
            TabularData td = new TabularData();
            // Act
            var results = td.LoadDataToSort(inputPath);
            // Assert
            Assert.NotNull(results);

        }

        [Theory]
        [InlineData("Data/Test1-UnsortedWithHeaders.csv", "TestOutput-VerifyingAbleToSave.csv")]
        [Trait("Category", "Integration")]
        void CanLoadAndSaveTestData(string inputPath, string outputPath)
        {
            // Arrange
            TabularData td = new TabularData();
            // Act
            var results = td.LoadDataToSort(inputPath);
            td.SaveOrderedData(outputPath, results.Result);
            // Assert
            bool fileCreated = File.Exists(outputPath);
            Assert.True(fileCreated);

        }

        [Theory]
        [InlineData("Data/Test1-UnsortedWithHeadersThatIsNotHere.csv")]
        void NonExistentTestDataFileThrowsException(string inputPath)
        {
            // Arrange
            TabularData td = new TabularData();
            // Act
            // Assert
            Assert.ThrowsAsync<FileNotFoundException>(async () => {  var results = td.LoadDataToSort(inputPath).Result; });

        }
        [Theory]
        [ExcelData("Data/TestData.xls", "Select * from TestData")]
        [Trait("Category", "Integration")]
        void CanSortCorrectlyForEveryColumn(string inputPath, string outputPath, string delimeter, bool hasHeaderRow, int columnToSortOn, string columnDataType)
        {
            // Arrange
            TabularData td = new TabularData();
            // Act
            td.SortData(inputPath, outputPath, delimeter, hasHeaderRow, columnToSortOn, columnDataType);
            var expectedOutputPath = "ExpectedData/TestOutput_" + columnToSortOn + "-Sorted.csv";
            var expected = td.LoadDataToSort(expectedOutputPath).Result;
            var actual = td.LoadDataToSort(outputPath).Result;
            // Assert


            actual.Should().NotBeEmpty()
             .And.HaveCount(expected.Count)
             .And.ContainInOrder(expected)
             .And.ContainItemsAssignableTo<Option>();

            actual.Should().Equal(expected);
            actual.Should().BeEquivalentTo(expected);
            

            actual.Should().Equal(expected, (o1, o2) => o1.Book == o2.Book);
            actual.Should().Equal(expected, (o1, o2) => o1.BuySell == o2.BuySell);
            actual.Should().Equal(expected, (o1, o2) => o1.BuySellQuantity == o2.BuySellQuantity);
            actual.Should().Equal(expected, (o1, o2) => o1.CallPut == o2.CallPut);
            actual.Should().Equal(expected, (o1, o2) => o1.Counterparty == o2.Counterparty);
            actual.Should().Equal(expected, (o1, o2) => o1.Currency == o2.Currency);
            actual.Should().Equal(expected, (o1, o2) => o1.Entity == o2.Entity);
            actual.Should().Equal(expected, (o1, o2) => o1.Maturity == o2.Maturity);
            actual.Should().Equal(expected, (o1, o2) => o1.OptionCode == o2.OptionCode);
            actual.Should().Equal(expected, (o1, o2) => o1.OptionType == o2.OptionType);
            actual.Should().Equal(expected, (o1, o2) => o1.SpotPrice == o2.SpotPrice);
            actual.Should().Equal(expected, (o1, o2) => o1.Strike == o2.Strike);
            actual.Should().Equal(expected, (o1, o2) => o1.TradeDate == o2.TradeDate);
            actual.Should().Equal(expected, (o1, o2) => o1.TradePricePerOption == o2.TradePricePerOption);
            actual.Should().Equal(expected, (o1, o2) => o1.Underlying == o2.Underlying);
            actual.Should().Equal(expected, (o1, o2) => o1.Volatility == o2.Volatility);
            actual.Should().Equal(expected, (o1, o2) => o1.Volume == o2.Volume);

            Assert.Equal(expected, actual);


        }

        public void Dispose()
        {
            //Test teardown
        }
    }
    
    
}