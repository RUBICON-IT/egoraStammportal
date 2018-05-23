/*************************
Diese Software ist ein Beispiel (sample code) und unterliegt der Microsoft Public License. 
Die Verwendung des Codes ist unter den Bedingungen der Microsoft Public License erlaubt.
*************************
This software is sample code and is subject to the Microsoft Public License. 
You may use this code according to the conditions of the Microsoft Public License.
*************************/
using System.IO;
using System.Xml.Serialization;

namespace Egora.Stammportal.LdapAuthorizationService
{
  [XmlRoot(ElementName = "Configuration", Namespace = LdapConfiguration.Namespace, IsNullable = false)]
  public class LdapConfiguration
  {
    public const string Namespace = "http://www.egora.at/Stammportal/LdapConfiguration/1.1";

    private static LdapConfiguration s_configuration = null;
    private static object s_configurationLock = new object();

    public static LdapConfiguration GetConfiguration(bool reload)
    {
      if (s_configuration == null || reload)
      {
        lock (s_configurationLock)
        {
          string configurationFileName = Properties.Settings.Default.ConfigFile;
          XmlSerializer serializer = new XmlSerializer(typeof (LdapConfiguration));
          using (StreamReader f = File.OpenText(configurationFileName))
          {
            s_configuration = (LdapConfiguration) serializer.Deserialize(f);
          }
        }
      }
      return s_configuration;
    }

    public static LdapConfiguration GetConfiguration()
    {
      return GetConfiguration(false);
    }


    public LdapConfiguration()
    {
    }

    private ApplicationConfiguration[] _applications;

    [XmlElement("Application")]
    public ApplicationConfiguration[] Applications
    {
      get { return _applications; }
      set { _applications = value; }
    }

    [XmlIgnore]
    public ApplicationConfiguration GlobalApplication
    {
      get
      {
        foreach (ApplicationConfiguration app in Applications)
        {
          if (app.Name == "Global")
            return app;
        }
        return null;
      }
    }

    public ApplicationConfiguration GetApplication(string rootUrl)
    {
      foreach (ApplicationConfiguration app in Applications)
      {
        if (app.IsWeb(rootUrl) || app.IsSoap(rootUrl) || app.IsSaml(rootUrl))
          return app;
      }
      return null;
    }
  }
}