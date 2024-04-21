//parallel Programming: Technique to make use of these CPUs in parallel .
//multi-core: Multiple CPUs physically
//.NET has TPL(task parallel library)

 using System;
 using System.Threading;
 using System.Threading.Tasks;
class ParallelAsync
{
    int[] numbers = [18, 234, 456, 7879, 6780,355634];
    public void ProcessNumbers()
    {
        Console.WriteLine("sequential implementation");
        //squential
        foreach(var num in numbers)
        {
            DoWork(num);
        }
        Console.WriteLine("parallel implementation");
        //parallel
        Parallel.ForEach(numbers ,DoWork);
    }
    public void DoWork(int num)
    {
        Thread.Sleep(1000);//simulating delay
        Console.WriteLine($"Num: {num}");
    }
}

//Asynchronous Programming:
// AJAX- Asynchronous javascript and XML :non blocking I/O
//.NET: async, await

//making tea
public async Task IgniteStove()
{
  async Task.Delay(5000);
}
public  async Task void PutKettleOnWithWater()
{
 async Task.Delay(5000);
}
public  async Task GrindMasala()
{

}
public  async Task PourSugar()
{

}
public  async Task PourChiyaPatti()
{

}
public  async Task PourMilk(
    {

    }
)