

[![GitHub stars](https://img.shields.io/github/stars/52ABP/LTMCompanyNameFree.YoyoCmsTemplate.svg)](https://github.com/52ABP/LTMCompanyNameFree.YoyoCmsTemplate/stargazers)
[![GitHub forks](https://img.shields.io/github/forks/52ABP/LTMCompanyNameFree.YoyoCmsTemplate.svg?style=social)](https://github.com/52ABP/LTMCompanyNameFree.YoyoCmsTemplate/network)[![GitHub license](https://img.shields.io/github/license/52ABP/LTMCompanyNameFree.YoyoCmsTemplate.svg?style=social)](https://github.com/52ABP/LTMCompanyNameFree.YoyoCmsTemplate/blob/master/LICENSE)


# 介绍

> 各个镜像的编译状态
> 考虑到国内的下载速度慢，我们在码云上也部署了一套环境，代码同步。

# 课程推荐信息：



## 关于 52ABP 

52ABP是一个整合了前后端的强力框架，
后端是对.NET Core和ABP框架进行了二次的封装和整合
前端是在Angular的基础上整合了Ng-Zorro、Ng-alain等组件
架构层面也是一个基于DDD(领域驱动设计)的经典分层架构 目的是成为一个强大的基础设施符合国人开发习惯的框架现代WEB应用框架。


关于 ABP 的后端文档，详情参看：https://www.52abp.com/ReadWiki/ABP%E6%A1%86%E6%9E%B6%E4%B8%AD%E6%96%87%E6%96%87%E6%A1%A3/Documents-3.7.2/Readme.md

关于 ng-alain 的官方文档，详情参考：https://ng-alain.com/docs/getting-started

本次着重说明的是前端项目的文档。 本文档的大部分内容是从 ng-alain 官方摘录，因为是你的前端框架嘛。。

## 截图

![image](https://upload-images.jianshu.io/upload_images/1979022-149453e355774c58.gif?imageMogr2/auto-orient/strip)
![](https://upload-images.jianshu.io/upload_images/1979022-78623047838e0674.gif?imageMogr2/auto-orient/strip)

[52ABP模板 ASP.Net Core 与 Angular的开源实例项目
](https://www.cnblogs.com/wer-ltm/p/9358478.html)

## 下载地址

通过52ABP来创建属于你自己的独立项目信息: https://www.52abp.com/Download/Index

## 环境准备

本地环境需要您安装 [node](http://nodejs.org/) 和 [git](https://git-scm.com/)。我们的技术栈基于 [Typescript](https://www.tslang.cn/)、[Angular](https://angular.io/)、[g2](http://g2.alipay.com/)、[@delon](https://github.com/cipchk/delon) 和 [ng-zorro-antd](https://ng.ant.design/)，提前了解和学习这些知识会非常有帮助。




# 启动项目

我们推荐你从[https://www.52abp.com](https://www.52abp.com/Download/Index) 创建您自己的项目模板，本项目模板为统一的启动模板，您可以像我们贡献您的代码信息。

更多详细的启动教程：
[项目运行教程](https://www.52abp.com/Blog/BlogDetails/1)
### 备注：
```
默认用户名：admin

默认密码：123qwe
```


#### 代码相关镜像仓库：

码云：[国内镜像](https://gitee.com/yoyocms/LTMCompanyNameFree.YoyoCmsTemplate)

Github:[主仓库](https://github.com/52ABP/LTMCompanyNameFree.YoyoCmsTemplate) 


# 前端项目的说明

**如何阅读文档**

在开始之前有一些文档描述约定说明，这有助于更好的阅读：

- API 相关
  - `[]` 表示属性
  - `()` 表示事件
  - `[()]` 表示双向绑定
  - `ng-content` 表示组件内容占位符
  - `#tpl` 开头表示 `<ng-template #tpl>`
- 对象相关，一般在类描述时
  - `[]` 表示属性
  - `()` 结尾表示方法
## 前端常用的命令

生成指定路径的 组件
`
  ng generate component persons/create-or-edit-person-modal
`
