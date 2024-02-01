using TripOTAExam.Models;

namespace TripOTAExam
{
    public class Sulfuras : IUpdateItem
    {
        private readonly Item _item;

        public Sulfuras(Item item)
        {
            _item = item;
        }

        public void UpdateItem()
        {
            return;
        }
    }
}
