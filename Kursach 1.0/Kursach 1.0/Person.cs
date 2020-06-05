using System;
using System.Collections.Generic;

namespace Kursach_1._0
{
    class Person : System
    {
        private string username;
        private int newmessage = 0;
        private bool check = false;
        List<string> friends = new List<string>();
        List<string> requests = new List<string>();
        public Person(string name)
        {
            this.username = name;
        }
        public bool Check { get { return check; } }
        public string Name { get { return username; } }
        public int Msg { get { return newmessage; } }
        public void NewMsgHandler()
        {
            this.newmessage++;
        }
        public void ShowFriends()
        {
            Console.WriteLine("\n Your friendlist:\n");
            for (int i = 0; i < friends.Count; i++)
            {
                Console.WriteLine(friends[i]);
            }

        }
        public void ShowRequests()
        {
            Console.WriteLine("\n Your requests:\n");
            for (int i = 0; i < requests.Count; i++)
            {
                Console.WriteLine(requests[i]);
            }
            AcceptInvitations();
        }
        public void Invite(string name, System evt)
        {
            if (Users.Contains(name))
            {
                if (friends.Contains(name))
                {
                    Console.WriteLine("This person is already in your friendlist");
                }
                else
                {
                    Person.Registered[Person.Users.IndexOf(name)].requests.Add(username);
                    Console.WriteLine("You invited " + name + " to your friends");
                    evt.UseEvent();
                }
            }
            else
            {
                throw new Exception("This person doesn't exist in our system");
            }
            Console.WriteLine("\n");
        }
        void AcceptInvitations()
        {
            if (requests.Count != 0)
            {
                Console.WriteLine("Accept requests?(y/n)"); string ans = Console.ReadLine();
                if (ans == "y")
                {
                    for (int i = 0; i < requests.Count; i++)
                    {
                        this.friends.Add(requests[i]);
                    }
                    foreach (string j in requests)
                    {
                        Person.Registered[Person.Users.IndexOf(j)].friends.Add(username);
                    }
                    requests.RemoveRange(0, requests.Count);

                    Console.WriteLine("Accepted all requests");
                    newmessage = 0;
                }
                else
                {
                    Console.WriteLine("Okay.");
                }
            }
            else
            {
                throw new Exception("Your list is empty");
            }
        }
    }
}
