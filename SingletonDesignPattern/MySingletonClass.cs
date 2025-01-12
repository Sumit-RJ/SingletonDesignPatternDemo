namespace SingletonDesignPattern
{
	//sealed keyword will prevent inheritance
	sealed class MySingletonClass
	{
		//private constructor will prevent object creation of the class
		private MySingletonClass()
		{

		}

		private static MySingletonClass instance;
		private static object instanceLock = new object();

		/// <summary>
		/// Global entry point 
		/// </summary>
		/// <returns>singleton object of class</returns>
		public static MySingletonClass GetInstance()
		{
			if (instance == null)
			{
				// Below checking multithreding scenario
				lock (instanceLock)
				{
					if (instance == null)
					{
						instance = new MySingletonClass();
					}
				}

			}


			return instance;


		}

	}
}
