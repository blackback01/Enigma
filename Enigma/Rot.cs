using System;

namespace PowerCrypt
{
    public class Rot : Substitution
    {
        public Rot(int key)
        {
            iKey = key;
        }
    }
}
