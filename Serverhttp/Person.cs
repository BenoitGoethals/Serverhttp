using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serverhttp
{
 public    class Person : IEquatable<Person>

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<String> Tel { get; set; }

        public Adress Adress { get; set; }

        public Person(int id, string name, List<string> tel, Adress adress)
        {
            Id = id;
            Name = name;
            Tel = tel;
            Adress = adress;
        }

        public Person()
        {
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Person);
        }

        public bool Equals(Person other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(Person left, Person right)
        {
            return EqualityComparer<Person>.Default.Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !(left == right);
        }
    }
}
