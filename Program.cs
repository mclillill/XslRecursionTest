using System;
using System.IO;
using System.Xml;
using System.Xml.Xsl;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            string strXml = @"<?xml version=""1.0"" encoding=""UTF-8"" ?>
<PasswordList>
    <ListEntry>
        <SiteName>Testseite</SiteName>
        <Password>hfglkhglkdfhglh</Password>
    </ListEntry>
    <ListEntry>
        <SiteName>Testseite 2</SiteName>
        <Password>hfglkhglkdfgdfgfhglh</Password>
    </ListEntry>
    <ListEntry>
        <SiteName>Testseite 3</SiteName>
        <Password>hfglkhglkdgdfgdfgfhglh</Password>
    </ListEntry>
</PasswordList>";


            string strXsl = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<xsl:stylesheet version=""1.0""
	xmlns:xsl=""http://www.w3.org/1999/XSL/Transform""
	xmlns:msxml =""urn:schemas-microsoft-com:xslt""
	xmlns:fi = ""fi-script""
	exclude-result-prefixes=""msxml fi""
	>
  <xsl:output method=""xml"" version =""1.0"" indent=""yes"" omit-xml-declaration=""yes""/>

  <!-- ============================================================ -->
  <!-- Root-Template -->
  <!-- ============================================================ -->
  <xsl:template match=""/"">
    <xsl:call-template name=""WebStoryViews"">
    </xsl:call-template>
  </xsl:template>
  
  <xsl:template name=""WebStoryViews"">
    <div>test</div>
    <xsl:call-template name=""WebStoryViews2"">
    </xsl:call-template>
    <div>test</div>
  </xsl:template>

  <xsl:template name=""WebStoryViews2"">
    <div>test</div>
    <xsl:call-template name=""WebStoryViews"">
    </xsl:call-template>
    <div>test</div>
  </xsl:template>
</xsl:stylesheet>";

            XslCompiledTransform oXsl = new XslCompiledTransform();
            oXsl.Load(XmlReader.Create(new StringReader(strXsl)));
            XsltArgumentList oXsltArgumentList = new XsltArgumentList();
            TextWriter oTextWriter = new StringWriter();
            XmlWriterSettings oSettings = oXsl.OutputSettings.Clone();
            oSettings.CloseOutput = true;
            
            MyXmlWriter oXmlWriter = new MyXmlWriter(oTextWriter, oSettings);
            //XmlWriter oXmlWriter = XmlWriter.Create(oTextWriter, oSettings);
            
            oXsl.Transform(XmlReader.Create(new StringReader(strXml)), oXsltArgumentList, oXmlWriter);
            string strResult = oTextWriter.ToString();
        }
    }

    internal class MyXmlWriter : XmlWriter
    {
        private TextWriter oTextWriter;
        private XmlWriterSettings oSettings;

        public MyXmlWriter(TextWriter oTextWriter, XmlWriterSettings oSettings)
        {
            this.oTextWriter = oTextWriter;
            this.oSettings = oSettings;
        }

        public override WriteState WriteState => throw new NotImplementedException();

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override string LookupPrefix(string ns)
        {
            throw new NotImplementedException();
        }

        public override void WriteBase64(byte[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteCData(string text)
        {
            throw new NotImplementedException();
        }

        public override void WriteCharEntity(char ch)
        {
            throw new NotImplementedException();
        }

        public override void WriteChars(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteComment(string text)
        {
            throw new NotImplementedException();
        }

        public override void WriteDocType(string name, string pubid, string sysid, string subset)
        {
            throw new NotImplementedException();
        }

        public override void WriteEndAttribute()
        {
            throw new NotImplementedException();
        }

        public override void WriteEndDocument()
        {
            throw new NotImplementedException();
        }

        public override void WriteEndElement()
        {
            
        }

        public override void WriteEntityRef(string name)
        {
            throw new NotImplementedException();
        }

        public override void WriteFullEndElement()
        {
            throw new NotImplementedException();
        }

        public override void WriteProcessingInstruction(string name, string text)
        {
            throw new NotImplementedException();
        }

        public override void WriteRaw(char[] buffer, int index, int count)
        {
            throw new NotImplementedException();
        }

        public override void WriteRaw(string data)
        {
            throw new NotImplementedException();
        }

        public override void WriteStartAttribute(string prefix, string localName, string ns)
        {
            throw new NotImplementedException();
        }

        public override void WriteStartDocument()
        {
            throw new NotImplementedException();
        }

        public override void WriteStartDocument(bool standalone)
        {
            throw new NotImplementedException();
        }

        public override void WriteStartElement(string prefix, string localName, string ns)
        {
            var st = new System.Diagnostics.StackTrace();
            if (st.FrameCount > 100)
            {
                throw new PossibleInfinityRecursionException();
            }
        }

        public override void WriteString(string text)
        {
            var st = new System.Diagnostics.StackTrace();
            if (st.FrameCount > 100)
            {
                throw new PossibleInfinityRecursionException();
            }
        }

        public override void WriteSurrogateCharEntity(char lowChar, char highChar)
        {
            throw new NotImplementedException();
        }

        public override void WriteWhitespace(string ws)
        {
            throw new NotImplementedException();
        }
    }
}
