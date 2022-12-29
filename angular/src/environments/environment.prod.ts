import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'RobertEcommerce',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44349/',
    redirectUri: baseUrl,
    clientId: 'RobertEcommerce_App',
    responseType: 'code',
    scope: 'offline_access RobertEcommerce',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'RobertEcommerce',
    },
  },
} as Environment;
