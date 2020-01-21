using System;
					
public class Program
{	
	public static void Main()
	{
		int n=0;
		Console.WriteLine("Enter n");
		n=Convert.ToInt32(Console.ReadLine());
		int[] num=new int[n];
		for (int i = 0; i < n; i++)
		{
			num[i]=Convert.ToInt32(Console.ReadLine());
		}

		for (int i = 0; i < n; i++)
		{
			Console.WriteLine(num[i]);
		}
		for(int j=0;j<n;j++)
		{
			if(j%2==0)
			{
				num[j]--;
			}
			else
				num[j]++;
		}
		for (int i = 0; i < n; i++)
		{
			Console.WriteLine(num[i]);
		}
	}
}