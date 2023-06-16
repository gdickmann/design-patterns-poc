package overworld;

import interfaces.Zombie;

public class OverWorldZombie implements Zombie {

    @Override
    public int hit() {
        return 10;
    }

    @Override
    public int getLife() {
        return 20;
    }

    @Override
    public String sound() {
        return "Brpp, overworld zombie.";
    }
}