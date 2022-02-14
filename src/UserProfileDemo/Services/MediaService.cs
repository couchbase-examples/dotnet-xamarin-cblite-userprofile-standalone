using System.IO;
using System.Threading.Tasks;
using Xamarin.Essentials;

using UserProfileDemo.Core.Services;
using Xamarin.Forms;

namespace UserProfileDemo.Services
{
    public class MediaService : IMediaService
    {
        public async Task<byte[]> PickPhotoAsync()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                var status = await Permissions.RequestAsync<Permissions.Media>();
                if (status == PermissionStatus.Granted)
                {
                    return await GetPhotoFromMedia();
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return await GetPhotoFromMedia();
            }
        }

        private async Task<byte[]> GetPhotoFromMedia()
        {
            var result = await Xamarin.Essentials.MediaPicker.PickPhotoAsync();
            if (result != null)
            {
                var stream = await result.OpenReadAsync();
                return result != null ? GetBytesFromStream(stream) : null;
            }
            return null;
        }

        byte[] GetBytesFromStream(Stream stream)
        {
            using (var ms = new MemoryStream())
            {
                stream.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}