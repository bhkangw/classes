namespace classes
{
    public class Human {
        public string name;
        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }
        public int health { get; set; }
        
        public Human(string n){
            name = n;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string n, int str, int intel, int dex, int hp){
            name = n;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;        
        }
        // public void Attack(Human enemy){
        //     enemy.health = health - (strength*5);
        // }
        // (Optional) Change the last function to accept any object and just make sure it is of type Human before applying damage. 
        // Hint you may need to refer back to the Boxing/Unboxing tab!
        public void Attack(object target)
        {
            Human enemy = target as Human;
            if (enemy != null)
            {
                enemy.health -= 5 * strength;
            }
            else{
                System.Console.WriteLine("Failed Attack");
            }
        }

    }
}