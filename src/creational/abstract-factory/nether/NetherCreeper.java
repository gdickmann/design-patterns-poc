package nether;

import interfaces.Creeper;

public class NetherCreeper implements Creeper {

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
        // This mob is so annoying. RIP all my destroyed houses.
        return "Tsssss... nether explosion.";
    }
}
