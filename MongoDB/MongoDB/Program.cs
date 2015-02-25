using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.GridFS;
using MongoDB.Driver.Linq;
using System.Diagnostics;

namespace MongoDB
{


    class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();


            var connectionString = "mongodb://localhost";
            var mongoClient = new MongoClient(connectionString);
            var mongoServer = mongoClient.GetServer();
            var databaseName = "BigWorld";

            var db = mongoServer.GetDatabase(databaseName);
            /// Get a reference to the "players" collection object from the Mongo database object

            //TestQuery<CountryTwo>(db, "countryTwo");
            TestQuery<City>(db, "dbo.[Query]");
            TestQuery<City>(db, "dbo.[Query]");
            TestQuery<City>(db, "dbo.[Query]");
            TestQuery<City>(db, "dbo.[Query]");
            TestQuery<City>(db, "dbo.[Query]");
           
            //TestQuery<Country>(db, "country");
            //TestQuery<CountryLanguage>(db, "countrylanguage");



            stopwatch.Stop();

            int count = 0;
            int num = 1;


            #region MyRegion
            //foreach (var found in query)
            //{
            //    Console.WriteLine("RECORD NO. " + num + "\n");
            //    Console.WriteLine(" Code: {0} \n Name: {1} \n Continent: {2} \n Region: {3} " +
            //                     "\n SurfaceArea: {4} \n Indep Year: {5} \n Population: {6} " +
            //                     "\n LifeExpectancy: {7} \n GNP: {8} \n GNPOld: {9} " +
            //                     "\n LocalName: {10} \n GovernmentForm: {11} \n HeadofState: {12}" +
            //                     "\n Capital: {13} \n Code2 {14} \n RowID {15} \n",
            //                     found.Code, found.Name, found.Continent,
            //                     found.Region, found.SurfaceArea, found.IndepYear,
            //                     found.Population, found.LifeExpectancy, found.GNP,
            //                     found.GNPOld, found.LocalName, found.GovernmentForm,
            //                     found.HeadOfState, found.Capital, found.Code2, found.RowID);

            //    count++;
            //    num++;
            //}


            //Console.WriteLine("\n " + count + " records have been processed "); 
            #endregion

            Console.WriteLine(" \nProgram  Time: {0}", stopwatch.Elapsed);
            Console.ReadLine();
        }
        static void TestQuery<T>(MongoDatabase db, string name)
        {
            Stopwatch queryTime = new Stopwatch();
            queryTime.Start();
            MongoCollection collection = db.GetCollection<T>(name);
            IQueryable<T> query = collection.AsQueryable<T>().Select(e => e);
            queryTime.Stop();
            if (query.LongCount() != 0)
            {
                var i = query.Expression.ToString().IndexOf("[");
                Console.WriteLine("Query: {0}",query.Expression.ToString().Substring(i));
                Console.WriteLine("Time of query : {0}\n", queryTime.Elapsed);
            }
        }

    }
}