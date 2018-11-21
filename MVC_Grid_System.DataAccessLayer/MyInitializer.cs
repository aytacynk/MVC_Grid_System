using MVC_Grid_System.Entites;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Grid_System.DataAccessLayer
{
    public class MyInitializer : CreateDatabaseIfNotExists<DatabaseContex>
    {

        protected override void Seed(DatabaseContex context)
        {
            List<Country> CountryList = new List<Country>();

            for (int i = 0; i < 10; i++)
            {
                Country con = new Country()
                {
                    CountryName = FakeData.PlaceData.GetCountry(),
                };
                CountryList.Add(con);
                context.Countries.Add(con);
            }
            context.SaveChanges();

            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int deger = rnd.Next(0, 10);

                Personel per = new Personel()
                {
                    Ad = FakeData.NameData.GetFirstName(),
                    Soyad = FakeData.NameData.GetSurname(),
                    Yas = FakeData.NumberData.GetNumber(20, 90),
                    Country = CountryList[deger]
                };
                context.Personel.Add(per);
            }
            context.SaveChanges();
        }
    }
}
