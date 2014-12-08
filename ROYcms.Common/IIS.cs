using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ROYcms.Common
{
    class IIS
    {
        /// <summary>
        /// 必须导入IIS7 目录的DLL 文件实现其 API   News the IIS.
        /// </summary>
        public void NewIIS()
        {
            //ServerManager iisManager = new ServerManager();
            //iisManager.Sites.Add("NewSite", "http", "*:8080:", "d:\\MySite");
            //iisManager.Update();
            ////将一个应用程序（Application）添加到一个站点     

            //ServerManager iisManager = new ServerManager();
            //iisManager.Sites["NewSite"].Applications.Add("/Sales", "d:\\MyApp");
            //iisManager.Update();

            ////建立一个虚拟目录（Virtual   Directory）     

            //ServerManager iisManager = new ServerManager();
            //Application app = iisManager.Sites["NewSite"].Applications["/Sales"];
            //app.VirtualDirectories.Add("/VDir", "d:\\MyVDir");
            //iisManager.Update();
        }
    }
}
