package overworld;

import interfaces.Creeper;

public class OverWorldCreeper implements Creeper {

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
        return "Tsss... overworld creeper.";
    }
}
