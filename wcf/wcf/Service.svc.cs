/*
 * Created by SharpDevelop.
 * User: ly
 * Date: 2017/8/12
 * Time: 21:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ServiceModel;

namespace wcf
{
	[ServiceContract]
	public interface IService
	{
	   [OperationContract]
	   string MyOperation();
	   
	   	 
	}
	
	public class Service : IService
	{
	   public string MyOperation()
	   {
	   	return "hello wcf!";
	   }
	} 
}
