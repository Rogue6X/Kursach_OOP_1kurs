using System;
using System.Collections.Generic;

namespace Kursach_1._0
{
    public delegate void Notify();
    class System
    {
        static public List<string> Users = new List<string>();
        static public List<Person> Registered = new List<Person>();
        static public int currentuser;
        public event Notify NewMsg;
        static public int CurrentUser { get { return currentuser; } }
        public void UseEvent()
        {
            NewMsg?.Invoke();
        }
        static public void register()
        {
            while (true)
            {
                Console.WriteLine("Do you have an account here?(y/n)");
                string ans = Console.ReadLine();
                if (ans == "y")
                {
                    try
                    {
                        Console.WriteLine("Enter your name:"); string name = Console.ReadLine();
                        if (Users.Contains(name))
                        {
                            currentuser = Person.Users.IndexOf(name);
                            break;
                        }
                        else
                        {
                            throw new Exception("You aren't registered yet");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Enter your name to register:"); string name = Console.ReadLine();
                    Users.Add(name);
                    Registered.Add(new Person(name));
                    currentuser = Person.Users.IndexOf(name);
                    break;
                }
            }
        }
    }
}
