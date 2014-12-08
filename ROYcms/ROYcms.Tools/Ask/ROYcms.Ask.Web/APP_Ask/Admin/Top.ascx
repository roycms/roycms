<h1 class="admintitle">
    管理 - <a href="/blog-<%=ROYcms.Common.Session.Get("user_id") %>/default.html">[<%=ROYcms.Common.Session.Get("user") %>]博客主页 &raquo;</a>
    </h1>
    <br />
    <div id="TabDiv">
      <a href="config.aspx"><input type="submit" name="btnSelectConfig" value="配置" id="btnSelectConfig" title="选中配置选项卡" class="tabselected" /></a>
      <a href="EditPost.aspx"><input type="submit" name="btnSelectConfig" value="新建博客文章" id="Submit1" title="新建博客文章" class="tabselected" /></a>
      <a href="config.aspx"><input type="submit" name="btnSelectCategories" value="分类" id="btnSelectCategories" title="选中目录选项卡" class="tab" /></a>
      <a href="config.aspx"><input type="submit" name="btnSelectLog" value="系统日志" id="btnSelectLog" title="选中系统日志选项卡" class="tab" /></a>
      <a href="config.aspx"><input type="submit" name="btnSelectFiles" value="模版编辑" id="btnSelectFiles" title="选中编辑文件选项卡" class="tab" /></a>
      <a href="config.aspx"><input type="submit" name="btnSelectProviders" value="模版选择" id="btnSelectProviders" title="选中提供者选项卡" class="tab" /></a>
      <a href="EditPost.aspx" class="tabselected">新建博客文章</a>
    </div>
    <h2 class="sectiontitle"><%=ROYcms.AskPage.___GetConfigValue("Title")%>后台管理</h2>
    <p> 编辑信息并点击保存按钮  <a href="/ucenter/logout.aspx?url=blog-<%=ROYcms.Common.Session.Get("user_id") %>/default.html" >注销[<%=ROYcms.Common.Session.Get("user") %>]</a></p> 