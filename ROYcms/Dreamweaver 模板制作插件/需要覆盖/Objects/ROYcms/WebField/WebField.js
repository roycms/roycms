// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
			
var Name_Names = new Array("标题","正文","关键字","描述","形象图","作者","来源","ID","分类ID","标签","顶次数","浏览量","发布时间");
var Name_Values = new Array("title","contents","keyword","zhaiyao","pic","author","infor","bh","classname","tag","dig","hits","time");
var Name;
var Rid;
var TAG = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
	Rid = document.theForm.Rid;
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
 TAG += '<CMS:WebField ';
	  
  if (Name && Name.get() != ""){
		TAG += ' Name="' + Name.getValue() + '"';
  }
  
    if (Rid.value != ""){
		TAG += ' Rid="' + Rid.value + '"';
  }
	
  TAG += ' runat=server />';

  gDialogShown = false; // Reset show dialog global.

  return TAG;
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
  // set UI Globals
		Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
	     Rid = document.theForm.Rid;
  Name.focus();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
