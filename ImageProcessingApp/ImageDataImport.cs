using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ImageProcessingApp
{
    class ImageDataImport
    {
        public static async Task<RootObject> GetSearchImageData(string queryString, int pageNumber)
        {
            string temp = $"https://api.unsplash.com/search/photos?page={pageNumber}&per_page=9&query={queryString}&client_id=ac9a9267e02fed66bad717e4f1c5c7b1374ef9aff855d4c564baef488adf3e05";

            var http = new HttpClient();
            var response = await http.GetAsync(temp);
            var result = await response.Content.ReadAsStringAsync();
            var ms = new MemoryStream(Encoding.UTF8.GetBytes(result));

            var serializer = new DataContractJsonSerializer(typeof(RootObject));
            var data = (RootObject)serializer.ReadObject(ms);

            return data;
        }
    }
    [DataContract]
    public class Urls
    {
        [DataMember]
        public string raw { get; set; }
        [DataMember]
        public string full { get; set; }
        [DataMember]
        public string regular { get; set; }
        [DataMember]
        public string small { get; set; }
        [DataMember]
        public string thumb { get; set; }
    }
    [DataContract]
    public class Links
    {
        [DataMember]
        public string self { get; set; }
        [DataMember]
        public string html { get; set; }
        [DataMember]
        public string download { get; set; }
        [DataMember]
        public string download_location { get; set; }
    }
    [DataContract]
    public class Links2
    {
        [DataMember]
        public string self { get; set; }
        [DataMember]
        public string html { get; set; }
        [DataMember]
        public string photos { get; set; }
        [DataMember]
        public string likes { get; set; }
        [DataMember]
        public string portfolio { get; set; }
        [DataMember]
        public string following { get; set; }
        [DataMember]
        public string followers { get; set; }
    }
    [DataContract]
    public class ProfileImage
    {
        [DataMember]
        public string small { get; set; }
        [DataMember]
        public string medium { get; set; }
        [DataMember]
        public string large { get; set; }
    }
    [DataContract]
    public class User
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string updated_at { get; set; }
        [DataMember]
        public string username { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string first_name { get; set; }
        [DataMember]
        public string last_name { get; set; }
        [DataMember]
        public string twitter_username { get; set; }
        [DataMember]
        public string portfolio_url { get; set; }
        [DataMember]
        public string bio { get; set; }
        [DataMember]
        public string location { get; set; }
        [DataMember]
        public Links2 links { get; set; }
        [DataMember]
        public ProfileImage profile_image { get; set; }
        [DataMember]
        public string instagram_username { get; set; }
        [DataMember]
        public int total_collections { get; set; }
        [DataMember]
        public int total_likes { get; set; }
        [DataMember]
        public int total_photos { get; set; }
    }
    [DataContract]
    public class Tag
    {
        [DataMember]
        public string title { get; set; }
    }
    [DataContract]
    public class PhotoTag
    {
        [DataMember]
        public string title { get; set; }
    }
    [DataContract]
    public class Result
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string created_at { get; set; }
        [DataMember]
        public string updated_at { get; set; }
        [DataMember]
        public int width { get; set; }
        [DataMember]
        public int height { get; set; }
        [DataMember]
        public string color { get; set; }
        [DataMember]
        public string description { get; set; }
        [DataMember]
        public Urls urls { get; set; }
        [DataMember]
        public Links links { get; set; }
        [DataMember]
        public List<object> categories { get; set; }
        [DataMember]
        public bool sponsored { get; set; }
        [DataMember]
        public int likes { get; set; }
        [DataMember]
        public bool liked_by_user { get; set; }
        [DataMember]
        public List<object> current_user_collections { get; set; }
        [DataMember]
        public object slug { get; set; }
        [DataMember]
        public User user { get; set; }
        [DataMember]
        public List<Tag> tags { get; set; }
        [DataMember]
        public List<PhotoTag> photo_tags { get; set; }
    }
    [DataContract]
    public class RootObject
    {
        [DataMember]
        public int total { get; set; }
        [DataMember]
        public int total_pages { get; set; }
        [DataMember]
        public List<Result> results { get; set; }
    }
}
