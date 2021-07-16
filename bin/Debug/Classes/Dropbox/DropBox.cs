using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dropbox.Api.Files;
using Dropbox.Api.Sharing;
using Dropbox.Api;
using System.IO;

namespace POS_ADET.Classes.Dropbox
{
    class DropBox
    {
        static string token = "76U25qnke-kAAAAAAAAAAe1QeJTgKgEcKWuiF32nfTYjSBiyaqi0mmKbapQpQ5vT";

       
        public async Task<string> Upload(string file, string folder, string filename)
        {
            Console.WriteLine("Upload Called");
            using (var dbx = new DropboxClient(token))
            {
                //string file = @"C:\Users\Zeke\Pictures\icons\products\iphone.jpg";
                //string folder = "/Items";
                //string filename = "iphone.jpg";
                string url = "";
                using (var mem = new MemoryStream(File.ReadAllBytes(file)))
                {
                    var updated = dbx.Files.UploadAsync(folder + "/" + filename, WriteMode.Overwrite.Instance, body: mem);
                    updated.Wait();
                    var tx = dbx.Sharing.CreateSharedLinkWithSettingsAsync(folder + "/" + filename);
                    tx.Wait();
                    url = tx.Result.Url;
                }
                return await Task.FromResult(url);
            }
            //var dbx = new DropboxClient(token);
            //using (var mem = new MemoryStream(File.ReadAllBytes(file)))
            //{
            //    var updated = await dbx.Files.UploadAsync(
            //        folder + "/" + file,
            //        WriteMode.Overwrite.Instance,
            //        body: mem);
            //    Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev);
            //}

        }
    }
}
