using Nancy;
using Nancy.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serverhttp
{
   public class PersonModule:NancyModule
    {

        private static List<Person> Peoples = new List<Person>()
        {
            new Person()
            {
                Id=1,
                Name="benoit",
                Tel=new List<string>()
                {
                    "45564456",
                    "ddfdfdsf"
                },
                Adress=new Adress()
                {
                    Id=1,
                    City="gent",
                    PostCode="8889",
                    Street="noord"

                }
            },
            new Person()
            {
                Id=2,
                Name="ilse",
                Tel=new List<string>()
                {
                    "45564456",
                    "ddfdfdsf"
                },
                Adress=new Adress()
                {
                    Id=2,
                    City="gent",
                    PostCode="8889",
                    Street="noord"

                }
            }


        };

        public PersonModule()
        {
            Post["/{id}"] = parameters => Peoples[parameters.id ];
            Get["/"] = parameters =>
            {
                var model = this.Bind<Person>();
                Peoples.Add(model);
                return Peoples.Count.ToString();
            };
        }

    }
}
