using CsvHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper.Configuration;

namespace SortingTabularData
{
    public class TabularData
    {
        public void SortData(string inputPath, string outputPath, string delimeter, bool hasHeaderRow, int columnToSortOn, string columnDataType)
        {

        }

        public List<Option> LoadDataToSort(string inputPath)
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
    }
}
