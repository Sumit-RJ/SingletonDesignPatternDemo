namespace SingletonDesignPattern
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");

			MySingletonClass singletonObj1 = MySingletonClass.GetInstance();
			MySingletonClass singletonObj2 = MySingletonClass.GetInstance();

			//above both singletonObj1 & singletonObj2 will get same instance of MySingletonClass 

		}
	}
}
