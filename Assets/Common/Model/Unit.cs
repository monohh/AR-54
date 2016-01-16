using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AR_54.Common.Model
{
    public abstract class Unit
    {

        //Constructor with identity and Starting HP (which sets maxHP too)
        public Unit(string ident, int maxHP)
        {
            Identifier = ident;
            MaxHP = maxHP;
            CurrentHP = maxHP;
        }

        string Identifier { get; set; }

        int MaxHP { get; }

        int _CurrentHP;
        int CurrentHP
        {
            get { return _CurrentHP; }

            set
            {
                if (value > 0 && value <= MaxHP)
                {
                    _CurrentHP = value;
                } else
                {
                    throw new ArgumentException(string.Format("Invalid HP value: {0}", value));
                }
            }

        }

    }
}
