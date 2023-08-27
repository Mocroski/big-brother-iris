import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BigBrotherAPI',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44317/',
    redirectUri: baseUrl,
    clientId: 'BigBrotherAPI_App',
    responseType: 'code',
    scope: 'offline_access BigBrotherAPI',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44317',
      rootNamespace: 'BigBrotherAPI',
    },
  },
} as Environment;
