package factories;

import interfaces.Creeper;
import interfaces.Skeleton;
import interfaces.Zombie;

public abstract class AbstractFactory {
    abstract Zombie CreateZombie();
    abstract Skeleton CreateSkeleton();
    abstract Creeper CreateCreeper();
}   
