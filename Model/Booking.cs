using AppError;
using System;
using System.Globalization;

namespace Model
{
    public class Booking
    {
        private static int _idCounter = 0; // عداد تلقائي لزيادة المعرفات
        private int _id;
        private int _tripId;
        private int _userId;
        private DateTime _bookingDate;
        private bool _isCancelled;

        public Booking(int tripId, int userId, DateTime bookingDate, bool isCancelled)
        {
            Id=_idCounter++;
            TripId = tripId;
            UserId = userId;
            BookingDate = bookingDate;
            IsCancelled = isCancelled;
        }

        public int Id
        {
            get => _id;
            private set
            {
                if (value >= 0)
                {
                    _id = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.IdError);
                }
            }
        }

        public int TripId
        {
            get => _tripId;
             set
            {
                if (value >= 0)
                {
                    _tripId = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.IdError);
                }
            }
        }

        public int UserId
        {
            get => _userId;
             set
            {
                if (value >= 0)
                {
                    _userId = value;
                }
                else
                {
                    throw new ArgumentException(AppErrors.IdError);
                }
            }
        }

        public DateTime BookingDate
        {
            get => _bookingDate;
             set
            {
                // السماح بتنسيق التاريخ كما هو بدون الحاجة لتحويله
                string[] allowedFormats = { "yyyy-MM-dd", "MM/dd/yyyy", "dd-MM-yyyy", "dd/MM/yyyy", "yyyy-MM-dd HH:mm:ss", "MM/dd/yyyy HH:mm:ss" };

                // استخدم TryParseExact فقط إذا كانت القيمة من نوع string
                if (DateTime.TryParseExact(value.ToString("yyyy-MM-dd"), allowedFormats, null, DateTimeStyles.None, out DateTime parsedDate))
                {
                    _bookingDate = parsedDate;
                }
                else
                {
                    throw new ArgumentException(AppErrors.DateError);
                }
            }
        }

        public bool IsCancelled
        {
            get => _isCancelled;
            set => _isCancelled = value;
        }

        

     

        public override string ToString()
        {
            return $"id: {Id}\nTripId: {TripId}\nUserId: {UserId}\nBookingDate: {BookingDate}\nIsCancelled: {IsCancelled}";
        }
    }
}