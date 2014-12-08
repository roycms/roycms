// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements

var Top, NewId,Order;

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
    NewId = document.theForm.NewId;
	   Top = document.theForm.Top;
	   Order = document.theForm.Order;
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
	var TAG = "";
   
  TAG += '\n<CMS:RemarkRepeater ';
  
  if (NewId.value != ""){
      TAG += ' NewId="' + NewId.value + '"';
      }
  
  if (Top.value != ""){
      TAG += ' Top="' + Top.value + '"';
	  }
  if (Order.value != ""){
      TAG += ' FiledOrder="' + Order.value + '"';
	  }

  


  TAG += ' runat="server">\n<ItemTemplate>';
  
  TAG += '\n<li>';
  TAG += '\n<h1><%#Eval("userName") %><span><%#Eval("Ip") %></span></h1>';
  TAG += '\n<p><%#Eval("contents") %></p>';
  TAG += '\n</li>';
  
  var TAG2 = '\n</ItemTemplate>\n</CMS:RemarkRepeater>\n';

  gDialogShown = false; // Reset show dialog global.

	dom.source.wrapSelection(TAG,TAG2);
  return "";
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
	    NewId = document.theForm.NewId;
		Order = document.theForm.Order;
	   Top = document.theForm.Top;
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
