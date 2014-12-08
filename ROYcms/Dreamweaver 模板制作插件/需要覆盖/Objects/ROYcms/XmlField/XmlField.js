// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
			
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
	Name = document.theForm.Name;
	
	Rid = document.theForm.Rid;
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
 TAG += '<CMS:XmlField ';
	  
  if (Name.value != ""){
		TAG += ' Name="' + Name.value + '"';
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
		Name = document.theForm.Name;
	     Rid = document.theForm.Rid;
  Name.focus();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
