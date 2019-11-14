using pi.domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Service.Pattern;
using crm_pi.pi.data.Infrastructure;

namespace pi.console
{
    class Program
    {
        static void Main(string[] args)
        {
            IDatabaseFactory Factory = new DatabaseFactory();
           IUnitOfWork Uok = new UnitOfWork(Factory);
            IService<Client> chService = new Service <Client> (Uok);
            Client ch = new Client() { 
                Email ="meriem@gmail.com",
                Password="123456789",
                UserName="Marion",
                Name="meriem",
                LastName="haddi",
                Adress="tunis",
                PhoneNumber=96567790
            };
            Client ch2 = new Client()
            {
                Email = "mer@gmail.com",
                Password = "123456789",
                UserName = "Marion",
                Name = "marion",
                LastName = "haddi",
                Adress = "tunis",
                PhoneNumber = 925282028
            };
            chService.Add(ch2);
            chService.Commit();
            chService.Dispose();
        }
    }
}
