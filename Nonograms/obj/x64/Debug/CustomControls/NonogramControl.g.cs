﻿#pragma checksum "C:\Users\Grigory\Documents\Visual Studio 2015\Projects\Nonograms\Nonograms\CustomControls\NonogramControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "68A302037EC0374FBA0C4E56ACCC2A7C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nonograms.CustomControls
{
    partial class NonogramControl : 
        global::Windows.UI.Xaml.Controls.UserControl, 
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
                    this.FieldGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    #line 80 "..\..\..\CustomControls\NonogramControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.FieldGrid).Tapped += this.BaseFieldGrid_Tapped;
                    #line 80 "..\..\..\CustomControls\NonogramControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.FieldGrid).PointerEntered += this.FieldGrid_PointerEntered;
                    #line 80 "..\..\..\CustomControls\NonogramControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.FieldGrid).PointerExited += this.FieldGrid_PointerExited;
                    #line 80 "..\..\..\CustomControls\NonogramControl.xaml"
                    ((global::Windows.UI.Xaml.Controls.Grid)this.FieldGrid).PointerReleased += this.FieldGrid_PointerReleased;
                    #line default
                }
                break;
            case 2:
                {
                    this.CornerGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.LeftSideGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.TopSideGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5:
                {
                    this.HorizontalAimRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
                }
                break;
            case 6:
                {
                    this.VerticalAimRectangle = (global::Windows.UI.Xaml.Shapes.Rectangle)(target);
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

