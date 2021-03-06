﻿using AmCart.IAMModule;
using IdentityServer4.Models;
using IdentityServer4.Stores;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AmCart.IAMModule.IdentityProvider
{
    public class ClientStore : IClientStore
    {
        private readonly IClientRepository clientRepository;

        public ClientStore(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public async Task<IdentityServer4.Models.Client> FindClientByIdAsync(string clientId)
        {
            var client = await clientRepository.GetClientAsync(clientId);
            var identityServerClient = new IdentityServer4.Models.Client()
            {
                ClientId = client.Id.ToString(),
                ClientName = client.Name,
                ClientSecrets = new List<Secret>()
                {
                    new Secret(client.Secret.Sha256())
                },
                AllowedGrantTypes = client.GrantType == "Implicit" ? GrantTypes.Implicit : GrantTypes.ClientCredentials,
                RequireConsent = false,
                // where to redirect to after login
                RedirectUris = client.RedirectUris,
                // where to redirect to after logout
                PostLogoutRedirectUris = client.PostLogoutRedirectUris,
                AllowedScopes = client.Scopes,
                AllowAccessTokensViaBrowser = true
            };

            return identityServerClient;
        }
    }
}
