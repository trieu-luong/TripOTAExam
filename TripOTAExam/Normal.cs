using TripOTAExam.Models;

namespace TripOTAExam
{
    public class Normal : IUpdateItem
    {
        private readonly Item _item;

        public Normal(Item item)
        {
            _item = item;
        }

        public void UpdateItem()
        {
            if (_item.Quality > 0)
            {
                _item.Quality -= 1;
            }

            if (_item.SellIn < 0 && _item.Quality > 0)
            {
                _item.Quality -= 1;
            }
        }
    }
}
