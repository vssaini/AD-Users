using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Drawing;
using System.IO;

namespace ADUsers.Code
{
    class ADUtilities
    {
        /// <summary>
        /// Initialize retrieving of AD users.
        /// </summary>
        /// <param name="domainController">Name of domain</param>
        /// <param name="paths">Array of paths</param>
        /// <param name="username">Username to access AD</param>
        /// <param name="password">Password for accessing AD</param>
        /// <param name="bgWorker">Background worker to be used for progress reporting</param>
        /// <param name="totalUsers">Total number of users imported.</param>
        public static List<ADPhotoUser> InitiateRetrievingADUsers(string domainController, string[] paths, string username, string password, BackgroundWorker bgWorker, ref int totalUsers)
        {
            PrincipalContext principalContext;

            var adUsers = new List<ADPhotoUser>();

            if (paths != null)
            {
                foreach (var path in paths)
                {
                    principalContext = new PrincipalContext(ContextType.Domain, domainController, path, username, password);
                    var users = GetAllADUsers(principalContext, bgWorker, ref totalUsers);
                    adUsers.AddRange(users);
                }
            }
            else
            {
                principalContext = new PrincipalContext(ContextType.Domain, domainController, username, password);
                var users = GetAllADUsers(principalContext, bgWorker, ref totalUsers);
                adUsers.AddRange(users);
            }

            return adUsers;
        }

        /// <summary>
        /// Get all AD users for specified domain and OU path.
        /// </summary>
        /// <param name="principalContext">Principal Context object</param>
        /// <param name="bgWorker">Background worker to be used for progress reporting</param>
        /// <param name="totalUsers">Total number of users imported</param>
        public static List<ADPhotoUser> GetAllADUsers(PrincipalContext principalContext, BackgroundWorker bgWorker, ref int totalUsers)
        {
            Image jpgPhoto = Properties.Resources.NonPhotoUser;
            Image thumbPhoto = Properties.Resources.NonPhotoUser;
            var users = new List<ADPhotoUser>();

            using (principalContext)
            {
                bgWorker.ReportProgress(0, "Looking for domain users...");

                var userPrincipal = new UserPrincipal(principalContext);
                var principalSearcher = new PrincipalSearcher(userPrincipal);
                var principals = principalSearcher.FindAll();

                foreach (var principal in principals)
                {
                    totalUsers++;
                    bgWorker.ReportProgress(0, string.Format("Retrieving user '{0}' details (Total retrieved: {1})", principal.DisplayName, totalUsers));

                    using (var deUser = principal.GetUnderlyingObject() as DirectoryEntry)
                    {
                        if (deUser != null)
                        {
                            if (deUser.Properties.Contains("jpegPhoto"))
                            {
                                var jpeg = deUser.Properties["jpegPhoto"].Value as byte[];
                                jpgPhoto = GetUserPicture(jpeg);
                            }

                            if (deUser.Properties.Contains("thumbnailPhoto"))
                            {
                                var thumb = deUser.Properties["thumbnailPhoto"].Value as byte[];
                                thumbPhoto = GetUserPicture(thumb);
                            }
                        }
                    }

                    // Add obtained details to list
                    users.Add(new ADPhotoUser { UserName = principal.SamAccountName, FullName = principal.DisplayName, JpegPhoto = jpgPhoto, ThumbPhoto = thumbPhoto });

                    // Reset photos to default to avoid mess
                    jpgPhoto = thumbPhoto = Properties.Resources.NonPhotoUser;
                }

                return users;
            }
        }

        /// <summary>
        /// Get image for user or default image if not found.
        /// </summary>
        /// <param name="image">Image bytes</param>
        static Image GetUserPicture(byte[] image)
        {
            if (image == null) return Properties.Resources.NonPhotoUser;
            using (var ms = new MemoryStream(image))
            {
                return Image.FromStream(ms);
            }
        }
    }

    public class ADPhotoUser
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public Image JpegPhoto { get; set; }
        public Image ThumbPhoto { get; set; }
    }
}
