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
    public class City : MongoEntity
    {

        [BsonElement("ID")]
        public String ID { get; set; }

        [BsonElement("Name")]
        public String Name { get; set; }

        [BsonElement("CountryCode")]
        public String CountryCode { get; set; }

        [BsonElement("District")]
        public String District { get; set; }

        [BsonElement("Population")]
        public String Population { get; set; }

        [BsonElement("RowID")]
        public String RowID { get; set; }

    }
}
