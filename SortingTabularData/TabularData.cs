using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper.Configuration;
using System.Diagnostics.Contracts;

namespace SortingTabularData
{
    public class TabularData
    {
        public void SortData(string inputPath, string outputPath, string delimeter, bool hasHeaderRow, int columnToSortOn, string columnDataType)
        {
            Contract.Requires(!string.IsNullOrEmpty(delimeter), nameof(delimeter) + " is null or empty.");
            Contract.Requires(!string.IsNullOrEmpty(outputPath), nameof(outputPath) + " is null or empty.");
            Contract.Requires(!string.IsNullOrEmpty(inputPath), nameof(inputPath) + " is null or empty.");

            var data = LoadDataToSort(inputPath).Result;
            var sortColumn = (ColumnPropertyName)columnToSortOn;
            var propertyInfo = typeof(Option).GetProperty(sortColumn.ToString());
            var orderBySortColumn = data.OrderBy(x => propertyInfo.GetValue(x, null));
            SaveOrderedData(outputPath, orderBySortColumn);
        }

        public async Task<List<Option>> LoadDataToSort(string inputPath)
        {
            using (StreamReader reader = File.OpenText(inputPath))
            {
                try
                {
                    var csv = new CsvReader(reader);
                    var records = csv.GetRecords<Option>().ToList();
                    return records;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public void SaveOrderedData(string outputPath, IEnumerable<Option> orderedRecords) {
            using (TextWriter textWriter = File.CreateText(outputPath))
            {
                try
                {
                    var csv = new CsvWriter(textWriter);
                    csv.WriteRecords(orderedRecords);
                }
                catch (Exception ex)
                {

                }
            }


        }


    }
}
