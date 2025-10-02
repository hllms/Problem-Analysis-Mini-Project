using Problem_Analysis_Mini_Project.DevSupport;

namespace Problem_Analysis_Mini_Project
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Smoke test (safe to leave during early dev; remove later)
            ModelSmoke.Run();

            MainPage = new AppShell();

            
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}