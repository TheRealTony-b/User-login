using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace User_login
{
    class GenerateXML
    {
        Register register = new Register();
        public static String Node1 = "Users";
        public static String Node2 = "User";
        public static String password = "UserPassword";
        public static String userName = "UserName";
        public static String nomFichier =  "User.xml";
        public static void createXML()
        {

            XmlDocument doc = new XmlDocument();

            //(1) the xml declaration is recommended, but not mandatory
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);

            //(2) string.Empty makes cleaner code

            XmlElement element1 = doc.CreateElement(Node1);
            doc.AppendChild(element1);

            XmlElement element2 = doc.CreateElement(Node2);
            element1.AppendChild(element2);

            XmlElement element3 = doc.CreateElement(userName);
            XmlText text1 = doc.CreateTextNode(User.finalusername);
            element3.AppendChild(text1);
            element2.AppendChild(element3);

            XmlElement element4 = doc.CreateElement(string.Empty, password, string.Empty);
            XmlText text2 = doc.CreateTextNode(User.finalpass);
            element4.AppendChild(text2);
            element2.AppendChild(element4);
            User.filePath = User.filePath + "\\" + nomFichier;
            doc.Save(User.filePath);
        }


        public void editxmL()
        {
            String varTemp = "";
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(User.filePath);
            }
            catch (Exception e)
            {// Le fichier n'existe pas.. on crée le fichier avec le nouvel enregistrement
                createXML();

                return;
            }
            XmlNodeList userNodes = xmlDoc.SelectNodes("//"+Node1+"/"+Node2);
            foreach (XmlNode userNode in userNodes)
            {
                string username = userNode[userName].InnerText;
                if (username == User.finalusername)
                {
                    // Update le password


                    userNode[password].InnerText = User.finalpass;
                    xmlDoc.Save(User.filePath);
                    varTemp = "trouve";
                    break;
                }


            }
            if (varTemp == "")
            {// Ajout d'un nouvel élément dans le fichier déjà existant
                XmlNode appinfo = xmlDoc[Node1].AppendChild(xmlDoc.CreateElement(Node2));
                appinfo.AppendChild(xmlDoc.CreateElement(userName)).AppendChild(xmlDoc.CreateTextNode(User.finalusername));
                appinfo.AppendChild(xmlDoc.CreateElement(password)).AppendChild(xmlDoc.CreateTextNode(User.finalpass));

                xmlDoc.Save(User.filePath);
            }

        }
        public String readxmL()
        {
            XmlDocument xmlDoc = new XmlDocument();
            try
            {
                xmlDoc.Load(User.filePath);
            }
            catch (Exception e)
            {// Le fichier n'existe pas.. on crée le fichier avec le nouvel enregistrement
               

                return e.Message;
            }
            XmlNodeList userNodes = xmlDoc.SelectNodes("//" + Node1 + "/" + Node2);
            foreach (XmlNode userNode in userNodes)
            {
                string username = userNode[userName].InnerText;
                string userpassword = userNode[password].InnerText;
                if (username == User.finalusername && userpassword == User.finalpass) 
                {
                    // Update le password


                    return "good";
                                    
                                  }

                
            }
            return "";
        }
    }
}

