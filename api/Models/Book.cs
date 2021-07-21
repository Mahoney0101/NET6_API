﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


namespace Api.Models
{
    public class Book
    {
        [BsonId]
       // [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Name")]
        public string BookName { get; set; }

        public string Category { get; set; }

        public string Author { get; set; }
    }
}
