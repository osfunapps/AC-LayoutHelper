using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LayoutProject.program
{
    class XMLReader
    {

        private string HOT = "H", COLD = "C", WIND = "W";
        private static List<XmlNode> genericItemsList;
        //instances
        private XMLReaderCallback xmlReaderCallback;

        //finals
        public static string ATT_KEYS = "keys";
        private static XmlNode keysNode;
        private string MIN_DEGREE = "min_degree", MAX_DEGREE = "max_degree";
        private string POWER = "power";
        private string SCREEN_ELEMENT = "screen_element_";
        public static string POWER_TAG = "power";
        private List<XmlElement> namesStripNodesList;

        public XMLReader(Initiator initiator)
        {
            this.xmlReaderCallback = initiator;
            genericItemsList = new List<XmlNode>();
        }

        internal void ReadXMLPath(string xmlPath)
        {
            XmlDocument xmlDocument = LoadXmlPath(xmlPath);
            deleteLayoutTag(xmlDocument);
            var xmlNodesNamesList = GetXmlNodesNamesList(xmlDocument);
            xmlReaderCallback.OnReadEnd(xmlDocument, xmlNodesNamesList);
        }


        private XmlDocument LoadXmlPath(string xmlPath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@xmlPath);
            return document;
        }

        private string[] GetXmlNodesNamesList(XmlDocument document)
        {
            keysNode = document.GetElementsByTagName(ATT_KEYS)[0];
            XmlNodeList keysNodesList = keysNode.ChildNodes;
            namesStripNodesList = new List<XmlElement>();
            List<string> namesList = new List<string>();

            foreach (XmlElement keyNode in keysNodesList)
            {
            
                string nodeName = keyNode.Attributes[XMLPreparer.ATT_NAME].Value;

                if (!nodeName.StartsWith(SCREEN_ELEMENT)) continue;
                //we will strip the "screen_element" param out
                namesStripNodesList.Add(keyNode);
                nodeName = nodeName.Replace(SCREEN_ELEMENT, "");
                //keyNode.SetAttribute(XMLPreparer.ATT_NAME, nodeName);
                
                genericItemsList.Add(keyNode);
                if (nodeName.Contains(POWER)) nodeName = POWER;
                namesList.Add(nodeName);

            }

            return namesList.ToArray();
        }

        public void stripNodesNames()
        {
            foreach (var node in namesStripNodesList)
            {
                string nodeName = node.Attributes[XMLPreparer.ATT_NAME].Value;
                nodeName = nodeName.Replace(SCREEN_ELEMENT, "");
                node.SetAttribute(XMLPreparer.ATT_NAME, nodeName);
            }
        }
        
        public void deleteLayoutTag(XmlDocument xmlDocument)
        {
            //need to go to remote and delete the layout from there!
            if (xmlDocument.GetElementsByTagName(XMLPreparer.TAG_LAYOUT)[0] == null) return;
            XmlNode xmlnode = xmlDocument.GetElementsByTagName(XMLPreparer.TAG_REMOTE)[0];
            xmlnode.RemoveChild(xmlDocument.GetElementsByTagName(XMLPreparer.TAG_LAYOUT)[0]);
            xmlDocument.Save(PathForm.GetXmlPath());
        }

        public static List<XmlNode> GetGenericItemsList() { return genericItemsList; }
        public static XmlNode getKeysNode() { return keysNode; }

    }

    internal interface XMLReaderCallback
    {
        void OnReadEnd(XmlDocument xmlDocument, string[] xmlNodesNamesList);
    }


}
