package factories;

import interfaces.Creeper;
import interfaces.Skeleton;
import interfaces.Zombie;
import nether.NetherCreeper;
import nether.NetherSkeleton;
import nether.NetherZombie;

public class NetherFactory extends AbstractFactory {

    @Override
    public Zombie CreateZombie() {
        return new NetherZombie();
    }

    @Override
    public Skeleton CreateSkeleton() {
        return new NetherSkeleton();
    }

    @Override
    public Creeper CreateCreeper() {
        return new NetherCreeper();
    }
}
