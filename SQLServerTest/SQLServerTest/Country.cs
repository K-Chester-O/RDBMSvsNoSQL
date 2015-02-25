using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServerTest
{
    class Country
    {
        public String Code
        { get; set; }
        public String Name
        { get; set; }
        public String Continent
        { get; set; }
        public String Region
        { get; set; }
        public Decimal SurfaceArea
        { get; set; }
        public Int16 IndepYear
        { get; set; }
        public Int32 Population
        { get; set; }
        public Nullable<Decimal> LifeExpectancy
        { get; set; }
        public Nullable<Decimal> GNP
        { get; set; }
        public Nullable<Decimal> GNPOld
        { get; set; }
        public String LocalName
        { get; set; }
        public String GovernmentForm
        { get; set; }
        public String HeadOfState
        { get; set; }
        public Nullable<Int32> Capital
        { get; set; }
        public String Code2
        { get; set; }
        public Country(String Code, String Name, String Continent, String Region, Decimal SurfaceArea, Int16 IndepYear, Int32 Population, Decimal LifeExpectancy, Decimal GNP, Decimal GNPOld, String LocalName, String GovernmentForm, String HeadOfState, Int32 Capital, String Code2)
        {
            this.Code = Code;
            this.Name = Name;
            this.Continent = Continent;
            this.Region = Region;
            this.SurfaceArea = SurfaceArea;
            this.IndepYear = IndepYear;
            this.Population = Population;
            this.LifeExpectancy = LifeExpectancy;
            this.GNP = GNP;
            this.GNPOld = GNPOld;
            this.LocalName = LocalName;
            this.GovernmentForm = GovernmentForm;
            this.HeadOfState = HeadOfState;
            this.Capital = Capital;
            this.Code2 = Code2;

        }
    }
}
