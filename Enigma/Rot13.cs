using System;

namespace Enigma
{
    public class Rot13 : Substitution
    {
        public Rot13()
        {
            iKey = 13;
        }
    }
}
