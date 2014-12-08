<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ROYcms.UI.Admin.Administrator.FileTree.WebForm1" %>



<html xmlns="http://www.w3.org/1999/xhtml">

	<head>
		<title>jQuery File Tree Demo</title>
		
		<script src="/administrator/WebUI/jQuery/jquery.js" type="text/javascript"></script>

        <script src="jqueryFileTree.js" type="text/javascript"></script>
		<link href="jqueryFileTree.css" rel="stylesheet" type="text/css" media="screen" />
		
		
        
		<meta http-equiv="Content-Type" content="text/html;charset=utf-8" />
		
		<style type="text/css">
			BODY,
			HTML {
				padding: 0px;
				margin: 0px;
			}
			BODY {
				font-family: Verdana, Arial, Helvetica, sans-serif;
				font-size: 11px;
				background: #EEE;
				padding: 15px;
			}
			
			H1 {
				font-family: Georgia, serif;
				font-size: 20px;
				font-weight: normal;
			}
			
			H2 {
				font-family: Georgia, serif;
				font-size: 16px;
				font-weight: normal;
				margin: 0px 0px 10px 0px;
			}
			
			.example {
				float: left;
				margin: 15px;
			}
			
			.demo {
				width: 200px;
				height: 400px;
				border-top: solid 1px #BBB;
				border-left: solid 1px #BBB;
				border-bottom: solid 1px #FFF;
				border-right: solid 1px #FFF;
				background: #FFF;
				overflow: scroll;
				padding: 5px;
			}
			
			P.note {
				color: #999;
				clear: both;
			}
		</style>
		


		
		<script type="text/javascript">
			
			$(document).ready( function() {
				
				$('#fileTreeDemo_1').fileTree({ root: '~/admin/', script: 'connectors/jqueryFileTree.aspx' }, function(file) { 
					alert(file);
				});
				
				$('#fileTreeDemo_2').fileTree({ root: '~/', script: 'connectors/jqueryFileTree.aspx', folderEvent: 'click', expandSpeed: 750, collapseSpeed: 750, multiFolder: false }, function(file) { 
					alert(file);
				});
				
				$('#fileTreeDemo_3').fileTree({ root: '~/', script: 'connectors/jqueryFileTree.aspx', folderEvent: 'click', expandSpeed: 750, collapseSpeed: 750, expandEasing: 'easeOutBounce', collapseEasing: 'easeOutBounce', loadMessage: 'Un momento...' }, function(file) { 
					alert(file);
				});
				
				$('#fileTreeDemo_4').fileTree({ root: '~/', script: 'connectors/jqueryFileTree.aspx', folderEvent: 'dblclick', expandSpeed: 1, collapseSpeed: 1 }, function(file) { 
					alert(file);
				});
				
			});
		</script>

	</head>
	
	<body>
		
		<h1>jQuery File Tree Demo</h1>
		<p>
			Feel free to view the source code of this page to see how the file tree is being implemented.
		</p>
		
		<p>
			<a href="/notebook.php?article=58">Back to the project page</a>
		</p>
		
		<div class="example">
			<h2>Default options</h2>
			<div id="fileTreeDemo_1" class="demo"></div>
		</div>
		
		<div class="example">
			<h2>multiFolder = false</h2>
			<div id="fileTreeDemo_2" class="demo"></div>
		</div>
		
		<div class="example">
			<h2>Custom load message &amp; easing</h2>
			<div id="fileTreeDemo_3" class="demo"></div>
		</div>
		
		<div class="example">
			<h2>Double click &amp; no animation</h2>
			<div id="fileTreeDemo_4" class="demo"></div>
		</div>
		
		<p class="note">
			The PHP connector used in this demo has been modified to prevent access
			to folders below the demo directory.
		</p>
	</body>
	
</html>