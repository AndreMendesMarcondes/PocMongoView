using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace MongoDBQuery
{
    public class Status
    {
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Category
    {
        public int id { get; set; }
        public string code { get; set; }
        public string description { get; set; }
    }

    public class Language
    {
        public int id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
    }

    public class Button
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class Template
    {
        public string type { get; set; }
        public string text { get; set; }
        public List<Button> buttons { get; set; }
    }

    public class TemplateSettings
    {
        [BsonId]
        public string id { get; set; }
        public string wa_id { get; set; }
        public Status status { get; set; }
        public Category category { get; set; }
        public Language language { get; set; }
        public string name { get; set; }
        public List<Template> components { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
