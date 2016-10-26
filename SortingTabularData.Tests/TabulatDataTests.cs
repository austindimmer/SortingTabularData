using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace SortingTabularData.Tests
{
    public class TabulatDataTests
    {
        [Theory]
        [InlineData("Data/Test1-UnsortedWithHeaders.csv")]
        void CanLoadTestData(string inputPath)
        {
            // arrangefixturesetup
            TabularData td = new TabularData();
            // actexcercisesystem
            var results = td.LoadDataToSort(inputPath);
            // assertverifyoutcome
            Assert.NotNull(results);

        }
        [Theory]
        [ExcelData("Data/TestData.xls", "Select * from TestData")]
        void CanLoadTestData(string inputPath, string outputPath, string delimeter, bool hasHeaderRow, int columnToSortOn, string columnDataType)
        {
            
        }
    }
    
    
}