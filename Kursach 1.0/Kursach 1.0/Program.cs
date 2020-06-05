using System;

namespace Kursach_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            System evt = new System();
            while (true)
            {
                    System.register();
                    Console.WriteLine("You're now logged as " + Person.Registered[Person.CurrentUser].Name);
                    if (!Person.Registered[Person.CurrentUser].Check)
                    {
                        evt.NewMsg += Person.Registered[Person.CurrentUser].NewMsgHandler;
                    }
                    bool ex = true;
                    Console.WriteLine($"You have " + Person.Registered[Person.CurrentUser].Msg + " new invitations");
                while (ex)
                {
                    try
                    {
                        Console.WriteLine("[1] - Show your friendlist");
                        Console.WriteLine("[2] - Show pending requests");
                        Console.WriteLine("[3] - Add new friends");
                        Console.WriteLine("[0] - Exit");
                        string ask = Console.ReadLine();
                        switch (ask)
                        {
                            case "1":
                                Person.Registered[Person.CurrentUser].ShowFriends();
                                break;
                            case "2":
                                Person.Registered[Person.CurrentUser].ShowRequests();
                                break;
                            case "3":
                                Console.WriteLine("Enter his name:"); string name = Console.ReadLine();
                                Person.Registered[Person.CurrentUser].Invite(name, evt);
                                break;
                            case "0":
                                ex = false;
                                break;
                            default:
                                throw new Exception("You entered wrong number.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }
        }
    }
}
