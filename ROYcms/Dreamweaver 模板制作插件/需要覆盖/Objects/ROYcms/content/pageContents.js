// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
var StrWhere, PageSize,Class;

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	 StrWhere = document.theForm.StrWhere;
	 PageSize = document.theForm.PageSize;
	 Class = document.theForm.Class;
  }
  
  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
	var TAG = "";
   
  TAG += '\n<CMS:WebPageRepeater ';
  
  if (StrWhere.value != ""){
      TAG += ' StrWhere="' + StrWhere.value + '"';
      }
    if (Class.value != ""){
      TAG += ' Class="' + Class.value + '"';
	  }
  if (PageSize.value != ""){
      TAG += ' PageSize="' + PageSize.value + '"';
	  }
 

  TAG += ' runat="server">\n<ItemTemplate>';
  
  TAG += '\n<li>';
  TAG += '\n<a href=\'<CMS:Link Class=<%#Eval("classname") %> runat="server" />show-<%#Eval("bh") %>.html\' ><%#Eval("title") %></a>';
  TAG += '\n<span><%#Eval("time") %></span>';
  TAG += '\n</li>';
  
  var TAG2 = '\n</ItemTemplate>\n</CMS:WebPageRepeater>\n';

  gDialogShown = false; // Reset show dialog global.

	dom.source.wrapSelection(TAG,TAG2);
  return "";
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
 	 StrWhere = document.theForm.StrWhere;
	 PageSize = document.theForm.PageSize;
	 Class = document.theForm.Class;
  StrWhere.focus();
  StrWhere.select();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
