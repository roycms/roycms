<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="___Tree.aspx.cs" Inherits="ROYcms.UI.Admin.Tree" %>
<!DOCTYPE HTML>
<html >
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<link rel="stylesheet" type="text/css" href="codebase/GooTree.css"/>
<script  type="text/javascript" src="codebase/jquery-1.3.2.min.js"></script>
<script  type="text/javascript" src="codebase/GooTree.js"></script>
<script  type="text/javascript" src="codebase/GooFunc.js"></script>
<script type="text/javascript">
var tree1;
var data=[
<%=Trees() %>
];
var property={
	width: 170,
	height: 300,
	background:"url(codebase/img/bg_sample_tree.gif) repeat-x 0px bottom",
	enableMove:true,
	input_type:"check",//可编辑模式，有text，radio，check三种模式
	canAppendLeaf:true,
	autoLoad:false,
	autoLoadPara:{
		url:"/servlet/BaseAction",
		type:"POST",
		data:{action:"getChildren"},
		timeout:10000,
		errorText:"serve error"
	},
	autoMove:{
		url:"/servlet/BaseAction",
		type:"POST",
		data:{action:"getChildren"},
		timeout:10000,
		success:function(msg){return true},
		error:function(){return false}
	},
	//input_type:"input",  /*input_type默认不写时，为正常树；如果为checkbox则整个树每个结点都为复选框，为radio则整个树每个结点都为单选框*/
	//input_name:"tree1_name" //当input_type有值且有关效时，整个树结点的单/复选框的name属性值，默认时与this.$id的值一样
};
$(document).ready(function(){
	tree1=$.createGooTree($("#trees"),property);
	tree1.loadTree(data);
	//tree1.eventOnUncheckItem=function(id){alert("uncheck:"+id);};
	//tree1.eventOnCheckItem=function(id){alert("check:"+id);};
	tree1.eventOnSelectItem=function(id){alert("check:"+id);};
});
</script>
</head>

<body>
<br/>
<div id="trees"></div>
<input type="button" value="删除结点组" onclick="tree1.clearChildrenByPreId('c3')"/>
<input type="button" value="选中结点" onclick="tree1.selectItem('i_mov')"/>
<input type="button" value="编辑结点" onclick="tree1.showSelectedEdit()"/>
<div class="Tree" style="height:100px">
	<div class="mov_flt"><b class="err"></b><b class="f_d"></b><span>fasdfasdfasf</span></div>
</div>
</body>
</html>