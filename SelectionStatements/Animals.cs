using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    public class Animals // This is the base type of all Animals.
    {
        public string? Name;
        public DateTime Born;
        public byte legs;
    }

    class Cat : Animals // This is a subtype of animal.
    {
        public bool IsDomestic;
    }

    class Spider : Animals // This is another subtype of animals.
    {
        public bool IsPoisonous;
    }
}
