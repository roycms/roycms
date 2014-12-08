/*
var pltsPop=null;
var pltsoffsetX = 15;   // 弹出窗口位于鼠标左侧或者右侧的距离；3-12 合适
var pltsoffsetY = 10;  // 弹出窗口位于鼠标下方的距离；3-12 合适
var pltsPopbg="#FEFEDA"; //背景色
var pltsPopfg="#ABAB98"; //边框
var pltsPopft="#5F5F52" //文字
var pltsTitle="";
document.write('<div id=pltsTipLayer style="display: none;position: absolute; z-index:10001"></div>');
function pltsinits()
{
    document.onmouseover   = plts;
    document.onmousemove = moveToMouseLoc;
}
function plts()
{  var o=event.srcElement;
    if(o.alt!=null && o.alt!=""){o.dypop=o.alt;o.alt=""};
    if(o.title!=null && o.title!=""){o.dypop=o.title;o.title=""};
    pltsPop=o.dypop;
    if(pltsPop!=null&&pltsPop!=""&&typeof(pltsPop)!="undefined")
    {
	pltsTipLayer.style.left=-1000;
	pltsTipLayer.style.display='';
	var Msg=pltsPop.replace(/\n/g,"<br>");
	Msg=Msg.replace(/\0x13/g,"<br>");
	var re=/\{(.[^\{]*)\}/ig;
	if(!re.test(Msg))pltsTitle="";
	else{
	  re=/\{(.[^\{]*)\}(.*)/ig;
  	  pltsTitle=Msg.replace(re,"$1")+" ";
	  re=/\{(.[^\{]*)\}/ig;
	  Msg=Msg.replace(re,"");
	  Msg=Msg.replace("<br>","");}
	  var attr=(document.location.toString().toLowerCase().indexOf("list.asp")>0?"nowrap":"");
       	var content =
		'<iframe style="position:absolute;z-index:-1;width:100%;height:21px;" scrolling="no" frameborder="0" src="about:blank"></iframe>'+
      	'<div id=toolTipTalbe style="font-size:11px;background-color: '+pltsPopbg+';border: 1px solid '+pltsPopfg+';color:'+pltsPopft+'";>'+
      	'<div style="margin-right:2px;margin-left:3px;margin-bottom:1px;line-height:18px">'+Msg+'</div>'+
      	'</div>';
       	pltsTipLayer.innerHTML=content;
       	toolTipTalbe.style.width=Math.min(pltsTipLayer.clientWidth,document.body.clientWidth/2.2);
       	moveToMouseLoc();
       	return true;
       }
    else
    {
    	pltsTipLayer.innerHTML='';
      	pltsTipLayer.style.display='none';
       	return true;
    }
}

function moveToMouseLoc()
{
	if(pltsTipLayer.innerHTML=='')return true;
	var MouseX=event.x;
	var MouseY=event.y;
	//window.status=event.y;
	var popHeight=pltsTipLayer.clientHeight;
	var popWidth=pltsTipLayer.clientWidth;
	if(MouseY+pltsoffsetY+popHeight>document.body.clientHeight)
	{
	  	popTopAdjust=-popHeight-pltsoffsetY*1.5;
	}
	 else
	{
	   	popTopAdjust=0;
	}
	if(MouseX+pltsoffsetX+popWidth>document.body.clientWidth)
	{
		popLeftAdjust=-popWidth-pltsoffsetX*2;
	}
	else
	{
		popLeftAdjust=0;
	}
	pltsTipLayer.style.left=MouseX+pltsoffsetX+document.body.scrollLeft+popLeftAdjust;
	pltsTipLayer.style.top=MouseY+pltsoffsetY+document.body.scrollTop+popTopAdjust;
  	return true;
}
pltsinits();
*/