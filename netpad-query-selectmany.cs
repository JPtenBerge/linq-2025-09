var players = new List<Player> {
    new() { Cards = [new() {Suit ="hearts", Value = 7 }, new() { Suit = "hearts", Value = 8 }] },
    new() { Cards = [new() {Suit ="clubs", Value = 10 }, new() { Suit = "spades", Value = 11 } ]},
    new() { Cards = [new() {Suit ="hearts", Value = 4 },new() { Suit = "hearts", Value = 11 } ]},
};
players.SelectMany(x => x.Cards).Dump();


class Player
{
    public List<Card> Cards { get; set; } = [];
}

class Card
{
    public string Suit { get; set; }
    public int Value { get; set; }
}

