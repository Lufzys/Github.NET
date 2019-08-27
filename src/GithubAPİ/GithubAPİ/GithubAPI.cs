using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace GithubAPI
{
    // JSON TO CLASS | https://www.jsonutils.com
    public class Users
    {
        #region Fields
        private static string Username;
        private static bool IsGettedUserInfo = false;
        private static UserItems User;
        #endregion

        public static void SelectUser(string username)
        {
            if (Username != username)
            {
                Username = username;
                IsGettedUserInfo = false;
            }
            if (!IsGettedUserInfo)
            {
                GetUserInformation();
            }
        }

        private static bool AnyErrorFix()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com"))
                {
                    if (Username != string.Empty || Username != null || Username != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Exception : " + ex);
                return false;
            }
        }

        #region User Information
        private static void GetUserInformation()
        {
            IsGettedUserInfo = true;

            string json = Methods.GetJsonText("https://api.github.com/users/" + Username);
            User = JsonConvert.DeserializeObject<UserItems>(json);
        }

        public static string LoginName
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.login;
                }
                else
                {
                    return User.login;
                }
            }
        }

        public static int Id
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.id;
                }
                else
                {
                    return User.id;
                }
            }
        }

        public static string AvatarUrl
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.avatar_url;
                }
                else
                {
                    return User.avatar_url;
                }
            }
        }

        public static string ProfileUrl
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.html_url;
                }
                else
                {
                    return User.html_url;
                }
            }
        }

        public static string ProfileType
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.type;
                }
                else
                {
                    return User.type;
                }
            }
        }

        public static string ProfileName
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.name;
                }
                else
                {
                    return User.name;
                }
            }
        }

        public static string Blog
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.blog;
                }
                else
                {
                    return User.blog;
                }
            }
        }

        public static string Location
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.location;
                }
                else
                {
                    return User.location;
                }
            }
        }

        public static string Email
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.email;
                }
                else
                {
                    return User.email;
                }
            }
        }

        public static string Biography
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.bio;
                }
                else
                {
                    return User.bio;
                }
            }
        }

        public static int ReposCount
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.public_repos;
                }
                else
                {
                    return User.public_repos;
                }
            }
        }

        public static int FollowerCount
        {
            get
            {
                if (!IsGettedUserInfo && AnyErrorFix())
                {
                    GetUserInformation();
                    return User.followers;
                }
                else
                {
                    return User.followers;
                }
            }
        }
        #endregion

        #region User Classes

        private class UserItems
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
            public string name { get; set; }
            public object company { get; set; }
            public string blog { get; set; }
            public string location { get; set; }
            public string email { get; set; }
            public object hireable { get; set; }
            public string bio { get; set; }
            public int public_repos { get; set; }
            public int public_gists { get; set; }
            public int followers { get; set; }
            public int following { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
        }

        #endregion
    }

    public class Repository
    {
        #region Fields
        private static string ReposName;
        private static bool IsGettedReposInfo = false;
        private static ReposItems Repos;
        #endregion

        public static void SelectRepository(string reposName)
        {
            if (ReposName != reposName)
            {
                ReposName = reposName;
                IsGettedReposInfo = false;
            }
            if (!IsGettedReposInfo)
            {
                GetReposInformation();
            }
        }

        private static bool AnyErrorFix()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("https://www.google.com"))
                {
                    if (Users.LoginName != string.Empty || Users.LoginName != null || Users.LoginName != "" || ReposName != string.Empty || ReposName != null || ReposName != "")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                //throw new Exception("Exception : " + ex);
                return false;
            }
        }

        #region Repository Information

        private static void GetReposInformation()
        {
            IsGettedReposInfo = true;

            string json = Methods.GetJsonText("https://api.github.com/repos/" + Users.LoginName + "/" + ReposName + "/releases/latest");
            Repos = JsonConvert.DeserializeObject<ReposItems>(json);
        }

        public static int Id
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.id;
                }
                else
                {
                    return Repos.id;
                }
            }
        }

        public static string Name
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.name;
                }
                else
                {
                    return Repos.name;
                }
            }
        }

        public static string Tag
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.tag_name;
                }
                else
                {
                    return Repos.tag_name;
                }
            }
        }

        public static string FileName
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.name;
                    }
                    return string.Empty;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.name;
                    }
                    return string.Empty;
                }
            }
        }

        public static int AuthorId
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.id;
                }
                else
                {
                    return Repos.author.id;
                }
            }
        }

        public static string AuthorName
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.login;
                }
                else
                {
                    return Repos.author.login;
                }
            }
        }

        public static string AuthorAvatarUrl
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.author.avatar_url;
                }
                else
                {
                    return Repos.author.avatar_url;
                }
            }
        }

        public static int LastUploaderId
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.id;
                    }
                    return 0;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.id;
                    }
                    return 0;
                }
            }
        }

        public static string LastUploaderName
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.login;
                    }
                    return string.Empty;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.login;
                    }
                    return string.Empty;
                }
            }
        }

        public static string LastUploaderAvatarUrl
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.avatar_url;
                    }
                    return string.Empty;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.uploader.avatar_url;
                    }
                    return string.Empty;
                }
            }
        }

        public static string LatestReleasesUrl
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.browser_download_url;
                    }
                    return string.Empty;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.browser_download_url;
                    }
                    return string.Empty;
                }
            }
        }

        public static string SourceZip
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.zipball_url;
                }
                else
                {
                    return Repos.zipball_url;
                }
            }
        }

        public static string SourceTar
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    return Repos.tarball_url;
                }
                else
                {
                    return Repos.tarball_url;
                }
            }
        }

        public static int DownloadCount
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.download_count;
                    }
                    return 0;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Assets.download_count;
                    }
                    return 0;
                }
            }
        }

        public static string FileSize
        {
            get
            {
                if (!IsGettedReposInfo && AnyErrorFix())
                {
                    GetReposInformation();
                    foreach (var Assets in Repos.assets)
                    {
                        return Methods.FormatBytes(Assets.size);
                    }
                    return string.Empty;
                }
                else
                {
                    foreach (var Assets in Repos.assets)
                    {
                        return Methods.FormatBytes(Assets.size);
                    }
                    return string.Empty;
                }
            }
        }

        #endregion

        #region Repository Classes
        private class Author
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        private class Uploader
        {
            public string login { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string avatar_url { get; set; }
            public string gravatar_id { get; set; }
            public string url { get; set; }
            public string html_url { get; set; }
            public string followers_url { get; set; }
            public string following_url { get; set; }
            public string gists_url { get; set; }
            public string starred_url { get; set; }
            public string subscriptions_url { get; set; }
            public string organizations_url { get; set; }
            public string repos_url { get; set; }
            public string events_url { get; set; }
            public string received_events_url { get; set; }
            public string type { get; set; }
            public bool site_admin { get; set; }
        }

        private class Asset
        {
            public string url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string name { get; set; }
            public object label { get; set; }
            public Uploader uploader { get; set; }
            public string content_type { get; set; }
            public string state { get; set; }
            public int size { get; set; }
            public int download_count { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string browser_download_url { get; set; }
        }

        private class ReposItems
        {
            public string url { get; set; }
            public string assets_url { get; set; }
            public string upload_url { get; set; }
            public string html_url { get; set; }
            public int id { get; set; }
            public string node_id { get; set; }
            public string tag_name { get; set; }
            public string target_commitish { get; set; }
            public string name { get; set; }
            public bool draft { get; set; }
            public Author author { get; set; }
            public bool prerelease { get; set; }
            public DateTime created_at { get; set; }
            public DateTime published_at { get; set; }
            public IList<Asset> assets { get; set; }
            public string tarball_url { get; set; }
            public string zipball_url { get; set; }
            public string body { get; set; }
        }

        #endregion
    }

    internal class Methods
    {
        public static string GetJsonText(string JSON)
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)WebRequest.Create(JSON);
            myHttpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36";
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            Stream streamResponse = myHttpWebResponse.GetResponseStream();

            //string DownloadedData = new WebClient().DownloadString(JSON);
            using (StreamReader r = new StreamReader(streamResponse))
            {
                string json = r.ReadToEnd();
                return json;
            }
        }

        public static string FormatBytes(long bytes)
        {
            string[] Suffix = { "B", "KB", "MB", "GB", "TB" };
            int i;
            double dblSByte = bytes;
            for (i = 0; i < Suffix.Length && bytes >= 1024; i++, bytes /= 1024)
            {
                dblSByte = bytes / 1024.0;
            }

            return String.Format("{0:0.##} {1}", dblSByte, Suffix[i]);
        }
    }
}
