﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace M220N.Models.Projections
{
    [BsonIgnoreExtraElements]
    public class ConfigInfo
    {
        public MongoClientSettings Settings { get; set; }
        public AuthInfo AuthInfo { get; set; }
        public int Ok { get; set; }
    }

    
    public class AuthInfo
    {
        public BsonArray AuthenticatedUsers { get; set; }
        public BsonArray AuthenticatedUserRoles { get; set; }
        public BsonArray AuthenticatedUserPrivileges { get; set; }
    }
}
