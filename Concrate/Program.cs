using Concrate;
using Entity;

Game game1 = new Game(1,"Counter Strike", 50);
Game game2 = new Game(2,"CallOfDuty", 120);
Game game3 = new Game(3,"Valorant", 30);

GameManager gameManager = new GameManager();

gameManager.Add(game1);
gameManager.Add(game2);
gameManager.Add(game3);
Console.WriteLine("----Games----");
foreach (var item in gameManager.GetAllGames())
{
    Console.WriteLine(item);
}

Console.WriteLine("------Update Games------");
gameManager.Update(3,12);

foreach (var item in gameManager.GetAllGames())
{
    Console.WriteLine(item);
}

//Console.WriteLine("---------------");
//gameManager.Delete(3);

Console.WriteLine("------Campains Games-------");
CampaignManager campaignManager = new CampaignManager(gameManager);
campaignManager.Add(1,5);
campaignManager.Add(2,10);
foreach (var item in campaignManager.GetCampaignGames())
{
    Console.WriteLine(item);
}

Console.WriteLine("----Update Campaigns Games-----");
campaignManager.Update(2,15);

foreach (var item in campaignManager.GetCampaignGames())
{
    Console.WriteLine(item);
}

Gamer gamer1 = new Gamer(1, "Hakan", "Karlı", "12345", new DateTime(2004, 6, 3));
Gamer gamer2 = new Gamer(2, "Fatma", "Çal", "78963", new DateTime(2003, 4, 12));
Gamer gamer3 = new Gamer(3, "Aslı", "Duru", "45632", new DateTime(1990, 7, 25));
Gamer gamer4 = new Gamer(5, "FıratCan", "Tepe", "85241", new DateTime(2000, 8, 25));
Console.WriteLine("-----Login--------");
GamerManager gamerManager = new GamerManager();
try
{
    gamerManager.Add(gamer1);
    gamerManager.Add(gamer2);
    gamerManager.Add(gamer3);
    gamerManager.Add(gamer4);

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

GameSaleManager gameSaleManager = new GameSaleManager(gamerManager,gameManager);
gameSaleManager.Add(gamer1,game1);
gameSaleManager.Add(gamer2, game3);
gameSaleManager.Add(gamer3,game2);
Console.WriteLine("--------SalesList-----------");

foreach (var item in gameSaleManager.getSalesList())
{
    Console.WriteLine(item);
}

Console.WriteLine("----------");
gameSaleManager.Remove(gamer3);
foreach (var item in gameSaleManager.getSalesList())
{
    Console.WriteLine(item);
}