using AppError;
using Model;
namespace Model
{
    public class Trip
    {
        private static int _idCounter = 0;
        private int _id;
        private string _title;
        private string _description;
        private DateTime _startDate;
        private DateTime _endDate;
        private decimal _price;
        private int _capacity;
        private bool _isCancelled;
        public List<Booking> Bookings { get; private set; } = new List<Booking>();

        public int Id { get; private set; }
        public string Title
        {
            get => _title;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 10 && value.Length <= 50)
                {
                    _title = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.TitleError);
                }
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length >= 10 && value.Length <= 50)
                {
                    _description = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.DescriptionError);
                }
            }
        }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.PriceError);
                }
            }
        }

        public int Capacity
        {
            get => _capacity;
            set
            {
                if (value >= 0 && value <= 30)
                {
                    _capacity = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.TripCapacityFull);
                }
            }
        }

        public bool IsCancelled { get; set; }

        public Trip(string title, string description, DateTime startDate, DateTime endDate, decimal price, int capacity)
        {
            Id = _idCounter++;
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            Capacity = capacity;
            IsCancelled = false;
        }

        public override string ToString()
        {
            return $"id: {Id}\nTitle: {Title}\nDescription: {Description}\nStartDate: {StartDate}\nEndDate: {EndDate}\nPrice: {Price}\nCapacity: {Capacity}\nIsCancelled: {IsCancelled}";
        }
    }
}