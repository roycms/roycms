blog设计总计

APP_Blog为博客主目录
BlogConfig.config为blog的主配置文件信息
APP_Blog/admin为管理目录
Config.aspx个人博客配置管理
EditPost.aspx博客信息编辑和添加
APP_Blog/UI/为模版目录
   baidu为HTML模版文件夹 baidu_Css为样式和资源文件夹

可以定义HTML 目前兼容百度空间所有模版样式可以瞬间呈现和百度空间一样的博客模版效果


技术 BlogPage.cs 页面基类
App_Data/blog/*.xml  存储单个博客信息 *以用户ID标识

Rewrite.config   注释有博客重写链接部分