package nether;

import interfaces.Zombie;

public class NetherZombie implements Zombie {

    @Override
    public int hit() {
        return 5;
    }

    @Override
    public int getLife() {
        return 10;
    }

    @Override
    public String sound() {
        return "Brpp, nether zombie.";
    }
}
