package factories;

import interfaces.Creeper;
import interfaces.Skeleton;
import interfaces.Zombie;
import theend.TheEndCreeper;
import theend.TheEndSkeleton;
import theend.TheEndZombie;

public class TheEndFactory extends AbstractFactory {

    @Override
    public Zombie CreateZombie() {
        return new TheEndZombie();
    }

    @Override
    public Skeleton CreateSkeleton() {
       return new TheEndSkeleton();
    }

    @Override
    public Creeper CreateCreeper() {
        return new TheEndCreeper();
    }
}
