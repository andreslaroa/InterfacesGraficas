﻿#pragma checksum "..\..\VentanaSecundaria.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8D612532BDE3D2DBAD016B614F784C37D5C597FE7AA18D6563BB9DA0E74F183D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using EntregaFinalOficial;
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


namespace EntregaFinalOficial {
    
    
    /// <summary>
    /// VentanaSecundaria
    /// </summary>
    public partial class VentanaSecundaria : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\VentanaSecundaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaElecciones;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\VentanaSecundaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ListaPartidos;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\VentanaSecundaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BotonAñadirEleccion;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\VentanaSecundaria.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BorrarElecciones;
        
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
            System.Uri resourceLocater = new System.Uri("/EntregaFinalOficial;component/ventanasecundaria.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VentanaSecundaria.xaml"
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
            this.ListaElecciones = ((System.Windows.Controls.ListView)(target));
            
            #line 18 "..\..\VentanaSecundaria.xaml"
            this.ListaElecciones.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ListaElecciones_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ListaPartidos = ((System.Windows.Controls.ListView)(target));
            return;
            case 3:
            this.BotonAñadirEleccion = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\VentanaSecundaria.xaml"
            this.BotonAñadirEleccion.Click += new System.Windows.RoutedEventHandler(this.botonAñadirInicial);
            
            #line default
            #line hidden
            return;
            case 4:
            this.BorrarElecciones = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\VentanaSecundaria.xaml"
            this.BorrarElecciones.Click += new System.Windows.RoutedEventHandler(this.BorrarEleccion_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

