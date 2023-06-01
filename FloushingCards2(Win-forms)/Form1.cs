namespace FloushingCards2_Win_forms_
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Deck deck1;
        Deck deck2;
        public Form1()
        {
            InitializeComponent();
            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }
        public void RedrawDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                zestaw1Box.Items.Clear();
                foreach (string name in deck1.GetCardNames())
                {
                    zestaw1Box.Items.Add(name);
                    zestaw1Box.Text = "Zestaw 1 (" + deck1.Count + ") kart"; ;
                }
            }
            if (DeckNumber == 2)
            {
                zestaw2Box.Items.Clear();
                foreach (string name in deck2.GetCardNames())
                {
                    zestaw2Box.Items.Add(name);
                    zestaw2Box.Text = "Zestaw 2 (" + deck2.Count + ") kart"; ;
                }
            }
        }
        private void ResetDeck(int DeckNumber)
        {
            if (DeckNumber == 1)
            {
                List<Card> cards = new List<Card>();
                for (int i = 0; i < 10; i++)

                    cards.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                deck1 = new Deck(cards);
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }


        private void reset1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }
        private void reset2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }



        private void moveTo1Set_Click(object sender, EventArgs e)
        {
            if (zestaw2Box.SelectedIndex >= 0)
            {
                if (deck2.Count > 0)
                    deck1.Add(deck2.Deal(zestaw2Box.SelectedIndex));
            }

            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveTo2Set_Click(object sender, EventArgs e)
        {
            if (zestaw1Box.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                    deck2.Add(deck1.Deal(zestaw1Box.SelectedIndex));
            }

            RedrawDeck(1);
            RedrawDeck(2);
        }
    }
}