<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output method="text"/>

  <xsl:template match="/">
    Game - <xsl:value-of select="/Game/Title"/>
    Developers: <xsl:apply-templates select="/Game/Developers/Developer"/>
  </xsl:template>

  <xsl:template match="Game">
    - <xsl:value-of select="." />
  </xsl:template>

</xsl:stylesheet>