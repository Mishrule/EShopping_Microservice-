using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Catelog.Core.Entities
{
    public class ProductBrand:BaseEntity
    {
        [BsonElement("Name")]
        public string Name { get; set; }
    }
}
