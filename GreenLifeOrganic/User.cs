using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenLifeOrganic
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; } 
        public string FullName { get; set; }
        public string Role { get; set; }

        
        public virtual void DisplayDashboard()
        {
            Console.WriteLine("Welcome to GreenLife Organic Store");
        }
    }

   
    public class Admin : User
    {
       
        public void GenerateReport(string reportType)
        {
            // Logic for generating reports
        }
    }

    
    public class Customer : User
    {
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

     
        public List<int> ShoppingCartProductIDs { get; set; } = new List<int>();

        public void AddToCart(int productId)
        {
            ShoppingCartProductIDs.Add(productId);
        }
    }
}
