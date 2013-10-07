namespace CsNancyOwin
{
    using Nancy;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => "Hello C# World!";
        }
    }
}