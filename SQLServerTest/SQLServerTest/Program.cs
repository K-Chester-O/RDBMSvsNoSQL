using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SQLServerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            String readerCode; String readerName; String readerContinent; String readerRegion; Decimal readerSurfaceArea;
            short readerIndepYear; int readerPopulation; decimal readerLifeExpectancy; decimal readerGNP; decimal readerGNPOld;
            String readerLocalName; String readerGovernmentForm; String readerHeadOfState; Int32 readerCapital; String readerCode2;
            List<Country> countries = new List<Country>();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SqlConnection sqlConnection1 = new SqlConnection("Data Source=(local);Initial Catalog=BigWorld;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            sqlConnection1.Open();
            //TestQuery(sqlConnection1, cmd, "SELECT * FROM Country");
            TestQuery(sqlConnection1, cmd, "SELECT * FROM Query");
            TestQuery(sqlConnection1, cmd, "SELECT * FROM Query");
            TestQuery(sqlConnection1, cmd, "SELECT * FROM Query");
            TestQuery(sqlConnection1, cmd, "SELECT * FROM Query");
            TestQuery(sqlConnection1, cmd, "SELECT * FROM Query");
            //TestQuery(sqlConnection1, cmd, "SELECT * FROM CountryLanguage");
            stopwatch.Stop();

            #region Query to List Object
            /*if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        readerCode = "";
                    }
                    else
                    {
                        readerCode = reader.GetString(0);
                    }
                    if (reader.IsDBNull(1))
                    {
                        readerName = "";
                    }
                    else
                    {
                        readerName = reader.GetString(1);
                    }
                    if (reader.IsDBNull(2))
                    {
                        readerContinent = "";
                    }
                    else
                    {
                        readerContinent = reader.GetString(2);
                    }
                    if (reader.IsDBNull(3))
                    {
                        readerRegion = "";
                    }
                    else
                    {
                        readerRegion = reader.GetString(3);
                    }
                    if (reader.IsDBNull(4))
                    {
                        readerSurfaceArea = -1;
                    }
                    else
                    {
                        readerSurfaceArea = reader.GetDecimal(4);
                    }
                    if (reader.IsDBNull(5))
                    {
                        readerIndepYear = -1;
                    }
                    else
                    {
                        readerIndepYear = reader.GetInt16(5);
                    }
                    if (reader.IsDBNull(6))
                    {
                        readerPopulation = -1;
                    }
                    else
                    {
                        readerPopulation = reader.GetInt32(6);
                    }
                    if (reader.IsDBNull(7))
                    {
                        readerLifeExpectancy = -1;
                    }
                    else
                    {
                        readerLifeExpectancy = reader.GetDecimal(7);
                    }
                    if (reader.IsDBNull(8))
                    {
                        readerGNP = -1;
                    }
                    else
                    {
                        readerGNP = reader.GetDecimal(8);
                    }
                    if (reader.IsDBNull(9))
                    {
                        readerGNPOld = -1;
                    }
                    else
                    {
                        readerGNPOld = reader.GetDecimal(9);
                    }
                    if (reader.IsDBNull(10))
                    {
                        readerLocalName = "";
                    }
                    else
                    {
                        readerLocalName = reader.GetString(10);
                    }
                    if (reader.IsDBNull(11))
                    {
                        readerGovernmentForm = "";
                    }
                    else
                    {
                        readerGovernmentForm = reader.GetString(11);
                    }
                    if (reader.IsDBNull(12))
                    {
                        readerHeadOfState = "";
                    }
                    else
                    {
                        readerHeadOfState = reader.GetString(12);
                    }
                    if (reader.IsDBNull(13))
                    {
                        readerCapital = -1;
                    }
                    else
                    {
                        readerCapital = reader.GetInt32(13);
                    }
                    if (reader.IsDBNull(14))
                    {
                        readerCode2 = "";
                    }
                    else
                    {
                        readerCode2 = reader.GetString(14);
                    }
                    countries.Add(new Country(readerCode, readerName, readerContinent,
                                              readerRegion, readerSurfaceArea, readerIndepYear,
                                              readerPopulation, readerLifeExpectancy, readerGNP,
                                              readerGNPOld, readerLocalName, readerGovernmentForm,
                                              readerHeadOfState, readerCapital, readerCode2));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }*/
            
            #endregion
            Console.WriteLine("Time of operation : {0} ", stopwatch.Elapsed);

            sqlConnection1.Close();
            Console.ReadKey();
        }
        static void TestQuery(SqlConnection sqlConnection1, SqlCommand cmd, string query)
        {
            Stopwatch queryTime = new Stopwatch();
            SqlDataReader reader;
            queryTime.Start();
            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlConnection1;
            reader = cmd.ExecuteReader();
            queryTime.Stop();
            if (reader.HasRows)
            {
                Console.WriteLine("Query: {0} ",query);
                Console.WriteLine("Executed in: {0} \n", queryTime.Elapsed);   
            }
            reader.Close();

        }
    }
}
