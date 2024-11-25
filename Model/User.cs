using AppError;
using System;

namespace Model
{
    public enum UserRole { Admin, Employee, Tourist }

    public class User
    {
        private static int _idCounter = 0; // عداد تلقائي لزيادة المعرفات
        private int _id;
        private string _userName;
        private string _password;
        private UserRole _role;
        private bool _hasDeparted; // خاصية لتتبع ما إذا كان المستخدم قد غادر

        public User(string userName, string password, UserRole role)
        {
            this.id = _idCounter++;
            UserName = userName;
            Password = password;
            Role = role;
            HasDeparted = false; // بشكل افتراضي، المستخدم ليس مغادراً
        }

        public int id
        {
            get => _id;
            private set
            {
                if (value >= 0 && value is int)
                {
                    _id = value;
                }
                else
                {
                    Console.WriteLine(AppErrors.IdError);
                }
            }
        }

        public string UserName
        {
            get => _userName;
            set
            {
                if (value.Length >= 2 && value is string)
                {
                    _userName = value;
                }
                else
                {
                    Console.WriteLine(AppErrors.InvalidNameFormat);
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (value.Length >= 8 && value is string)
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine(AppErrors.InvalidPasswordFormat);
                }
            }
        }

        public UserRole Role
        {
            get => _role;
             set => _role = value;
        }

        public bool HasDeparted
        {
            get => _hasDeparted;
            set => _hasDeparted = value; // إمكانية تغيير الحالة إذا غادر المستخدم
        }

        public override string ToString()
        {
            return $"id :{id}\nName : {UserName}\nPassword : {Password}\nRole : {Role}\nHas Departed : {HasDeparted}";
        }
    }
}
