using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class EqualityTest
    {
        public string Name { get; set; }

        public bool Equals(EqualityTest other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || other.Name == Name);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as EqualityTest);
        }

        public override int GetHashCode()
        {
            return (Name != null ? Name.GetHashCode() : 0);
        }

        public static bool operator ==(EqualityTest left, EqualityTest right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EqualityTest left, EqualityTest right)
        {
            return !Equals(left, right);
        }
    }
}
