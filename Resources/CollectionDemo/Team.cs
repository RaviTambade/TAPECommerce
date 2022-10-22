 
using System.Collections.Generic;
namespace Collections
{
    class Team
    {
        public string Name { get; set; }                           
        public List<Player> players = new List<Player>();
        public Team(string name)
        {
            this.Name = name;
        }
        //you can write mulitple properties for class

        //but you can have only one indexer per class
       public Player this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
                this.players.Add(value);
            }
        }
    }
}