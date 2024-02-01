using TripOTAExam.Models;

namespace TripOTAExam
{
    public class GildedRose
    {
        IList<Item> Items;
        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                UpdateQualityFactory(item);
            }
        }

        private void UpdateQualityFactory(Item item)
        {
            var action = GetUpdateAction(item);
            if (action != null)
            {
                action();
            }

            if (item.Name != "Sulfuras, Hand of Ragnaros")
            {
                item.SellIn -= 1;
            }
        }

        public Action GetUpdateAction(Item item)
        {
            var actions = new Dictionary<string, Action>();
            actions.Add("Aged Brie", () => new AgedBrie(item).UpdateItem());
            actions.Add("Backstage passes to a TAFKAL80ETC concert", () => new Backstage(item).UpdateItem());
            actions.Add("Sulfuras, Hand of Ragnaros", () => new Sulfuras(item).UpdateItem());
            actions.Add("Conjured", () => new Conjured(item).UpdateItem());

            var action = actions.FirstOrDefault(x => x.Key == item.Name).Value;
            if (action == null)
            {
                action = () => new Normal(item).UpdateItem();
            }

            return action;

        }

    }
}
