using System;
using System.Configuration;
using System.Collections;

namespace URLRewriter.Config
{
    // Define a custom section containing a simple element and a collection of the same element.
    // It uses two custom types: UrlsCollection and UrlsConfigElement.
    /// <summary>
    /// 
    /// </summary>
    public class UrlsConfig
    {
        public static UrlsSection GetConfig()
        {
            return (UrlsSection)System.Configuration.ConfigurationManager.GetSection("CustomConfiguration");
        }

    }

/// <summary>
/// 
/// </summary>
    public class UrlsSection : ConfigurationSection
    {
        [ConfigurationProperty("urls", IsDefaultCollection = false)]
        public UrlsCollection Urls
        {
            get
            {
                return (UrlsCollection)this["urls"];
            }
        }
    }
    
    // Define the UrlsCollection that contains UrlsConfigElement elements.
    /// <summary>
    /// 
    /// </summary>
    public class UrlsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new UrlConfigElement();
        }
        protected override Object GetElementKey(ConfigurationElement element)
        {
            return ((UrlConfigElement)element).VirtualUrl;
        }

        public UrlConfigElement this[int index]
        {
            get
            {
                return (UrlConfigElement)BaseGet(index);
            }
        }

    }

    // Define the UrlConfigElement.
    /// <summary>
    /// 
    /// </summary>
    public class UrlConfigElement : ConfigurationElement
    {


        [ConfigurationProperty("virtualUrl", IsRequired = true)]
        public string VirtualUrl
        {
            get
            {
                return (string)this["virtualUrl"];
            }
            set
            {
                this["virtualUrl"] = value;
            }
        }

        [ConfigurationProperty("destinationUrl", IsRequired = true)]
        public string DestinationUrl
        {
            get
            {
                return (string)this["destinationUrl"];
            }
            set
            {
                this["destinationUrl"] = value;
            }
        }
    }
}