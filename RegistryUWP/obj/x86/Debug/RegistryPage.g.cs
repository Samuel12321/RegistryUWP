﻿#pragma checksum "C:\dev\RegistryUWP\RegistryUWP\RegistryPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "238006CA84B1ACA85D0AB04110DC4E99"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistryUWP
{
    partial class RegistryPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_UIElement_Visibility(global::Windows.UI.Xaml.UIElement obj, global::Windows.UI.Xaml.Visibility value)
            {
                obj.Visibility = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class RegistryPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IRegistryPage_Bindings
        {
            private global::RegistryUWP.RegistryPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj2;
            private global::Windows.UI.Xaml.Controls.TextBlock obj4;
            private global::Windows.UI.Xaml.Controls.TextBlock obj5;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj4VisibilityDisabled = false;
            private static bool isobj5VisibilityDisabled = false;

            private RegistryPage_obj1_BindingsTracking bindingsTracking;

            public RegistryPage_obj1_Bindings()
            {
                this.bindingsTracking = new RegistryPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 25 && columnNumber == 193)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 22 && columnNumber == 97)
                {
                    isobj4VisibilityDisabled = true;
                }
                else if (lineNumber == 23 && columnNumber == 80)
                {
                    isobj5VisibilityDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // RegistryPage.xaml line 25
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 4: // RegistryPage.xaml line 22
                        this.obj4 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 5: // RegistryPage.xaml line 23
                        this.obj5 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                throw new global::System.NotImplementedException();
            }

            public void Recycle()
            {
                throw new global::System.NotImplementedException();
            }

            // IRegistryPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::RegistryUWP.RegistryPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::RegistryUWP.RegistryPage obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_StartupProgramNames(obj.StartupProgramNames, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_IsSMode(obj.IsSMode, phase);
                        this.Update_NotSMode(obj.NotSMode, phase);
                    }
                }
            }
            private void Update_StartupProgramNames(global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_StartupProgramNames(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // RegistryPage.xaml line 25
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_IsSMode(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                {
                    this.Update_IsSMode_Cast_IsSMode_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_IsSMode_Cast_IsSMode_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RegistryPage.xaml line 22
                    if (!isobj4VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj4, obj);
                    }
                }
            }
            private void Update_NotSMode(global::System.Boolean obj, int phase)
            {
                if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                {
                    this.Update_NotSMode_Cast_NotSMode_To_Visibility(obj ? global::Windows.UI.Xaml.Visibility.Visible : global::Windows.UI.Xaml.Visibility.Collapsed, phase);
                }
            }
            private void Update_NotSMode_Cast_NotSMode_To_Visibility(global::Windows.UI.Xaml.Visibility obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // RegistryPage.xaml line 23
                    if (!isobj5VisibilityDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_UIElement_Visibility(this.obj5, obj);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class RegistryPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<RegistryPage_obj1_Bindings> weakRefToBindingObj; 

                public RegistryPage_obj1_BindingsTracking(RegistryPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<RegistryPage_obj1_Bindings>(obj);
                }

                public RegistryPage_obj1_Bindings TryGetBindingObject()
                {
                    RegistryPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_(null);
                    UpdateChildListeners_StartupProgramNames(null);
                }

                public void PropertyChanged_(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    RegistryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::RegistryUWP.RegistryPage obj = sender as global::RegistryUWP.RegistryPage;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                            if (obj != null)
                            {
                                bindings.Update_StartupProgramNames(obj.StartupProgramNames, DATA_CHANGED);
                            }
                        }
                        else
                        {
                            switch (propName)
                            {
                                case "StartupProgramNames":
                                {
                                    if (obj != null)
                                    {
                                        bindings.Update_StartupProgramNames(obj.StartupProgramNames, DATA_CHANGED);
                                    }
                                    break;
                                }
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void UpdateChildListeners_(global::RegistryUWP.RegistryPage obj)
                {
                    RegistryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        if (bindings.dataRoot != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)bindings.dataRoot).PropertyChanged -= PropertyChanged_;
                        }
                        if (obj != null)
                        {
                            bindings.dataRoot = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_;
                        }
                    }
                }
                public void PropertyChanged_StartupProgramNames(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    RegistryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::System.String>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_StartupProgramNames(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    RegistryPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::System.String>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::System.String> cache_StartupProgramNames = null;
                public void UpdateChildListeners_StartupProgramNames(global::System.Collections.ObjectModel.ObservableCollection<global::System.String> obj)
                {
                    if (obj != cache_StartupProgramNames)
                    {
                        if (cache_StartupProgramNames != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_StartupProgramNames).PropertyChanged -= PropertyChanged_StartupProgramNames;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_StartupProgramNames).CollectionChanged -= CollectionChanged_StartupProgramNames;
                            cache_StartupProgramNames = null;
                        }
                        if (obj != null)
                        {
                            cache_StartupProgramNames = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_StartupProgramNames;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_StartupProgramNames;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // RegistryPage.xaml line 25
                {
                    this.StartupProgramsListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // RegistryPage.xaml line 27
                {
                    this.RegistryButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.RegistryButton).Click += this.RegistryButton_Click;
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
            switch(connectionId)
            {
            case 1: // RegistryPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    RegistryPage_obj1_Bindings bindings = new RegistryPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

