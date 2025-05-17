# FileSharing

### include controls style 
```xml
<Styles xmlns="https://github.com/avaloniaui"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <Style Selector="TextBlock.h1">
        <Setter Property="FontSize" Value="24"/>
        <Setter Property="FontWeight" Value="Bold"/>
    </Style>
</Styles>

<Application... > 
    <Application.Styles>
        <FluentTheme Mode="Light"/>
        <StyleInclude Source="/AppStyles.axaml"/>
    </Application.Styles>
</Application>
```


### include resource 
```xml
<ResourceDictionary xmlns="https://github.com/avaloniaui"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <SolidColorBrush x:Key="GridSplittercolor" Color="#25aff3"> </SolidColorBrush>
</ResourceDictionary>

<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <MergeResourceInclude Source="/Resources/Colors.axaml" />
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

```
https://docs.avaloniaui.net/docs/basics/user-interface/controls/creating-controls/defining-properties
https://docs.avaloniaui.net/docs/guides/styles-and-resources/resources
https://docs.avaloniaui.net/docs/reference/controls/gridsplitter
https://docs.avaloniaui.net/docs/basics/user-interface/controls/
```