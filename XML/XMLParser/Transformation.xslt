<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0"
                xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:strip-space elements="*"/>

  <xsl:template match="node()|@*">
    <xsl:copy>
      <xsl:apply-templates select="node()|@*"/>
    </xsl:copy>
  </xsl:template>

  <xsl:template match="name">
    <name>
      <xsl:attribute name="{name(following-sibling::*[1])}">
        <xsl:value-of select="following-sibling::*[1]" />
      </xsl:attribute>
      <xsl:apply-templates select="@*|node()"/>
    </name>
  </xsl:template>
  <xsl:template match="*[name]/*[not(self::name)]" />
</xsl:stylesheet>

