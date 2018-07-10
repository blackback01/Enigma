using System;

namespace Enigma
{
    public class Rot : Substitution
    {
        public Rot(int key)
        {
            iKey = key;
        }
    }
}
