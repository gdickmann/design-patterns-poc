package factories;

import interfaces.Creeper;
import interfaces.Skeleton;
import interfaces.Zombie;
import overworld.OverWorldCreeper;
import overworld.OverWorldSkeleton;
import overworld.OverWorldZombie;

public class OverWorldFactory extends AbstractFactory {

    @Override
    public Zombie CreateZombie() {
        return new OverWorldZombie();
    }

    @Override
    public Skeleton CreateSkeleton() {
        return new OverWorldSkeleton();
    }

    @Override
    public Creeper CreateCreeper() {
        return new OverWorldCreeper();
    }
}
