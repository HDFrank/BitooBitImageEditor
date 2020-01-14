﻿using UIKit;
using BitooBitImageEditor.Controls;
using Xamarin.Forms;
using BitooBitImageEditor.IOS.Renders;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRender))]
namespace BitooBitImageEditor.IOS.Renders
{
    class CustomEditorRender : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.TextAlignment = UITextAlignment.Center;
            }
        }
    }
}