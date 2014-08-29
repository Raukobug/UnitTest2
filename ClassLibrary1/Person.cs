using System;

namespace ClassLibrary1
{
    public class Person : IEquatable<Person>
    {
        private string _name;
        private double _age;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException();
                _name = value;
            }
        }

        public double Age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                throw new AgeException();
                }
            _age = value;
            }
        }

        public Person()
        {}

        public Person(string name)
        {
            Name = name;
        }

        public bool IsAdult()
        {
            return _age >= 18;
        }

        public bool Equals(Person other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return string.Equals(_name, other._name) && _age.Equals(other._age);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((_name != null ? _name.GetHashCode() : 0)*397) ^ _age.GetHashCode();
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Person) obj);
        }

        public static bool operator ==(Person left, Person right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Person left, Person right)
        {
            return !Equals(left, right);
        }
    }
}
