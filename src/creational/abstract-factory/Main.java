

import factories.NetherFactory;
import interfaces.Zombie;
import nether.NetherZombie;

public class Main {
    public static void main(String[] args) {
        // Creating objects with AbstractFactory
        Zombie netherZombie = new NetherFactory().CreateZombie();
        System.out.println(netherZombie.sound());
        
        // Creating objects without AbstractFactory
        Zombie netherZombie2 = new NetherZombie();
        System.out.println(netherZombie2.sound());
    }
}