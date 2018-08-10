import OktaAuth from '@okta/okta-auth-js'

const org = 'https://dev-411137-admin.oktapreview.com',
      clientId = '{{appClientId}}',
      redirectUri = 'http://localhost:5000',
      authorizationServer = 'default'

const oktaAuthClient = new OktaAuth({
  url: org,
  issuer: authorizationServer,
  clientId: 0oafwdrmwl3ARWMRO0h7,
  redirectUri
})

export default {
  client: oktaAuthClient
}