using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Xml;

namespace WindowsFormsApplication1
{
    public class LoopTroughFile
    {


        public string ExecuteTranslate(string openpath)
        {
            XmlDocument document = new XmlDocument();
            document.Load(openpath);
            string OutputToWrite = FormatText(document.DocumentElement as XmlElement, "", "");
            return OutputToWrite;
        }

        private string FormatText(XmlElement element, string text, string indent)
        {
            
            foreach (element)

            if (element.Value == "Component")
            {
                text += element.FirstChild.Name + " ";
                text += element.FirstChild.NextSibling.Name + "\r\n";
                return text;
            }

            return text;
            //  text += "<" + node.Name;
            //  if (node.Attributes.Count > 0)
            //  {
            //    AddAttributes(node, ref text);
            //  }
            //  if (node.HasChildNodes)
            //  {
            //    text += ">";
            //    foreach (XmlNode child in node.ChildNodes)
            //    {
            //      text = FormatText(child, text, indent + "  ");
            //    }
            //    if (node.ChildNodes.Count == 1 &&
            //       (node.FirstChild is XmlText || node.FirstChild is XmlComment))
            //      text += "</" + node.Name + ">";
            //    else
            //      text += "\r\n" + indent + "</" + node.Name + ">";
            //  }
            //  else
            //    text += " />";
            //  return text;
            //}

            //private void AddAttributes(XmlNode node, ref string text)
            //{
            //  foreach (XmlAttribute xa in node.Attributes)
            //  {
            //    text += " " + xa.Name + "='" + xa.Value + "'";
            //  }
            //}
        }
    }
 }
