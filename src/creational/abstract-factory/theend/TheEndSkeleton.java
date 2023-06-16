package theend;

import interfaces.Skeleton;

public class TheEndSkeleton implements Skeleton {

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
        return "Click-click, the-end skeleton.";
    }
}
