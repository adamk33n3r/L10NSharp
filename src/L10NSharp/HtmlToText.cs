#region

using System.IO;
using HtmlAgilityPack;
using System.Collections.Generic;
#endregion

namespace SampleApp
{
    public class Node
    {
        public string node_hierarchy, content;
        public Node(string node_hierarchy, string content)
        {
            this.node_hierarchy = node_hierarchy;
            this.content = content;
        }
    }
    public class HtmlToText
    {
        #region Public Methods

        public List<Node> ConvertHtmlFile(string path)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.Load(path);

            List<Node> list = new List<Node>();
            ConvertTo(doc.DocumentNode, list);
            return list;
        }

        public List<Node> ConvertHtmlString(string html)
        {
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            List<Node> list = new List<Node>();
            ConvertTo(doc.DocumentNode, list);
            return list;
        }

        public void ConvertTo(HtmlNode node, List<Node> outText)
        {
            string html;
            
            switch (node.NodeType)
            {
                case HtmlNodeType.Comment:
                    // don't output comments
                    break;

                case HtmlNodeType.Document:
                    ConvertContentTo(node, outText);
                    break;

                case HtmlNodeType.Text:
                    // script and style must not be output
                    string parentName = node.ParentNode.Name;
                    if ((parentName == "script") || (parentName == "style"))
                        break;

                    // get text
                    html = ((HtmlTextNode)node).Text;

                    // is it in fact a special closing node output as text?
                    if (HtmlNode.IsOverlappedClosingElement(html))
                        break;

                    // check the text is meaningful and not a bunch of whitespaces
                    if (html.Trim().Length > 0)
                    {
                        string path = node.XPath.Replace('/','.');
                        path = path.Substring(1, path.Length - 10);
                        outText.Add(new Node(path, HtmlEntity.DeEntitize(html)));
                    }
                    break;

                case HtmlNodeType.Element:
                    switch (node.Name)
                    {
                        case "p":
                            // treat paragraphs as crlf
                            //outText.Write("\r\n");
                            break;
                    }

                    if (node.HasChildNodes)
                    {
                        ConvertContentTo(node, outText);
                    }
                    break;
            }
        }

        #endregion

        #region Private Methods

        private void ConvertContentTo(HtmlNode node, List<Node> outText)
        {
            foreach (HtmlNode subnode in node.ChildNodes)
            {
                ConvertTo(subnode, outText);
            }
        }

        #endregion
    }
}

