﻿#pragma checksum "..\..\calculadora.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "592E029AD96998A83E3BEC2877DF809A5AB0B863968BBD38801EA6E00730E348"
//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using DS_01;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace DS_01 {
    
    
    /// <summary>
    /// Calculadora
    /// </summary>
    public partial class Calculadora : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumX;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNumY;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAdicao;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btSub;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btMult;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btDiv;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\calculadora.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtResultado;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DS-01;component/calculadora.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\calculadora.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.txtNumX = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtNumY = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.btAdicao = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\calculadora.xaml"
            this.btAdicao.Click += new System.Windows.RoutedEventHandler(this.btAdicao_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btSub = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\calculadora.xaml"
            this.btSub.Click += new System.Windows.RoutedEventHandler(this.btSub_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btMult = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\calculadora.xaml"
            this.btMult.Click += new System.Windows.RoutedEventHandler(this.btMult_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btDiv = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\calculadora.xaml"
            this.btDiv.Click += new System.Windows.RoutedEventHandler(this.btDiv_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtResultado = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
