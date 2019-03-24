using System.IO;
using System.Xml.Xsl;

namespace XMLParser
{
    public static class XsltConverter
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static void Convert(string xsltFile, string inputFile, string outputFile)
        {
            if (File.Exists(xsltFile) && File.Exists(inputFile) && File.Exists(outputFile))
            {
                var xslt = new XslCompiledTransform();
                try
                {
                    xslt.Load(xsltFile);
                    xslt.Transform(inputFile, outputFile);
                }
                catch (XsltException e)
                {
                    logger.Error("Transformation error: \n" + e);
                }
            }
            else
            {
                logger.Error("File does not exist");
            }
        }
    }
}