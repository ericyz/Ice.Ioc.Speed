public interface IMasterService
{
    void Run();
}

public class MasterService: IMasterService
{
    private readonly IChildService1 childService1;
    private readonly IChildService2 childService2;
    private readonly IChildService3 childService3;
    public MasterService(IChildService1 childService1, IChildService2 childService2, IChildService3 childService3)
    {
        this.childService2 = childService2;
        this.childService3 = childService3;
        this.childService1 = childService1;
    }

    public void Run(){
        childService1.Run();
        childService1.Run();
        childService2.Run();
    }
}

public interface IChildService1
{

    void Run();

}

public interface IChildService2
{
    void Run();

}

public interface IChildService3
{
    void Run();

}

public class ChildService1 : IChildService1
{
    public void Run()
    {
    }
}

public class ChildService2 : IChildService2
{
    public void Run()
    {
    }
}

public class ChildService3 : IChildService3
{
    public void Run()
    {
    }
}