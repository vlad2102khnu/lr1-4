using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class SampleData
    {
        public static void Initialize(MobileContext context)
        {
            if (!context.Phones.Any())
            {
                context.Phones.AddRange(
                    new Phone
                    {
                        Name = "iPhone X",
                        Company = "Apple",
                        Price = 15228
                    },
                    new Phone
                    {
                        Name = "Сяоми",
                        Company = "Салями",
                        Price = 12000
                    },
                    new Phone
                    {
                        Name = "ГУГЛ АЙФОН",
                        Company = "Google",
                        Price = 20000
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
