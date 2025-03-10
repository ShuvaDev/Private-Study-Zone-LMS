using Autofac;

namespace PSZ.LMS.Web
{
    public class WebModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<Membership>().As<IMembership>().InstancePerLifetimeScope();
        }

    }
}
