using System.Collections.Generic;

namespace HMSSchedulingAPI.model
{
    public class ItemList
    {

        public ItemList() => itemDatas = new HashSet<ItemData>();


        public int Id { get; set; }
        public string  Name { get; set; }
        public virtual ICollection<ItemData> itemDatas { get; set; }
    }
}