// Copyright 2002, 2003 Macromedia, Inc. All rights reserved.
//*************** GLOBAL CONSTANTS *****************
var gDialogShown = false;

//*************** GLOBAL VARIABLES *****************
// UI Elements

var ClassKind, Class, Top, Path;

//---------------     API FUNCTIONS    ---------------

// Add function to do the form TAG stuff

function isDOMRequired() {
  return false;
}

function objectTag() {
  if (!gDialogShown){
	
	ClassKind = document.theForm.ClassKind;
	Class = document.theForm.Class;
	Top = document.theForm.Top;
	Path = document.theForm.Path;
	
  }

  var dom = dw.getDocumentDOM();
  var offsets = dom.getSelection();
	var currSel = dom.offsetsToNode(offsets[0], offsets[1]);
	var TAG = "";
   
  TAG += '\n<CMS:ClassRepeater ';
  
  if (ClassKind.value != ""){
      TAG += ' ClassKind="' + ClassKind.value + '"';
      }
    if (Class.value != ""){
      TAG += ' Class="' + Class.value + '"';
      }
  if (Top.value != ""){
      TAG += ' Top="' + Top.value + '"';
	  }
  if (Path.value != ""){
      TAG += ' Path="' + Path.value + '"';
	  }

  TAG += ' runat="server">\n<ItemTemplate>';
  
  TAG += '\n<h4>';
  TAG += '\n<a href=\'<%#Eval("FilePath").ToString().Replace("{cmspath}/","/") %>\' ><%#Eval("ClassName") %></a>';
  TAG += '\n</h4>';
  
  var TAG2 = '\n</ItemTemplate>\n</CMS:ClassRepeater>\n';

  gDialogShown = false; // Reset show dialog global.

	dom.source.wrapSelection(TAG,TAG2);
  return "";
}

//---------------    LOCAL FUNCTIONS   ---------------



function initializeUI()
{
	ClassKind = document.theForm.ClassKind;
	Class = document.theForm.Class;
	Top = document.theForm.Top;
	Path = document.theForm.Path;
  ClassKind.focus();
  ClassKind.select();
  gDialogShown = true;
}


function displayHelp(){
  dw.browseDocument("http://help.roycms.cn");
}
