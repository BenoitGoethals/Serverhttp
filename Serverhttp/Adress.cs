using System;
using System.Collections.Generic;

namespace Serverhttp
{
    public class Adress : IEquatable<Adress>
    {

        public int Id { get; set; }
        public  string Street { get; set; }

        public string City { get; set; }

        public string PostCode { get; set; }

        public Adress(int id, string street, string city, string postCode)
        {
            Id = id;
            Street = street;
            City = city;
            PostCode = postCode;
        }

        public Adress()
        {

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Adress);
        }

        public bool Equals(Adress other)
        {
            return other != null &&
                   Id == other.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }

        public static bool operator ==(Adress left, Adress right)
        {
            return EqualityComparer<Adress>.Default.Equals(left, right);
        }

        public static bool operator !=(Adress left, Adress right)
        {
            return !(left == right);
        }
    }
}