var c=document.getElementByclassName("coolsite").getElementsByTagName("li");
for(var b=0,a=c.length;b<a;++b)
{
	c[b].onmouseover=function ()
	{
		this.tmpClass=this.className;
		this.className="iehover";
	};
	c[b].onmouseout=function ()
	{
		this.className=this.tmpClass;
	}
}