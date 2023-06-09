﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdExercise
{
    public class Duck : Bird, IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo(Duck other)
        {
            if (this.Size > other.Size)
                return 1;
            else if (this.Size < other.Size)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return Size + "-centymetrowa kaczka " + Kind.ToString();
        }
        string Name
        {
            get { return ToString(); }
        }
        public enum KindOfDuck
        {
            Decoy,
            Muscovy,
            Mallard,
        }
        public class DuckComparerBySize : IComparer<Duck>
        {
            public int Compare(Duck x, Duck y)
            {
                if (x.Size < y.Size)
                    return -1;
                if (x.Size > y.Size)
                    return 1;
                return 0;
            }
        }

        public class DuckComparerByKind : IComparer<Duck>
        {
            public int Compare(Duck x, Duck y)
            {
                if (x.Kind < y.Kind)
                    return -1;
                if (x.Kind > y.Kind)
                    return 1;
                return 0;
            }
        }
    }
}
