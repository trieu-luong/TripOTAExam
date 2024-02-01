using TripOTAExam.Models;

namespace TripOTAExam
{
    public class Conjured : IUpdateItem
    {
        private readonly Item _item;

        public Conjured(Item item)
        {
            _item = item;
        }

        public void UpdateItem()
        {
            if (_item.Quality > 0)
            {
                _item.Quality -= 2;
            }

            if (_item.SellIn < 0 && _item.Quality > 0)
            {
                _item.Quality -= 2;
            }
        }
    }
}
