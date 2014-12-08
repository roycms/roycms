<?xml version="1.0" encoding="utf-8"?>
<!-- DWXMLSource="1.xml" -->
<!DOCTYPE xsl:stylesheet  [
	<!ENTITY nbsp   "&#160;">
	<!ENTITY copy   "&#169;">
	<!ENTITY reg    "&#174;">
	<!ENTITY trade  "&#8482;">
	<!ENTITY mdash  "&#8212;">
	<!ENTITY ldquo  "&#8220;">
	<!ENTITY rdquo  "&#8221;"> 
	<!ENTITY pound  "&#163;">
	<!ENTITY yen    "&#165;">
	<!ENTITY euro   "&#8364;">
]>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output encoding="utf-8" />
  <xsl:output method="html"/>
  <xsl:template match="/">
  <h1>文件下载</h1>
<table width="45%" border="0" align="center" cellpadding="4" cellspacing="1" bgcolor="#DDDDDD">
      <tr>
         <td nowrap="nowrap" bgcolor="#EDEDED">文件全名</td>
        <td nowrap="nowrap" bgcolor="#EDEDED">时间</td>
        <td nowrap="nowrap" bgcolor="#EDEDED">格式</td>
        <td nowrap="nowrap" bgcolor="#EDEDED">下载地址</td>
  </tr>
    
        <xsl:for-each select="Root/Appendix">
          <tr>
          <td nowrap="nowrap" bgcolor="#FFFFFF"><xsl:value-of select="@FileName"/></td>
          <td nowrap="nowrap" bgcolor="#FFFFFF"><xsl:value-of select="@Time"/></td>
          <td nowrap="nowrap" bgcolor="#FFFFFF"><xsl:value-of select="@fileType"/></td>
          <td nowrap="nowrap" bgcolor="#FFFFFF"><a href="{@RootPath}{@FileName}">点击下载</a></td> </tr>
        </xsl:for-each>
     
    </table>
  </xsl:template>
</xsl:stylesheet>