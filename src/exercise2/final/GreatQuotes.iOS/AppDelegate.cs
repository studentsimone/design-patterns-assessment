using Foundation;
using GreatQuotes.Data;
using UIKit;

namespace GreatQuotes.iOS {
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        readonly SimpleContainer container = new SimpleContainer();

        public override bool FinishedLaunching(UIApplication uiApplication, NSDictionary launchOptions)
        {
            container.Register<IQuoteLoader, QuoteLoader>();
            container.Register<ITextToSpeech, TextToSpeechService>();
            container.Create<QuoteManager>();

            global::Xamarin.Forms.Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(uiApplication, launchOptions);
        }
    }
}
