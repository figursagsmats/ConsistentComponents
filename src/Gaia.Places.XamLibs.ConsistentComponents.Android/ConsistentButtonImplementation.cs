using Gaia.Places.XamLibs.ConsistentComponents.Abstractions;
using System;
using Xamarin.Forms;
using Gaia.Places.XamLibs.ConsistentComponents.Android;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ConsistentComponents.Abstractions.ConsistentButton), typeof(ConsistentButtonRenderer))]
namespace Gaia.Places.XamLibs.ConsistentComponents.Android
{
    /// <summary>
    /// ConsistentComponents Renderer
    /// </summary>
    /// 
    public class ConsistentButtonRenderer : ButtonRenderer
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        ConsistentButton _element;

        public static void Init() { }

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