/*
 * Created by SharpDevelop.
 * User: ly
 * Date: 2017/8/12
 * Time: 22:09
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WCFClient
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			ServiceClient client=new ServiceClient();
			string s=client.MyOperation();
			Console.WriteLine(s);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}