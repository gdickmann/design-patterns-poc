package overworld;

import interfaces.Skeleton;

public class OverWorldSkeleton implements Skeleton {

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
        return "Click-click, overworld skeleton.";
    }
}
