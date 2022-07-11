import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Kraken',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44310',
    redirectUri: baseUrl,
    clientId: 'Kraken_App',
    responseType: 'code',
    scope: 'offline_access Kraken',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44318',
      rootNamespace: 'Kraken',
    },
  },
} as Environment;
