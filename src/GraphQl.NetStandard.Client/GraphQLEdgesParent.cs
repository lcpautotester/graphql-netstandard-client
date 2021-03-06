﻿using System.Collections.Generic;

namespace GraphQl.NetStandard.Client
{
    /// <summary>
    /// A class that correlates to a GraphQl response JSON collection object
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GraphQLEdgesParent<T>
    {
        public int? TotalCount { get; set; }
        public GraphQlPageInfo PageInfo { get; set; }
        public List<T> Edges { get; set; }
    }
}
