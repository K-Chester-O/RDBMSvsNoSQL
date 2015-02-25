using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace MongoDB
{
    [BsonIgnoreExtraElements]
    public class Country : MongoEntity
    {
       
        [BsonElement("Code")]
        public String Code { get; set; }

        [BsonElement("Name")]
        public String Name { get; set; }

        [BsonElement("Continent")]
        public String Continent { get; set; }

        [BsonElement("Region")]
        public String Region { get; set; }

        [BsonElement("SurfaceArea")]
        public String SurfaceArea { get; set; }

        [BsonElement("IndepYear")]
        [BsonSerializer(typeof(StringOrInt32Serializer))]
        public String IndepYear { get; set; }

        [BsonElement("Population")]
        public Int32 Population { get; set; }

        [BsonElement("LifeExpectancy")]
        public String LifeExpectancy { get; set; }

        [BsonElement("GNP")]
        public String GNP { get; set; }

        [BsonElement("GNPOld")]
        public String GNPOld { get; set; }

        [BsonElement("LocalName")]
        public String LocalName { get; set; }

        [BsonElement("GovernmentForm")]
        public String GovernmentForm { get; set; }

        [BsonElement("HeadOfState")]
        public String HeadOfState { get; set; }

        [BsonElement("Capital")]
        public Int32 Capital { get; set; }

        [BsonElement("Code2")]
        public String Code2 { get; set; }

        [BsonElement("RowID")]
        public Int64 RowID { get; set; }

    }
}
