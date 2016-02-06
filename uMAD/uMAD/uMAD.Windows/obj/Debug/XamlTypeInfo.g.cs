﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace uMAD
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace uMAD.uMAD_Windows_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "uMAD.Helpers.ScheduleDateConverter";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "uMAD.Helpers.CapitalConverter";
            _typeNameTable[3] = "uMAD.Helpers.RelativeDateTimeConverter";
            _typeNameTable[4] = "Windows.UI.Color";
            _typeNameTable[5] = "System.ValueType";
            _typeNameTable[6] = "Byte";
            _typeNameTable[7] = "uMAD.Helpers.ValueWhenConverter";
            _typeNameTable[8] = "uMAD.LoginPage";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[11] = "uMAD.MainPage";
            _typeNameTable[12] = "uMAD.Common.ObservableDictionary";
            _typeNameTable[13] = "String";
            _typeNameTable[14] = "uMAD.Common.NavigationHelper";
            _typeNameTable[15] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[16] = "uMAD.EmptyUserControl";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::uMAD.Helpers.ScheduleDateConverter);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::uMAD.Helpers.CapitalConverter);
            _typeTable[3] = typeof(global::uMAD.Helpers.RelativeDateTimeConverter);
            _typeTable[4] = typeof(global::Windows.UI.Color);
            _typeTable[5] = typeof(global::System.ValueType);
            _typeTable[6] = typeof(global::System.Byte);
            _typeTable[7] = typeof(global::uMAD.Helpers.ValueWhenConverter);
            _typeTable[8] = typeof(global::uMAD.LoginPage);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[11] = typeof(global::uMAD.MainPage);
            _typeTable[12] = typeof(global::uMAD.Common.ObservableDictionary);
            _typeTable[13] = typeof(global::System.String);
            _typeTable[14] = typeof(global::uMAD.Common.NavigationHelper);
            _typeTable[15] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[16] = typeof(global::uMAD.EmptyUserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_ScheduleDateConverter() { return new global::uMAD.Helpers.ScheduleDateConverter(); }
        private object Activate_2_CapitalConverter() { return new global::uMAD.Helpers.CapitalConverter(); }
        private object Activate_3_RelativeDateTimeConverter() { return new global::uMAD.Helpers.RelativeDateTimeConverter(); }
        private object Activate_7_ValueWhenConverter() { return new global::uMAD.Helpers.ValueWhenConverter(); }
        private object Activate_8_LoginPage() { return new global::uMAD.LoginPage(); }
        private object Activate_11_MainPage() { return new global::uMAD.MainPage(); }
        private object Activate_12_ObservableDictionary() { return new global::uMAD.Common.ObservableDictionary(); }
        private object Activate_16_EmptyUserControl() { return new global::uMAD.EmptyUserControl(); }
        private void MapAdd_12_ObservableDictionary(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.Object>)instance;
            var newKey = (global::System.String)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  uMAD.Helpers.ScheduleDateConverter
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_ScheduleDateConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  uMAD.Helpers.CapitalConverter
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_2_CapitalConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  uMAD.Helpers.RelativeDateTimeConverter
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_3_RelativeDateTimeConverter;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  Windows.UI.Color
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.AddMemberName("A");
                userType.AddMemberName("B");
                userType.AddMemberName("G");
                userType.AddMemberName("R");
                xamlType = userType;
                break;

            case 5:   //  System.ValueType
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 6:   //  Byte
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.ValueType"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 7:   //  uMAD.Helpers.ValueWhenConverter
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_7_ValueWhenConverter;
                userType.AddMemberName("When");
                userType.AddMemberName("Value");
                userType.AddMemberName("Otherwise");
                userType.AddMemberName("OtherwiseValueBack");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  uMAD.LoginPage
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_LoginPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 11:   //  uMAD.MainPage
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_MainPage;
                userType.AddMemberName("DefaultViewModel");
                userType.AddMemberName("NavigationHelper");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  uMAD.Common.ObservableDictionary
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.DictionaryAdd = MapAdd_12_ObservableDictionary;
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  String
                xamlType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 14:   //  uMAD.Common.NavigationHelper
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 16:   //  uMAD.EmptyUserControl
                userType = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.UserControl"));
                userType.Activator = Activate_16_EmptyUserControl;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_Color_A(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.A;
        }
        private void set_0_Color_A(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.A = (global::System.Byte)Value;
        }
        private object get_1_Color_B(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.B;
        }
        private void set_1_Color_B(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.B = (global::System.Byte)Value;
        }
        private object get_2_Color_G(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.G;
        }
        private void set_2_Color_G(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.G = (global::System.Byte)Value;
        }
        private object get_3_Color_R(object instance)
        {
            var that = (global::Windows.UI.Color)instance;
            return that.R;
        }
        private void set_3_Color_R(object instance, object Value)
        {
            var that = (global::Windows.UI.Color)instance;
            that.R = (global::System.Byte)Value;
        }
        private object get_4_ValueWhenConverter_When(object instance)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            return that.When;
        }
        private void set_4_ValueWhenConverter_When(object instance, object Value)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            that.When = (global::System.Object)Value;
        }
        private object get_5_ValueWhenConverter_Value(object instance)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            return that.Value;
        }
        private void set_5_ValueWhenConverter_Value(object instance, object Value)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            that.Value = (global::System.Object)Value;
        }
        private object get_6_ValueWhenConverter_Otherwise(object instance)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            return that.Otherwise;
        }
        private void set_6_ValueWhenConverter_Otherwise(object instance, object Value)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            that.Otherwise = (global::System.Object)Value;
        }
        private object get_7_ValueWhenConverter_OtherwiseValueBack(object instance)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            return that.OtherwiseValueBack;
        }
        private void set_7_ValueWhenConverter_OtherwiseValueBack(object instance, object Value)
        {
            var that = (global::uMAD.Helpers.ValueWhenConverter)instance;
            that.OtherwiseValueBack = (global::System.Object)Value;
        }
        private object get_8_MainPage_DefaultViewModel(object instance)
        {
            var that = (global::uMAD.MainPage)instance;
            return that.DefaultViewModel;
        }
        private object get_9_MainPage_NavigationHelper(object instance)
        {
            var that = (global::uMAD.MainPage)instance;
            return that.NavigationHelper;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember xamlMember = null;
            global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "Windows.UI.Color.A":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "A", "Byte");
                xamlMember.Getter = get_0_Color_A;
                xamlMember.Setter = set_0_Color_A;
                break;
            case "Windows.UI.Color.B":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "B", "Byte");
                xamlMember.Getter = get_1_Color_B;
                xamlMember.Setter = set_1_Color_B;
                break;
            case "Windows.UI.Color.G":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "G", "Byte");
                xamlMember.Getter = get_2_Color_G;
                xamlMember.Setter = set_2_Color_G;
                break;
            case "Windows.UI.Color.R":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("Windows.UI.Color");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "R", "Byte");
                xamlMember.Getter = get_3_Color_R;
                xamlMember.Setter = set_3_Color_R;
                break;
            case "uMAD.Helpers.ValueWhenConverter.When":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.Helpers.ValueWhenConverter");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "When", "Object");
                xamlMember.Getter = get_4_ValueWhenConverter_When;
                xamlMember.Setter = set_4_ValueWhenConverter_When;
                break;
            case "uMAD.Helpers.ValueWhenConverter.Value":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.Helpers.ValueWhenConverter");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "Value", "Object");
                xamlMember.Getter = get_5_ValueWhenConverter_Value;
                xamlMember.Setter = set_5_ValueWhenConverter_Value;
                break;
            case "uMAD.Helpers.ValueWhenConverter.Otherwise":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.Helpers.ValueWhenConverter");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "Otherwise", "Object");
                xamlMember.Getter = get_6_ValueWhenConverter_Otherwise;
                xamlMember.Setter = set_6_ValueWhenConverter_Otherwise;
                break;
            case "uMAD.Helpers.ValueWhenConverter.OtherwiseValueBack":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.Helpers.ValueWhenConverter");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "OtherwiseValueBack", "Object");
                xamlMember.Getter = get_7_ValueWhenConverter_OtherwiseValueBack;
                xamlMember.Setter = set_7_ValueWhenConverter_OtherwiseValueBack;
                break;
            case "uMAD.MainPage.DefaultViewModel":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.MainPage");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "uMAD.Common.ObservableDictionary");
                xamlMember.Getter = get_8_MainPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "uMAD.MainPage.NavigationHelper":
                userType = (global::uMAD.uMAD_Windows_XamlTypeInfo.XamlUserType)GetXamlTypeByName("uMAD.MainPage");
                xamlMember = new global::uMAD.uMAD_Windows_XamlTypeInfo.XamlMember(this, "NavigationHelper", "uMAD.Common.NavigationHelper");
                xamlMember.Getter = get_9_MainPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::uMAD.uMAD_Windows_XamlTypeInfo.XamlSystemBaseType
    {
        global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::uMAD.uMAD_Windows_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


