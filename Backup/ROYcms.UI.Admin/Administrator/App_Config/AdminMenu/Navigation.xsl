<!-- DWXMLSource="AdminNavigation.xml" -->
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
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="html"/>
  <xsl:template match="/">
    <table width="160" border="0" cellpadding="0" cellspacing="0">
      <tr>
        <td><xsl:for-each select="Root/type[@Visible = &apos;true&apos;]">
            <table width="100%" height="25" border="0" cellpadding="0" cellspacing="5" style="margin-top:10px;margin-bottom:10px;background-color: #FFFFFF;border: 1px solid #DDEDF6;">
              <tr>
                <td><img src="{@logo}" align="absmiddle" alt="{@description}" />
                  <font color="#FF3300" style="margin-left:5px;">
                  <b title="{@description}">
                  <xsl:value-of select="@name"/>
                  </b>
                  </font></td>
              </tr>
            </table>
            <xsl:for-each select="title[@Visible = &apos;true&apos;]">
              <table width="100%" border="0" cellspacing="0" cellpadding="4">
                <tr>
                  <td><img src="/administrator/images/plus-.gif" align="absmiddle" alt="ROYcms!NT" />
                  <a href="{@url}" title="{@description}" target="mainFrame"><xsl:value-of select="."/></a></td>
                </tr>
              </table>
            </xsl:for-each>
          </xsl:for-each></td>
      </tr>
    </table>
  </xsl:template>
</xsl:stylesheet>