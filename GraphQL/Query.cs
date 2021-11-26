using System.Linq;
using HMSSchedulingAPI.Data;
using HMSSchedulingAPI.model;
using HotChocolate;

namespace HMSSchedulingAPI.GraphQL
{
    public class Query
    {
        
        public IQueryable<ItemList> GetList([Service] ApiDbContext context ) 
        {
               return  context.Lists;
        }

         public IQueryable<ItemData> GetDatas([Service] ApiDbContext context ) 
        {
               return  context.Items;
        }
    }
}