using Android.App;
using Android.Widget;
using Android.OS;

namespace Instagram.Media.Downloader
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var mediaUrlEditText = FindViewById<EditText>(Resource.Id.mediaUrl);

            mediaUrlEditText.Click += (sender, args) =>
            {
                if (mediaUrlEditText.Text == Resources.GetString(Resource.String.default_media_url))
                    mediaUrlEditText.Text = string.Empty;
            };

            var downloadButton = FindViewById<Button>(Resource.Id.download);

            downloadButton.Click += (sender, args) =>
            {
                var mediaUrl = mediaUrlEditText.Text;
                if (!string.IsNullOrEmpty(mediaUrl))
                {

                }
                else
                {
                    Toast.MakeText(this, "Media url should not be empty.", ToastLength.Long).Show();
                }
            };
        }
    }
}

