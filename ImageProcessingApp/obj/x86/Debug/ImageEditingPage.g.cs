﻿#pragma checksum "C:\Users\Corban\Documents\Visual Studio 2017\Projects\ImageProcessingApp\ImageProcessingApp\ImageEditingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DB1333FC6AFB2D65580BC1335934678"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageProcessingApp
{
    partial class ImageEditingPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.EffectButton1 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 39 "..\..\..\ImageEditingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.EffectButton1).Click += this.EffectButton1_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.EffectButton2 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 3:
                {
                    this.EffectButton4 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 4:
                {
                    this.EffectButton3 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 5:
                {
                    this.EffectButton5 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                }
                break;
            case 6:
                {
                    this.CurrentImage = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7:
                {
                    this.BackButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 23 "..\..\..\ImageEditingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.BackButton).Click += this.BackButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.SaveButton = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 24 "..\..\..\ImageEditingPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.SaveButton).Click += this.SaveButton_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

