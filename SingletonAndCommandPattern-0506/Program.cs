namespace SingletonAndCommandPattern_0506
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menuUiService = MenuUiService.Instance;

            menuUiService.PrintMenu();
        }
    }
}