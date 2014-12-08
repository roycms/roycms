// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements
var DEFAULT_TYPE_TEXT = new Array("评论人","评论人邮箱","评论正文","评论日期","评论ID","项次序数字");
var DEFAULT_TYPE = new Array("UserName","Email","Content","AddDate","ID","ItemIndex");
var Type;
var TAG = "";

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	Type = new ListControl('Type');
	Type.setAll(DEFAULT_TYPE_TEXT,DEFAULT_TYPE);
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
   
  TAG += '';
	  
  if (Type && Type.get() != ""){
		TAG += ' type="' + Type.getValue() + '"';
  }
	
  TAG += '';

  gDialogShown = false; // Reset show dialog global.

  return TAG;
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
  // set UI Globals
	Type = new ListControl('Type');
	Type.setAll(DEFAULT_TYPE_TEXT,DEFAULT_TYPE);
  Type.focus();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
