﻿using System;
using Autofac;
using FluentValidation;

namespace OrderTrackingSystem.App_Start.Core
{
    public class AutofacValidatorFactory : ValidatorFactoryBase
    {
        private readonly IContainer container;

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