package theend;

import interfaces.Zombie;

public class TheEndZombie implements Zombie {

    @Override
    public int hit() {
        return 20;
    }

    @Override
    public int getLife() {
        return 30;
    }

    @Override
    public String sound() {
        return "Brpp, the-end zombie.";
    }
}
