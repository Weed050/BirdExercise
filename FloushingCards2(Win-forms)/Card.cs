﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FloushingCards2_Win_forms_
{
    class Card
    {
        public override string ToString()
        {
            return Name;
        }
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name
        {
            get
            {
                return Value + " of " + Suit;
            }
        }
        public static bool DoesCardMatch(Card CardToCheck,Suits Suits)
        {
            if(CardToCheck.Suit == Suits)
                return true;
            else
                return false;

        }
        public static bool DoesCardMatch(Card CardToCheck,Values Value)
        {
            if (CardToCheck.Value == Value)
                return true;
            else
                return false;
        }
    }
    enum Suits
    {
        Spades,
        Clubs,
        Diamonds,
        Hearts,
    }
    enum Values
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
    }
}
