using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;



namespace MongoDB
{
    public interface IMongoEntity
    {
        Object Id { get; set; }
    }
}
