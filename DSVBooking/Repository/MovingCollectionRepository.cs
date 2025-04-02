using DSVBooking.Model;

namespace DSVBooking.Repository
{
    public class MovingCollectionRepository: IMovingRepository
    {
        private List<MovingBetween> _MovingBetween;

        public MovingCollectionRepository()
        {
            _MovingBetween = new List<MovingBetween>();
            
        }

     
        public void Add(MovingBetween MovingBetween)
        {
            _MovingBetween.Add(MovingBetween);
        }
        public List<MovingBetween> GetAll()
        {
            return _MovingBetween;
        }
    }
}
