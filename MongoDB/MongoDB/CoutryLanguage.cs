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
    public class CountryLanguage : MongoEntity
    {

        [BsonElement("CountryCode")]
        public String CountryCode { get; set; }

        [BsonElement("Language")]
        public String Language { get; set; }

        [BsonElement("IsOfficial")]
        public String IsOfficial { get; set; }

        [BsonElement("Percentage")]
        public float Percentage { get; set; }

        [BsonElement("RowID")]
        public String RowID { get; set; }

    }
}
