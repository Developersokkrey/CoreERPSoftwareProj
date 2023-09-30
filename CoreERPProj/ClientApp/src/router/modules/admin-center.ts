const adminCenter: AuthRoute.Route = {
  name: 'admin-center',
  path: '/admin-center',
  component: 'basic',
  children: [
    // Admin Center / General
    {
      name: 'plugin_charts',
      path: '/plugin/charts',
      component: 'multi',
      children: [
        {
          name: 'plugin_charts_antv',
          path: '/plugin/charts/antv',
          component: 'self',
          meta: {
            title: 'AntV',
            i18nTitle: 'routes.admin-center.general.antv',
            requiresAuth: true,
            icon: 'fluent:building-people-24-regular'
          }
        },
        {
          name: 'plugin_charts_echarts',
          path: '/plugin/charts/echarts',
          component: 'self',
          meta: {
            title: 'ECharts',
            i18nTitle: 'routes.admin-center.general.echarts',
            requiresAuth: true,
            icon: 'fluent:person-settings-16-regular'
          }
        }
      ],
      meta: {
        title: '图表',
        i18nTitle: 'routes.admin-center.general._value',
        icon: 'material-symbols:rule-settings-rounded'
      }
    },
    // Admin Center / Inventory
    {
      name: 'plugin_charts',
      path: '/plugin/charts',
      component: 'multi',
      children: [
        {
          name: 'plugin_charts_antv',
          path: '/plugin/charts/antv',
          component: 'self',
          meta: {
            title: 'AntV',
            i18nTitle: 'routes.admin-center.inventory.antv',
            requiresAuth: true,
            icon: 'fluent:building-people-24-regular'
          }
        },
        {
          name: 'plugin_charts_echarts',
          path: '/plugin/charts/echarts',
          component: 'self',
          meta: {
            title: 'ECharts',
            i18nTitle: 'routes.admin-center.inventory.echarts',
            requiresAuth: true,
            icon: 'fluent:person-settings-16-regular'
          }
        }
      ],
      meta: {
        title: 'Inventory',
        i18nTitle: 'routes.admin-center.inventory._value',
        icon: 'clarity:blocks-group-line'
      }
    },
    // Admin Center / Settings
    {
      name: 'plugin_map',
      path: '/plugin/map',
      component: 'self',
      meta: {
        title: 'Settings',
        i18nTitle: 'routes.admin-center.map',
        requiresAuth: true,
        icon: 'fluent:settings-cog-multiple-24-regular'
      }
    }
  ],
  meta: {
    title: 'Admin Center',
    i18nTitle: 'routes.admin-center._value',
    icon: 'fluent:person-starburst-24-regular',
    order: 2
  }
};

export default adminCenter;
