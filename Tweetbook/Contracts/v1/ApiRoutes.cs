﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Contracts.v1
{
    public static class ApiRoutes
    {
        public const string root = "api";
        public const string version = "v1";

        public const string Base = root + "/" + version;

        public static class Posts
        {
            public const string GetAll = Base + "/posts";
            public const string Update = Base + "/posts/{postId}";
            public const string Delete = Base + "/posts/{postId}";
            public const string Get = Base + "/posts/{postId}";
            public const string Create = Base + "/posts";
        }
    }
}
