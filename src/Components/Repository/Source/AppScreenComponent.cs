using White.Core.UIItems.WindowItems;

namespace Repository
{
    public class AppScreenComponent : RepositoryComponent
    {
        protected AppScreenComponent() {}
        public AppScreenComponent(Window window, ScreenRepository screenRepository) : base(window, screenRepository) {}

        public override string ToString()
        {
            return GetType().Name;
        }
    }
}