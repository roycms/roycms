// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements

var TuiJian_TRUE_OR_FALSE = new Array("","true", "false");
var Switchs_TRUE_OR_FALSE = new Array("","true", "false");
var Class, StrWhere, Top, Order, TuiJian, Switchs;

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	 Class = document.theForm.Class;
	 StrWhere = document.theForm.StrWhere;
	 Top = document.theForm.Top;
	 Order = document.theForm.Order;
	 
	TuiJian = new ListControl('TuiJian');
	TuiJian.setAll(TuiJian_TRUE_OR_FALSE,TuiJian_TRUE_OR_FALSE);
    Switchs = new ListControl('Switchs');
	Switchs.setAll(Switchs_TRUE_OR_FALSE,Switchs_TRUE_OR_FALSE);
  }
  
  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
	var TAG = "";
   
  TAG += '\n<CMS:WebRepeater ';
  
  if (StrWhere.value != ""){
      TAG += ' StrWhere="' + StrWhere.value + '"';
      }
  
  if (Top.value != ""){
      TAG += ' Top="' + Top.value + '"';
	  }
  if (Class.value != ""){
      TAG += ' Class="' + Class.value + '"';
	  }
  if (Order.value != ""){
      TAG += ' FiledOrder="' + Order.value + '"';
	  }

  if (TuiJian && TuiJian.get() != "")
  {
		TAG += ' TuiJian="0"';
  }
   if (Switchs && Switchs.get() != "")
  {
		TAG += ' Switchs="0"';
  }


  TAG += ' runat="server">\n<ItemTemplate>';
  
  TAG += '\n<li>';
  TAG += '\n<a href=\'<CMS:Link Class=<%#Eval("classname") %> runat="server" />show-<%#Eval("bh") %>.html\' ><%#Eval("title") %></a>';
  TAG += '\n<span><%#Eval("time") %></span>';
  TAG += '\n</li>';
  
  var TAG2 = '\n</ItemTemplate>\n</CMS:WebRepeater>\n';

  gDialogShown = false; // Reset show dialog global.

	dom.source.wrapSelection(TAG,TAG2);
  return "";
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
 Class = document.theForm.Class;
	 StrWhere = document.theForm.StrWhere;
	 Top = document.theForm.Top;
	 Order = document.theForm.Order;
	 
	TuiJian = new ListControl('TuiJian');
	TuiJian.setAll(TuiJian_TRUE_OR_FALSE,TuiJian_TRUE_OR_FALSE);
    Switchs = new ListControl('Switchs');
	Switchs.setAll(Switchs_TRUE_OR_FALSE,Switchs_TRUE_OR_FALSE);
  StrWhere.focus();
  StrWhere.select();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
