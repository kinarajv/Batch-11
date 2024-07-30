﻿class Program
{
    static void Main()
    { 
        Console.WriteLine("Download starting...");
		CancellationTokenSource alarmCts = new CancellationTokenSource();
        Task t2 = Task.Run(() => DownloadFile(alarmCts.Token));
		Task t1 = Task.Run(() =>
        {
           	Console.ReadLine();
            alarmCts.Cancel();
        });
		Task.WaitAny(t1,t2);
		Console.WriteLine("Download Finished");
        Console.ReadLine(); 
    }

    static void DownloadFile(CancellationToken ct)
    {
        for(int i=0;i < 100;i++) {
			Console.WriteLine($"Downloading : {i} %");
			Thread.Sleep(100);
			if(ct.IsCancellationRequested) {
				return;
			}
		}
    }
}
