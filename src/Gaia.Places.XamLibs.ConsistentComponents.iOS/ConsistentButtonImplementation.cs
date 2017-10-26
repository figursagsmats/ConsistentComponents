using Gaia.Places.XamLibs.ConsistentComponents.Abstractions;
using System;
using Xamarin.Forms;
using Gaia.Places.XamLibs.ConsistentComponents.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ConsistentComponents.Abstractions.ConsistentButton), typeof(ConsistentButtonRenderer))]
namespace Gaia.Places.XamLibs.ConsistentComponents.iOS
{
    /// <summary>
    /// ConsistentComponents Renderer
    /// </summary>
    public class ConsistentButtonRenderer : ButtonRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        ConsistentButton _element;

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            System.Diagnostics.Debug.WriteLine(">>>>>>>>> OnElementChanged:  ConsistentButtonButtonRenderer <<<<<<<<");

            _element = (ConsistentButton)this.Element;
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                //Subrscribe to the events stuff
            }
            else if (e.OldElement != null)
            {
                //Unsubscribe from events
            }

        }
    }
}
