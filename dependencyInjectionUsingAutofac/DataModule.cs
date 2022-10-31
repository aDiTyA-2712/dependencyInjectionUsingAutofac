using Autofac;
using Autofac.Core;

namespace dependencyInjectionUsingAutofac
{
   public class DataModule:Module
    {
        private string _connStr;
        public DataModule(string connStr)
        {
            _connStr = connStr;
        }
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c=> new dependencyInjectionUsingAutofacContext(_connStr)).InstancePerRequest();
            base.Load(builder);
        }
    }
}