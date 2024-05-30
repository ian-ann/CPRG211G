using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
   class Prompt
  {
    
    int personid;
    string first_name;
    string last_name;
    string favcolor;
    int age;
    public void Get_data()
    {
      Console.WriteLine("Enter Person iD: ");
      personid=Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Enter First name: ");
      first_name =Console.ReadLine();

      Console.WriteLine("Enter Last Name: ");
      last_name =Console.ReadLine();

      Console.WriteLine("Enter Fav color: ");
      favcolor =Console.ReadLine();

      Console.WriteLine("Enter Person Age: ");
      age =Convert.ToInt32(Console.ReadLine());
    }
    public void Display_data()
    {
      Console.WriteLine(age); 
      Console.WriteLine(first_name);
      Console.WriteLine(last_name);
      Console.WriteLine(favcolor); 
      Console.WriteLine(age);
    }
  }
}
