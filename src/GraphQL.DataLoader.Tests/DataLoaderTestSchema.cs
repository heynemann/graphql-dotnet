using System;
using GraphQL.DataLoader.Tests.Types;
using GraphQL.Types;

namespace GraphQL.DataLoader.Tests
{
    public class DataLoaderTestSchema : Schema
    {
        public DataLoaderTestSchema(IServiceProvider services, QueryType query, SubscriptionType subscriptionType)
            : base(services)
        {
            Query = query;
            Subscription = subscriptionType;
        }
    }
}
