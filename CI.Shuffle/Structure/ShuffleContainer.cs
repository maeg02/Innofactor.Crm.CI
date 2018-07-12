﻿namespace Innofactor.Crm.CI.Structure
{
    using Cinteros.Crm.Utils.Common;
    using Cinteros.Crm.Utils.Common.Interfaces;
    using Microsoft.Xrm.Sdk.Client;
    using Microsoft.Xrm.Tooling.Connector;
    using System;

    internal class ShuffleContainer : IContainable
    {
        #region Private Fields

        private readonly OrganizationServiceProxy service;

        #endregion Private Fields

        #region Internal Constructors

        internal ShuffleContainer(CrmServiceClient client)
        {
            service = client.OrganizationServiceProxy;
        }

        #endregion Internal Constructors

        #region Public Properties

        public ILoggable Logger => throw new NotImplementedException();

        public IServicable Service => new CrmServiceProxy(service);

        #endregion Public Properties
    }
}