using System.Windows;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties

// Let WPF find standard styles of our custom controls in the special resources dictionary "Generic.xaml" (in the folder "Themes" of this assemply).
// Without this, the end-user would have to merge the style in his code (UserControl)
[assembly: ThemeInfo(
    ResourceDictionaryLocation.None,
    ResourceDictionaryLocation.SourceAssembly
)] 