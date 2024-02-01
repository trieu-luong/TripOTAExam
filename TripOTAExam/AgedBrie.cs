using TripOTAExam.Models;

namespace TripOTAExam
{
    public class AgedBrie : IUpdateItem
    {
        private readonly Item _item;

        public AgedBrie(Item item)
        {
            _item = item;
        }

        public void UpdateItem()
        {
            if (_item.SellIn < 0 && _item.Quality < 50)
            {
                _item.Quality += 1;
            }

            if (_item.Quality < 50)
            {
                _item.Quality += 1;
            }
        }
    }
}
