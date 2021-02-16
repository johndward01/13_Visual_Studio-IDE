using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IDE_Parts_Demo
{
    class Program
    {
        static void Main(string[] args)
        {//***********ALL KEYBOARD SHORTCUTS ARE FOR WINDOWS**************


            //      Solution Explorer
            // --> View > Pads > Solution {Windows}
            // --> View > Solution Explorer (keyboard shortcut = Ctrl + Alt + L) 
            //TODO -- Close Solution Explorer and bring it back up

            //      Dependencies/NuGet Packages
            // --> right click Dependencies/Packages and click Manage NuGet Packages
            //TODO -- Add Dapper NuGet Package 

            //      Debugger
            // --> To start debugging any application, always ensure that the configuration is set to Debug.
            // --> Click Debug > Start Debugging (keyboard shortcut = F5)

            //To see all of the Debug windows available you must be currently debugging (put some breakpoints on the code below and run)
            //Click DEBUG > WINDOWS > ******(you will only see a few windows if you're not currently debugging)*******

            //TODO -- Show all the breakpoints Debug > Windows > Breakpoints
            //TODO -- Show the local variables Debug > Windows > Locals
            //TODO -- Show the watch1 window Debug > Windows > Watch > Watch1
            //TODO -- Show the quickwatch window Right-Click on the variable > choose QuickWatch (keyboard shortcut = shift + F9)
            //TODO -- Show the output window Debug > Windows > Output
            //TODO -- Show the callstack Debug > Windows > Callstack ( set a breakpoint at Line 43 and press Step Into (keyboard shortcut = F11) )

            //View the source code for a function on the call stack
            //TODO -- In the Call Stack Window Right-Click the function > Go To Source Code

            //Run to a specific function from the Call Stack window
            //TODO -- In the Call Stack Window Right-Click the function > Run To Cursor


            ApplicationEntry();

            //      Breaking on Exceptions
            // --> Debug > Windows > Exception Settings
        }

        public static void ApplicationEntry()
        {
            var userResponse = "";

            do
            {
                GreetUser();//
                var userInformation = GetUserInfo();//This is the list of info
                Console.WriteLine("Please make sure all the information is correct then type yes and press enter");
                foreach (var item in userInformation)
                {
                    Console.WriteLine($"Email: {userInformation[0]}\n" +
                                      $"Phone Number: {userInformation[1]}\n" +
                                      $"Birthday: {userInformation[2]}\n");
                }
                userResponse = GetUserResponse();
            } while (userResponse != "yes");
        }

        public static string GetUserResponse()
        {
            Console.WriteLine("Please type yes or no");
            var userInput = Console.ReadLine().ToLower();
            return userInput;
        }

        public static List<string> GetUserInfo()
        {
            Console.WriteLine("Please enter your email address");
            var email = Console.ReadLine();
            Console.WriteLine();//empty Console.WriteLine is here for an empty line making it easier to read

            Console.WriteLine("Please enter your phone number");
            var phoneNumber = Console.ReadLine();
            Console.WriteLine();//blank Console.WriteLine creates an empty line making it easier to read

            Console.WriteLine("Please enter your Date of Birth");
            var dateOfBirth = Console.ReadLine();
            Console.WriteLine();//empty Console.WriteLine makes an empty line making it easier to read

            List<string> information = new List<string>();//I created a list to store the information we collected above
            information.Add(email);
            information.Add(phoneNumber);
            information.Add(dateOfBirth);

            return information;//we are returning that list 
        }

        public static void GreetUser()
        {
            Console.WriteLine("Please enter your first name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name");
            var lastName = Console.ReadLine();

            Console.WriteLine($"Hello {firstName} {lastName}, welcome to the IDE Parts: Visual Studio Demo!");
        }
    }
}
