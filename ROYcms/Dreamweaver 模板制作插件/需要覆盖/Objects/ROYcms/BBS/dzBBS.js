// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
			
var BbsEncoding_Names = new Array("GB2312","UTF-8");
var BbsEncoding_Values = new Array("GB2312","UTF-8");
var BbsEncoding;
var URL;
var gET = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	BbsEncoding = new ListControl('BbsEncoding');
	BbsEncoding.setAll(BbsEncoding_Names,BbsEncoding_Values);
	URL = document.theForm.URL;
		gET = document.theForm.gET;
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
 TAG += '<CMS:BBS ';
	  
  if (BbsEncoding && BbsEncoding.get() != ""){
		TAG += ' BbsEncoding="' + BbsEncoding.getValue() + '"';
  }
  
    if (URL.value != ""){
		TAG += ' URL="' + URL.value + '"';
  }
      if (gET.value != ""){
		TAG += ' gET="' + gET.value + '"';
  }
	
  TAG += ' runat=server />';

  gDialogShown = false; // Reset show dialog global.

  return TAG;
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
  // set UI Globals
		BbsEncoding = new ListControl('BbsEncoding');
	BbsEncoding.setAll(BbsEncoding_Names,BbsEncoding_Values);
	URL = document.theForm.URL;
		gET = document.theForm.gET;
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
