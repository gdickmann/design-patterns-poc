package nether;

import interfaces.Skeleton;

public class NetherSkeleton implements Skeleton {

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
        return "Click-click, nether skeleton.";
    }
}
