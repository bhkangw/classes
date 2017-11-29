namespace classes{
    public class Samurai : Human {
        public static int count = 0;
        public Samurai(string n) : base(n){
            health = 200;
            count++; // counts how many samurais there are
        }
        public void Death_Blow(object target){
            Human enemy = target as Human;
            if(enemy != null){
                if(enemy.health < 50){
                    enemy.health = 0;
                }
            }
        }
        public void Meditate(){
            health = 200;
        }
        public void How_Many(){
            System.Console.WriteLine(count);
        }

    }

}