using Autofac;
using FluentValidation;
using System;

namespace Home.Users.Demo.App_Start
{
    internal class AutofacValidatorFactory : ValidatorFactoryBase
    {
        private IContainer container;

        public AutofacValidatorFactory(IContainer container)
        {
            this.container = container;
        }

        public override IValidator CreateInstance(Type validatorType)
        {
            IValidator validator = container.ResolveOptionalKeyed<IValidator>(validatorType);
            return validator;
        }
    }
}