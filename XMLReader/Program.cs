using System;
using System.Xml;

namespace XMLReader
{
    class Program
    {

        void AddingAndCreatingXML_Doc()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<item><name>wrench</name></item>");

            // Add a price element 
            XmlElement newElement = doc.CreateElement("price");
            newElement.InnerText = "10.95";
            doc.DocumentElement.AppendChild(newElement);


            // Writing XML to file 
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            // Save a doc to a file and auto-indent the output
            XmlWriter writer = XmlWriter.Create("data.xml", settings);
            doc.Save(writer);

        }// end AddingAndCreatingXML_Doc()


        XmlNode GetXMLNode (string nodeName, XmlDocument doc)
        {
            return doc.DocumentElement.GetAttributeNode(nodeName); 

        }// end GetNode()

        void XMLStringReader ()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml("<book ISBN='1-861001-57-5' year='07-July-2019'>" +
                            "<title titleAttribute1='title 1' titleAttribute2='title 2' titleAttribute3='title 3'>Pride And Prejudice</title>" +
                            "<price priceAttribute1='price 1' priceAttribute2='price 2'>19.95</price>" +
                            "<hp>HP Computer</hp>" +
                            "<coffee coffee_attr1='cappucino' coffee_attr2='mocca' coffee_attr3='flatwhite'>Price: Not Available</coffee>" +
                        "</book>");


            // Get by ISBN 
            var getBook = GetXMLNode("ISBN", doc);
            Console.WriteLine($"ISBN: {getBook.Name} {getBook.Value}");

            getBook = GetXMLNode("year", doc);
            Console.WriteLine($"year: {getBook.Name} {getBook.Value}");

            Console.WriteLine("\n\n");
            Console.WriteLine(doc.DocumentElement.OuterXml); // Getting the whole XML string
            Console.WriteLine("\n\n");


            XmlNode root = doc.FirstChild;
            Console.WriteLine($"Root Last Child: {root.LastChild.OuterXml}");
            Console.WriteLine("\n\n");


            /// Creating a new Attribute 
            string ns = root.GetNamespaceOfPrefix("location");
            XmlNode attr = doc.CreateNode(XmlNodeType.Attribute, "location", ns);
            attr.Value = "NZ";

            /// Adding the attribute to doc 
            root.Attributes.SetNamedItem(attr);

            getBook = GetXMLNode("location", doc);
            Console.WriteLine($"location: {getBook.Name} {getBook.Value}");
            Console.WriteLine(doc.DocumentElement.OuterXml); // Getting the whole XML string
            
            Console.WriteLine("\n\n");

            //Display the contents of the child nodes.
            if (root.HasChildNodes)
            {
                for (int i = 0; i < root.ChildNodes.Count; i++)
                {
                    Console.WriteLine(root.ChildNodes[i].InnerText);
                }
            }

            Console.WriteLine("\n\n");


            /// Looping with Attributes and Inner text of all the nodes 
            if (root.HasChildNodes)
            {
                foreach (XmlElement element in root.ChildNodes)
                {
                    XmlAttributeCollection xmlAttributeCollection = element.Attributes;

                    foreach (XmlAttribute attribute in xmlAttributeCollection)
                    {
                        if (attribute.Value.Equals("title 1")) Console.WriteLine("[1] Found an attribute");
                        if (attribute.Value == "title 1") Console.WriteLine("[2] Found an attribute");

                        Console.WriteLine($"{attribute.Name} {attribute.Value}");
                    }

                    Console.WriteLine($"Inner Text : {element.InnerText}\n\n");

                }// end for
            }// end if 

            /// Change the price of the last child 
            root.LastChild.InnerText = "1000.99";
            Console.WriteLine($"Root Last Child: {root.LastChild.OuterXml}");


        }// end XMLStringReader()

        void XML_FileReader(string fileName)
        {
            XmlDocument doc = new XmlDocument();


            /// Loading XML File 
            XmlTextReader xmlTextReader = new XmlTextReader(fileName);
            xmlTextReader.WhitespaceHandling = WhitespaceHandling.None;
            xmlTextReader.MoveToContent();
            //xmlTextReader.Read(); 

            doc.Load(xmlTextReader);
            doc.Save(Console.Out); // Displaying on console
            Console.WriteLine($"\n====================================================\n");


            XmlNode root = doc.FirstChild; 

            if (root.HasChildNodes)
            {
                foreach (XmlElement element in root.ChildNodes)
                {
                    Console.WriteLine($"{element.Value}");

                    XmlAttributeCollection xmlAttributeCollection = element.Attributes;

                    // Reading the attributes 
                    foreach (XmlAttribute attribute in xmlAttributeCollection)
                    {
                        Console.WriteLine($"{attribute.Name} > {attribute.Value}");

                    }// end foreach



                    foreach (XmlElement xmlInnerText in element.ChildNodes)
                    {
                        Console.WriteLine($"{xmlInnerText.InnerText}");
                    }

                    Console.WriteLine($"====================================================");

                }// end foreach


            }// end if 

        }// end XML_FileReader()



        static void Main(string[] args)
        {
            var app = new Program();

            // app.AddingAndCreatingXML_Doc();  // Working 
            //app.XMLStringReader();

            app.XML_FileReader(@"E:\Programing\C#\TechnicalTestPreparation\XMLReader\books.xml");



            Console.WriteLine("\n\nProgram Finished ...");

        }
    }
}
