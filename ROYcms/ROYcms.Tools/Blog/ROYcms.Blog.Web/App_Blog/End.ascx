<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="End.ascx.cs" Inherits="ROYcms.Blog.Web.App_Blog.End" %>
<link href="/administrator/webui/facebox/facebox.css" media="screen" rel="stylesheet" type="text/css"/>
<script src="/administrator/webui/facebox/facebox.js" type="text/javascript"></script>
<SCRIPT type=text/javascript>
    jQuery(document).ready(function($) {
        $('a[rel*=facebox]').facebox({
            loading_image: '/administrator/webui/facebox/loading.gif',
            close_image: '/administrator/webui/facebox/closelabel.gif'
        })
    })
</SCRIPT>
