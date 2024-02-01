using TripOTAExam.Models;

namespace TripOTAExam
{
    public class Backstage : IUpdateItem
    {
        private readonly Item _item;

        public Backstage(Item item)
        {
            _item = item;
        }

        public void UpdateItem()
        {
            if (_item.Quality < 50)
            {
                _item.Quality += 1;
            }

            if (_item.SellIn <= 10 && _item.Quality < 50)
            {
                _item.Quality += 1;
            }

            if (_item.SellIn <= 5 && _item.Quality < 50)
            {
                _item.Quality += 1;
            }

            if (_item.SellIn < 0)
            {
                _item.Quality = 0;
            }
        }
    }
}
