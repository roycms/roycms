// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
var Name_Names = new Array("栏目名称","栏目内容","栏目ID","栏目地址","栏目关键字","栏目描述");
var Name_Values = new Array("ClassName","contents","Id","FilePath","keyword","Description");
var Name;
var Class;
var Path;
var TAG = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	Class = document.theForm.Class;
	Path = document.theForm.Path;
	Name = new ListControl('Name');
	Name.setAll(Name_Names,Name_Values);
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
  TAG += '<CMS:ClassField ';
	  
  if (Name && Name.get() != ""){
		TAG += ' Name="' + Name.getValue() + '"';
  }
  
    if (Class.value != ""){
		TAG += ' Rid="' + Class.value + '"';
  }
  
    if (Path.value != ""){
		TAG += ' Path="' + Path.value + '"';
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
  Name.focus();
  
      Class = document.theForm.Class;
	Path = document.theForm.Path;
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
