using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace _2017_SeleniumTestsHW.Models
{
    class AccessExcellData
    {
        public static string TestDataFileConnection()
        {
            var path = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var filename = "RegistrationData.xlsx";
            var con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;
		                              Data Source = {0}; 
		                              Extended Properties=Excel 12.0;", path + filename);
            return con;
        }

        public static SoftUniUser GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key = '{0}'", keyName);
                var value = connection.Query<SoftUniUser>(query).FirstOrDefault();
                connection.Close();
                return value;
            }
        }
    }
}
