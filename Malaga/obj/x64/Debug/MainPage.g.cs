﻿#pragma checksum "C:\Users\glagl\documents\visual studio 2015\Projects\Malaga\Malaga\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6E66543F49E31A17A407FE70D3106C04"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Malaga
{
    partial class MainPage : 
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
                    this.rootPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 2:
                {
                    this.mainMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                    #line 30 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.mainMap).Tapped += this.mainMap_Tapped;
                    #line 31 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Maps.MapControl)this.mainMap).MapElementClick += this.mainMap_MapElementClick;
                    #line default
                }
                break;
            case 3:
                {
                    this.scrollview = (global::Windows.UI.Xaml.Controls.ScrollViewer)(target);
                }
                break;
            case 4:
                {
                    this.pointGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.AddButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 100 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddButton).Click += this.AddButton_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.boxName = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 7:
                {
                    this.boxDesc = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 8:
                {
                    this.typeSelect = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 9:
                {
                    this.UpdateButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 74 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.UpdateButton).Click += this.UpdateButton_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.DeleteButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.DeleteButton).Click += this.DeleteButton_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.HideButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 78 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HideButton).Click += this.HideButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    this.latBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 13:
                {
                    this.LonBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 14:
                {
                    this.streetBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 15:
                {
                    this.townBox = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 16:
                {
                    this.toggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 121 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.toggle).Checked += this.AppBarToggleButton_Checked;
                    #line 121 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.toggle).Unchecked += this.AppBarToggleButton_Checked;
                    #line default
                }
                break;
            case 17:
                {
                    this.followToggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 122 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.followToggle).Click += this.followToggle_Click;
                    #line default
                }
                break;
            case 18:
                {
                    this.trafficToggle = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)(target);
                    #line 123 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.trafficToggle).Click += this.trafficToggle_Click;
                    #line default
                }
                break;
            case 19:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element19 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 128 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element19).Click += this.FlyoutSelectBar;
                    #line default
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element20 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 129 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element20).Click += this.FlyoutSelectClub;
                    #line default
                }
                break;
            case 21:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element21 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 130 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element21).Click += this.FlyoutSelectRest;
                    #line default
                }
                break;
            case 22:
                {
                    global::Windows.UI.Xaml.Controls.MenuFlyoutItem element22 = (global::Windows.UI.Xaml.Controls.MenuFlyoutItem)(target);
                    #line 131 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.MenuFlyoutItem)element22).Click += this.FlyoutSelectAll;
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

