﻿// File Created 19-04-24
// Mattias Viklund


namespace House
{
    class Certificate
    {
        public readonly Building Property;
        public Owner Owner;
        public bool Owned;

        public Certificate(Building property)
        { 
            this.Property = property;
            this.Owned = false;

        }

        public void SellCertificate()
        {
            this.Owner = null;
            this.Owned = false;

        }

        public void TransferCertificate(Owner newOwner)
        {
            this.Owner = newOwner;
            this.Owned = true;

        }
    }
}
