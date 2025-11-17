namespace PointOfSalesApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            PointOfSale pos = new PointOfSale("Jolan Company", 2500.0);

            Application.Run(new PointOfSalesApp(pos));
        }
    }
}