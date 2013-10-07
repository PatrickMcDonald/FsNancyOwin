namespace CsNancyOwin
{
    using Owin;

    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseNancy();
        }
    }
}