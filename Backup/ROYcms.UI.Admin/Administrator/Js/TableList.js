/*全选*/
function CheckAll(form)
  {
  for (var i=0;i<form.elements.length;i++)
    {
    var e = form.elements[i];
    if (e.Name != "chkAll"&&e.disabled==false)
       e.checked = form.chkAll.checked;
    }
}

function topCheckAll(form)
  {
  for (var i=0;i<form.elements.length;i++)
    {
    var e = form.elements[i];
	 if (e.Name != "topchkAll"&&e.disabled==false)
       e.checked = form.topchkAll.checked;
    }
}
/*单击事件*/
function Click(id)
{
    var e= $('#tr'+id).find('input[type=checkbox]:first-child').attr('checked');
	if(e==true)
	{   
	    $('#tr'+id).toggleClass("CheckOut");/*设置其class名称*/
		$('#tr'+id).find('input[type=checkbox]:first-child').attr('checked','false');
	}
	else if(e==false)
	{ 
	    $('#tr'+id).toggleClass("Check");/*设置其class名称*/
	    $('#tr'+id).find('input[type=checkbox]:first-child').attr('checked','true');
	}
}
/*鼠标经过*/
function MouseMove(id)
{
	$('#tr'+id).toggleClass("Check");/*设置其class名称*/
}
/*鼠标离开*/
function MouseDown(id)
{
	$('#tr'+id).toggleClass("CheckOut");/*设置其class名称*/
}

 /*复选后单元格变色*/
function chkRow(obj){
var r = obj.parentElement.parentElement;
if(obj.checked){ r.style.backgroundColor="#92C9D9";}
else {if(r.rowIndex%2==1)r.style.backgroundColor="";else r.style.backgroundColor="#f4fbff";}
}