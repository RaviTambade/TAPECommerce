using IPL;
using System.Collections.Generic;


Player p1= new Player("Sourav Ganguly",50, 300, 50000);
Player p2= new Player("Sachin Tendulkar",49, 350, 100000);
Player p3= new Player("Rahul Dravid",48, 250, 70000);

List<Player> indianPlayers=new List<Player>();
indianPlayers.Add(p1);
indianPlayers.Add(p2);
indianPlayers.Add(p3);

/**
    //This does not work for user defined types
    if( p1 < p2){

    }
*/

int result= p1.CompareTo(p2);

if(result ==1){
    Console.WriteLine( " Sourav is greater than Sachin");
}
else if (result ==-1){
    Console.WriteLine( " Sachin is greater than Sourav");
}
else{
    Console.WriteLine( " Sourav and  Sachin are having same runs");
}


int num1=34;
int num2=56;
//double, int, float, long, short  will work

    if(num1 < num2){
        Console.WriteLine( "First number is smaller");
    }
    else{
    Console.WriteLine( "First number is  not smaller");
    }


Console.WriteLine( "Before sorting players");
foreach( Player currentPlayer in indianPlayers){
    /*Console.WriteLine( " " + currentPlayer.name + " "+ currentPlayer.age + " "+
                             currentPlayer.runs + "  "+ currentPlayer.matches);
                             */
    Console.WriteLine(currentPlayer);
}

//it (sort) is inbuilt function of List class

indianPlayers.Sort();
Console.WriteLine( " \nAfter sorting players");

foreach( Player currentPlayer in indianPlayers){
   /* Console.WriteLine( " " + currentPlayer.name + " "+ currentPlayer.age + " "+
                             currentPlayer.runs + "  "+ currentPlayer.matches); */
    Console.WriteLine(currentPlayer);
}