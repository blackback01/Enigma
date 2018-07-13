using System;

namespace PowerCrypt
{
    public class Rot13 : Substitution
    {
        public Rot13()
        {
            iKey = 13;
        }
    }
}
