import { Menu } from '@yoyo/theme';

// 全局的左侧导航菜单
export class AppMenus {
  // new
  static Menus: Menu[] = [
    {
      text: '',
      i18n: 'HomePage',
      acl: '',
      icon: { type: 'icon', value: 'home' },
      link: '/app/home',
    },
    {
      text: '',
      i18n: 'Tenants',
      acl: 'Pages.Tenants',
      icon: { type: 'icon', value: 'team' },
      link: '/app/tenants',
    },
    {
      text: '',
      i18n: 'Roles',
      acl: 'Pages.Roles',
      icon: { type: 'icon', value: 'safety' },
      link: '/app/roles',
    },
    {
      text: '',
      i18n: 'Users',
      acl: 'Pages.Users',
      icon: { type: 'icon', value: 'user' },
      link: '/app/users',
    },
    {
      text: '',
      i18n: 'About',
      icon: { type: 'icon', value: 'info-circle' },
      link: '/app/about',
    },
    {
      text: '',
      i18n: 'CloudBookList',
      icon: { type: 'icon', value: 'plus' },
      link: '',
      children: [
        {
          text: '',
          i18n: 'Books',
          acl: 'Pages.BookManager',
          icon: { type: 'icon', value: 'book' },
          link: '/app/cloud-book-list/books',
        },
        {
          text: '',
          i18n: 'Book-lists',
          icon: { type: 'icon', value: 'book' },
          link: '/app/cloud-book-list/book-lists',
        },
      ],
    },
  ]; // 无本地化显示字符 // 本地化主键(ABP本地化) // 权限 // 图标 // url 地址
  // hide: true,  // 强制隐藏
  // ...还有更多选项，请查看 Menu成员
  // old
  // static Menus = [
  //     // 首页
  //     new MenuItem(
  //         'HomePage',
  //         '',
  //         'anticon anticon-home',
  //         '/app/home'
  //     ),
  //     // 租户
  //     new MenuItem(
  //         'Tenants',
  //         'Pages.Tenants',
  //         'anticon anticon-team',
  //         '/app/tenants',
  //     ),
  //     // 角色
  //     new MenuItem(
  //         'Roles',
  //         'Pages.Roles',
  //         'anticon anticon-safety',
  //         '/app/roles',
  //     ),
  //     // 用户
  //     new MenuItem(
  //         'Users',
  //         'Pages.Users',
  //         'anticon anticon-user',
  //         '/app/users',
  //     ),
  //     // 关于我们
  //     new MenuItem(
  //         'About',
  //         '',
  //         'anticon anticon-info-circle-o',
  //         '/app/about',
  //     ),
  // ];
}
