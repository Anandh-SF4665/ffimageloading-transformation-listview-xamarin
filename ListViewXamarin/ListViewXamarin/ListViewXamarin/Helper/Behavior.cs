using FFImageLoading.Forms;
using FFImageLoading.Transformations;
using Syncfusion.DataSource.Extensions;
using Syncfusion.GridCommon.ScrollAxis;
using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Control.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewXamarin
{
    public class Behavior : Behavior<CachedImage>
    {
        #region Fields
        CachedImage FFImage;
        #endregion

        #region Overrides
        protected override void OnAttachedTo(CachedImage bindable)
        {
            FFImage = bindable;

            var tapGesture = new TapGestureRecognizer();
            tapGesture.Tapped += TapGesture_Tapped;
            FFImage.GestureRecognizers.Add(tapGesture);
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(CachedImage bindable)
        {
            FFImage = null;
            base.OnDetachingFrom(bindable);
        }
        #endregion

        #region Call back
        private void TapGesture_Tapped(object sender, EventArgs e)
        {
            var blurredTransformation = FFImage.Transformations[0] as BlurredTransformation;
            if (blurredTransformation.Radius == 20) blurredTransformation.Radius = 0;
            else blurredTransformation.Radius = 20;

            FFImage.ReloadImage();
        }
        #endregion
    }
}