const userAccount: AuthRoute.Route = {
  name: 'user-account',
  path: '/user-account',
  component: 'basic',
  children: [
    {
      name: 'user-account_permission',
      path: '/user-account/permission',
      component: 'self',
      meta: {
        title: '权限切换',
        i18nTitle: 'routes.auth-demo.permission',
        requiresAuth: true,
        icon: 'ic:round-construction'
      }
    },
    {
      name: 'auth-demo_super',
      path: '/auth-demo/super',
      component: 'self',
      meta: {
        title: '超级管理员可见',
        i18nTitle: 'routes.auth-demo.super',
        requiresAuth: true,
        permissions: ['super'],
        icon: 'ic:round-supervisor-account'
      }
    }
  ],
  meta: {
    title: '权限示例',
    i18nTitle: 'routes.auth-demo._value',
    icon: 'ic:baseline-security',
    order: 5
  }
};

export default userAccount;
