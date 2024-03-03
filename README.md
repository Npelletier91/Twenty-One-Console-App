# TwentyOne Console Application

This repository contains a simple C# console application for a game similar to Blackjack, referred to here as TwentyOne. The application demonstrates object-oriented programming concepts through the use of classes, structs, enums, and operator overloading in a card game scenario.

## Features

- **Deck Initialization**: Automatically generates a standard 52-card deck.
- **Shuffle Functionality**: Allows the deck to be shuffled a specified number of times.
- **Player Management**: Supports adding and removing players from the game.


## Code Examples

Here are some snippets from the application showcasing its best features:

### Deck Initialization and Shuffle

```csharp
Deck deck = new Deck();
deck.Shuffle(out int timesShuffled, 4); // Shuffle the deck 4 times
```
### Adding and Removing Players
```csharp
public static Game operator+ (Game game, Player player)
{
  game.Players.Add(player);
  return game;
}
  public static Game operator- (Game game, Player player)
{
  game.Players.Remove(player);
  return game;
}
```

```csharp
Game game = new TwentyOneGame();
game.Players = new List<Player>();
Player player = new Player();
player.Name = "Nic";
game += player;
```
