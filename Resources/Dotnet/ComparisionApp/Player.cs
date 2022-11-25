namespace IPL;
using System.Collections;

public  class Player:IComparable {
    public string name;
    public int runs;
    public int matches;
    public int age;
    public Player(string name, int age, int matches, int runs){
        this.name=name;
        this.age=age;
        this.matches=matches;
        this.runs=runs;
    }
    public int CompareTo(object? obj)
    {
        //Typing
        Player anotherPlayer= (Player) obj;

        //comparision is based on runs scored
        /* if(this.runs > anotherPlayer.runs){
            return 1;
        }
        else if (this.runs < anotherPlayer.runs){
            return -1;
        }
        else
        return 0;
         
         */

         //comparision is based on age 
        /*if(this.age > anotherPlayer.age){
            return 1;
        }
        else if (this.age < anotherPlayer.age){
            return -1;
        }
        else
        return 0;*/

         //comparision is based on matches played
         if(this.matches > anotherPlayer.matches){
            return 1;
        }
        else if (this.matches < anotherPlayer.matches){
            return -1;
        }
        else
        return 0;
         
    }
    public override string ToString()
    {
    return    this.name + " "+ this.age + " "+ this.runs + "  "+ this.matches;
    }
}