using System;
using ClassLibrary1.Entities;
using Data.Context;
using Data.Repositories;
using Data.UnitOfWork;
using Domain.Entites;

namespace ConsoleFramework
{
    public class Initialize
    {
        
        static void Main(string[] args)
        {
            using (var db = new CoreDbContext())
            {
                var uow = new UnitOfWork(db){};
                var userRepository = new UserRepository(uow);

                var user = new User()
                {
                    FName = "Lesha",
                    LName = "Alex",
                    Phone = "88005553535",
                    Email = "LexaPet@gmail.com",
                    Country = new Country() 
                    {
                       CountryName = "Japan"
                    },
                    Sity = new Sity() 
                    {
                        SityName = "Konoha"                    
                    },
                    Title = Title.Mr
                };

                userRepository.Create(user);
                uow.SaveChanges();
            }
            
            Console.WriteLine("Does it work?");
        }
    }
}
