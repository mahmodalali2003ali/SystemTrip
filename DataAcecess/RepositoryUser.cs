using DataAcecess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Model
{
    

    public class RepositoryUser : IRepository<User>
    {
        private List<User> _users = new List<User>();
        public List<User> Entities => _users;

      
        public void CreateOne(User user) => _users.Add(user);

 
        public void DeleteOne(int id) => _users.RemoveAll(u => u.id == id);

        
        public void GetAlll() => _users.ForEach(u => Console.WriteLine(u.ToString()));

       
        public User GetOne(int id) => _users.FirstOrDefault(u => u.id == id);

       
        public void UpdateOne(int id, User user)
        {
            var existingUser = GetOne(id);
            if (existingUser != null)
            {
                existingUser.UserName = user.UserName;
                existingUser.Password = user.Password;
               
            }
        }

        
        public int GetEmployeeCount() => _users.Count(u => u.Role == UserRole.Employee);

        
        public int GetDepartedUserCount() => _users.Count(u => u.HasDeparted);

       
        public int GetUserCount() => _users.Count(u => u.Role == UserRole.Tourist);     

       
        public void DisplayAllEmployees()
        {
            var employees = _users.Where(u => u.Role == UserRole.Employee).ToList();
            if (employees.Count == 0)
            {
                Console.WriteLine("There are no registered employees.");
                return;
            }

            Console.WriteLine("Details of all employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine("------------------------- Employees  ---------------------");
                Console.WriteLine(employee.ToString());
            }
        }

     


    }
}
