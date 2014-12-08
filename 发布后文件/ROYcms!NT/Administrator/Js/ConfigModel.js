/*===========================Roy==========================================*/


//主函数方法
function ConfigModeMain(){
	//添加一个字段方法ConfigModel.aspx
$("#ConfigModelBT").click(function(){

  var err = Add_Field();
   if(err!=null){alert(err);return}
   
    $.ajax({
		   type: 'POST',
		   url: "/administrator/model/AJAXConfigModel.aspx",
		   data: $("#ConfigModelForm").serialize(),
		   beforeSend:function(xmlhttp){ $("#ConfigModelBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#ConfigModelBT").attr("value","提交");
               LoadFieldHtml();//加载表单模型
               alert("成功");
			   // Boxy.get("#AddModelBT").unload(); //关闭窗口
			   // window.location.reload();//刷新页面
			} else {
			   $("#ConfigModelBT").attr("value","继续提交");
		       alert("失败");
			};
		   }
		})
})

//生成一个模型表格AJAXGreatTable.aspx
$("#GreatTableBT").click(function(){
 if(!confirm("确实要生成一个模型表格吗?左侧的表单确定就是您要的模型吗？ ")){
	return false;
	}else {
    $.ajax({
		   url: "/administrator/MODEL/AJAXGreatTable.aspx",
		   data: "ModelId="+$("#ModelId").val()+"&TableName="+$("#TableName").val(),
		   beforeSend:function(xmlhttp){ $("#GreatTableBT").attr("value","正在提交..."); },
		   success: function(date){ 
		   if (date>0) {
		       $("#GreatTableBT").attr("value","提交");
               alert("成功");
			   // Boxy.get("#AddModelBT").unload(); //关闭窗口
			   window.location.reload();//刷新页面
			} else {
			   $("#GreatTableBT").attr("value","继续提交");
		       alert("失败");
			};
		   }
		})}
})
// 删除一个字段
$(".FieldDelBT").live("click",function(){
    if(!confirm("确实要删除这个字段吗? ")){
	return false;
	}else {
    $.ajax({
		   url: "/administrator/Model/AJAXField.aspx",
		   data: "Del="+$(this).attr("id"),
		   success: function(date){ 
		   if (date>0) {
		       LoadFieldHtml()
               alert("成功");
			} else {
		       alert("失败");
			};
		   }
		})}
})
// 重新排序字段字段
$("#OrderBT").live("click",function(){
var Order,PId;
$(".OrderByF").each(function(i){
    PId += ","+$(this).attr("id");
   Order +=","+$(this).val();
 });
 
 // alert(Order);
 // alert(PId);

    $.ajax({
		   url: "/administrator/Model/AJAXField.aspx",
		   data: "Order="+Order+"&PId="+PId,
		   success: function(date){ 
		   if (date>0) {
		       LoadFieldHtml()
               alert("成功");
			} else {
		       alert("失败");
			};
		   }
		})
})



//加载表单模型
function LoadFieldHtml(){
$("#FieldHtml").load("/administrator/MODEL/Field.aspx?Rid="+$("#ModelId").val()+"&date="+$("#Name").val());
}
LoadFieldHtml();


//Add_Field 添加字段表单验证
function Add_Field(){
	var e=null;function set(po){if (e==null){e=po;};}
	
		if(!Validator("#Lable",regexEnum.notempty)){set("标签不能为空！")}; //非空
		if(!Validator("#Name",regexEnum.letter)){set("名称必须为英文字母！")}; 
		if(!Validator("#Len",regexEnum.intege1)){set("可输入字数必须为数字！")}; 
		if(!Validator("#OrderBy",regexEnum.intege1)){set("排序必须为数字！")}; 
		if(!Validator("#InputLen",regexEnum.intege1)){set("显示长度必须为数字！")}; 
		
		return e;	
}



}




/*页面加载类*/
$(document).ready(function() {
  ConfigModeMain();//
});