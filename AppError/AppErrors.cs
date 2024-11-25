namespace AppError
{
    public abstract class AppErrors
    {
        public static string InvalidNameFormat => "Invalid format. Please enter a valid address.";
        public static string InvalidPasswordFormat => "Password must be at least 8 characters long, contain at least one uppercase letter, and contain at least one special character (@ or #).";
        public static string UnauthorizedAccess => "You do not have permission to access this function.";
        public static string TripNotFound => "Trip with the specified ID was not found.";
        public static string BookingNotFound => "Booking with the specified ID was not found.";
        public static string TripAlreadyBooked => "You have already booked this trip.";
        public static string TripCapacityFull => "This trip is fully booked and cannot accept more bookings.";
        public static string UserAlreadyExists => "A user with the specified email already exists.";
        public static string InvalidLoginCredentials => "Invalid username or password.";
        public static string GenericError => "An unexpected error occurred. Please try again later.";
        public static string IdError => "Error in ID: ID should not start from zero.";
        public static string TitleError => "Error in title: Title length should be between 5 and 10 characters.";
        public static string DescriptionError => "Error in description: Description length should be between 5 and 10 characters.";
        public static string DateError => "Error in date: Invalid date format.";
        public static string PriceError => "Error in price: Please enter a valid price.";
        public static string ExitingError => "Exiting the application. Goodbye!";
        public static string InvalidError => "Invalid option. Please try again.";
        public static string Invalid => "Invalid credentials.";
        public static string RepositoryInitializationError => "Repositories are not initialized. Please ensure proper setup.";
        public static string EmployeeFond => "Employee not found or is not an employee.";
        public static string NoTrip => "No trips scheduled for the current month.";
    }
}
