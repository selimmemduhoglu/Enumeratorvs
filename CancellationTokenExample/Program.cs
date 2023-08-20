
class Program
{
    public static async void main(string[] args)
    {

        
        using (CancellationTokenSource cts = new())
        {
            CancellationToken token = cts.Token;

            Task longtask = Task.Run(() =>
            {

                while (!token.IsCancellationRequested)
                {
                    Console.Write("Task is working on it");
                    Thread.Sleep(1000);

                }

                Console.WriteLine("Task is stopped");
            });

            Console.WriteLine("Please press Enter for cancel the task.");
            Console.ReadLine();
            cts.Cancel();
            await longtask;

        }


    }


}