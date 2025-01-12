namespace SingletonDesignPattern
{
	sealed class MySingletonClass
	{
		private MySingletonClass()
		{

		}

		private static MySingletonClass instance;
		private static object instanceLock = new object();
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
