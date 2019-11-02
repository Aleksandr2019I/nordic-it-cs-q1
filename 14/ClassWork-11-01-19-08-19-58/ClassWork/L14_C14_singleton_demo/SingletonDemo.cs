namespace L14_C14_singleton_demo
{
	public class Singleton
	{
		private static Singleton instance;

		public static Singleton Instance =>
			instance ?? (instance = new Singleton());

		private Singleton()
		{
		}
	}
}
