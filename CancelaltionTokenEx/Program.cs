using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // CancellationTokenSource oluştur
        using (CancellationTokenSource cts = new CancellationTokenSource())
        {
            CancellationToken token = cts.Token;

            // İptal işaretlenene kadar çalışacak asenkron bir görev başlat
            Task longRunningTask = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("Working...");
                    Thread.Sleep(1000);
                }
                Console.WriteLine("Task cancelled.");
            });

            // Kullanıcı iptal etmek istediğinde CancellationTokenSource'ı iptal et
            Console.WriteLine("Press 'Enter' to cancel the task.");
            Console.ReadLine();
            cts.Cancel();

            await longRunningTask;
        }
    }
}
