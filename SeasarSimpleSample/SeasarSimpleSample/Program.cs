using System;
using System.Collections.Generic;
using Seasar.Framework.Container;
using Seasar.Framework.Container.Factory;

namespace SeasarSimpleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string PATH = "User.dicon";
            IS2Container container = S2ContainerFactory.Create(PATH);
            IUserDao userDao = (IUserDao)container.GetComponent(typeof(IUserDao));

            Console.WriteLine("List of all users: ");
            IList<UserDto> list = userDao.GetAll();
            foreach (UserDto usr in list)
            {
                Console.Write(usr.Id + " ");
                Console.Write(usr.Name + " ");
                Console.WriteLine(usr.Age);
            }

            Console.WriteLine("Get user info by Id = 1");
            UserDto user = userDao.GetData(1);
            Console.Write(user.Id + " ");
            Console.Write(user.Name + " ");
            Console.WriteLine(user.Age);

            Console.WriteLine("Get user info by name = 'B' and age = 8");
            IList<UserDto> userList = userDao.GetUsersByNameAndAge("B", 8);
            foreach (UserDto usr in userList)
            {
                Console.Write(usr.Id + " ");
                Console.Write(usr.Name + " ");
                Console.WriteLine(usr.Age);
            }

            Console.ReadLine();
        }
    }
}
