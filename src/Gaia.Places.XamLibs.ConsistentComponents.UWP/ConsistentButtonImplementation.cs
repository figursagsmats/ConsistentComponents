using Gaia.Places.XamLibs.ConsistentComponents.Abstractions;
using Gaia.Places.XamLibs.ConsistentComponents.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Platform.UWP;


[assembly: ExportRenderer(typeof(Gaia.Places.XamLibs.ConsistentComponents.Abstractions.ConsistentButton), typeof(ConsistentButtonRenderer))]

namespace Gaia.Places.XamLibs.ConsistentComponents.UWP
{
    class ConsistentButtonRenderer : ButtonRenderer
    {
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
