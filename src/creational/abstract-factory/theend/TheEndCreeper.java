package theend;

import interfaces.Creeper;

public class TheEndCreeper implements Creeper {

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
        return "Tsss... the-end creeper.";
    }
}
