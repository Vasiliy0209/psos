using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Xml.Serialization;

namespace FromScratch
{
    [ServiceContract]
    [XmlSerializerFormat]
    public interface VK_API
    {
        [WebGet(UriTemplate = "method/wall.post.xml?owner_id={owner_id}&message={message}&access_token={access_token}&v=5.70", BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Xml)]
        VK_Response WallPost(string owner_id,string message,string access_token);
    }

    [XmlRoot("response")]
    public class VK_Response
    {
        [XmlElement("post_id")]
        public string post_id;
    }

    [XmlRoot("error")]
    public class VK_Error
    {
        [XmlElement("error_code")]
        public string error_code;
        [XmlElement("error_msg")]
        public string error_msg;
    }

    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<VK_API> vk_api = new ChannelFactory<VK_API>("VK_ENDPOINT");
            var proxy = vk_api.CreateChannel();
            //try
           // {
            VK_Response err = proxy.WallPost("219075416", "Hello for new", "3cbb198a478c09697612a7851caba9556827d128925c7c991dfa1b64d2a017c14593ee1b2d6a09f902d01");
            Console.WriteLine(err.post_id);
            Console.ReadLine();
                //}
           // catch(System.Runtime.Serialization.SerializationException ex)
           // {
             //   ex.
            //}
            ((IDisposable)vk_api).Dispose();
        }
    }
}
