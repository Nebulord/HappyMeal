﻿#pragma checksum "C:\Users\Nebulord\Documents\LicenceDAM\UWP\Projet\HappyMeal\GamePage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "48DC5281541538439E32751C0354DA8E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HappyMeal
{
    partial class GamePage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // GamePage.xaml line 13
                {
                    global::Windows.UI.Xaml.Controls.Grid element2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).DragOver += this.OnItemDraggedOver;
                    ((global::Windows.UI.Xaml.Controls.Grid)element2).Drop += this.OnItemDropped;
                }
                break;
            case 3: // GamePage.xaml line 25
                {
                    this.Musique = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 4: // GamePage.xaml line 26
                {
                    this.Son = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 5: // GamePage.xaml line 29
                {
                    global::Windows.UI.Xaml.Controls.Image element5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element5).Drop += this.OnItemDroppedInTheCage;
                }
                break;
            case 6: // GamePage.xaml line 30
                {
                    global::Windows.UI.Xaml.Controls.Image element6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)element6).Drop += this.OnItemDroppedInTheCage;
                    ((global::Windows.UI.Xaml.Controls.Image)element6).Tapped += this.OnGameStopped;
                }
                break;
            case 7: // GamePage.xaml line 33
                {
                    this.Food1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food1).DragStarting += this.OnItemDragged;
                }
                break;
            case 8: // GamePage.xaml line 34
                {
                    this.Food2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food2).DragStarting += this.OnItemDragged;
                }
                break;
            case 9: // GamePage.xaml line 35
                {
                    this.Food3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food3).DragStarting += this.OnItemDragged;
                }
                break;
            case 10: // GamePage.xaml line 36
                {
                    this.Food4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food4).DragStarting += this.OnItemDragged;
                }
                break;
            case 11: // GamePage.xaml line 37
                {
                    this.Food5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food5).DragStarting += this.OnItemDragged;
                }
                break;
            case 12: // GamePage.xaml line 38
                {
                    this.Food6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food6).DragStarting += this.OnItemDragged;
                }
                break;
            case 13: // GamePage.xaml line 39
                {
                    this.Food7 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food7).DragStarting += this.OnItemDragged;
                }
                break;
            case 14: // GamePage.xaml line 40
                {
                    this.Food8 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Food8).DragStarting += this.OnItemDragged;
                }
                break;
            case 15: // GamePage.xaml line 55
                {
                    this.Rejouer = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
