using System;
using System.Xml;

namespace LayoutProject.program
{
    internal class LastMinuteWrapper
    {

        private string AC_DISPLAY = "ac_display";
        private string TAG_KEY = "key";
        private string HEX = "hex";
        private string ATT_TYPE = "type";


        public void wrapThingsUp(XmlDocument xmlDocument, XmlNode layoutElement)
        {
            RemoveGenericNodes();
            HandleAcDisplayElement(xmlDocument, layoutElement);
        }

        private void HandleAcDisplayElement(XmlDocument xmlDocument, XmlNode layoutElement)
        {
            foreach (XmlElement childNode in layoutElement.ChildNodes){
                if (childNode.GetAttribute(XMLPreparer.ATT_NAME).Equals(AC_DISPLAY))
                {

                 /*   string value = childNode.GetAttribute(XMLPreparer.ATT_X) + ", "
                                   + childNode.GetAttribute(XMLPreparer.ATT_Y) + ", "
                                   + childNode.GetAttribute(XMLPreparer.ATT_WIDTH) + ", "
                                   + childNode.GetAttribute(XMLPreparer.ATT_HEIGHT);
                   */ XmlElement acDisplayElement = xmlDocument.CreateElement(XMLPreparer.TAG_RECT);
                    acDisplayElement.SetAttribute(XMLPreparer.ATT_NAME, AC_DISPLAY);
                    acDisplayElement.SetAttribute(XMLPreparer.ATT_X, childNode.GetAttribute(XMLPreparer.ATT_X));
                    acDisplayElement.SetAttribute(XMLPreparer.ATT_Y, childNode.GetAttribute(XMLPreparer.ATT_Y));
                    acDisplayElement.SetAttribute(XMLPreparer.ATT_WIDTH, childNode.GetAttribute(XMLPreparer.ATT_WIDTH));
                    acDisplayElement.SetAttribute(XMLPreparer.ATT_HEIGHT, childNode.GetAttribute(XMLPreparer.ATT_HEIGHT));

                    //acDisplayElement.InnerText = value;
                    layoutElement.RemoveChild(childNode);
                    layoutElement.AppendChild(acDisplayElement);

                }

            }
        }

        private void RemoveGenericNodes()
        {
            foreach (var genericXmlNode in XMLReader.GetGenericItemsList())
            {
                if (genericXmlNode.Attributes[XMLPreparer.ATT_NAME].Value.Contains(XMLReader.POWER_TAG)) continue;
                XMLReader.getKeysNode().RemoveChild(genericXmlNode);
            }
        }



    }
}