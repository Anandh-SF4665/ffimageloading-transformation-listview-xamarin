**[View document in Syncfusion Xamarin Knowledge base](https://www.syncfusion.com/kb/12184/how-to-enable-ffimageloading-transformation-in-xamarin-forms-listview-sflistview)**

## Sample

```xaml
<sync:SfListView x:Name="listView" AutoFitMode="Height" ItemsSource="{Binding BookInfo}" SelectionBackgroundColor="#d3d3d3">
    <sync:SfListView.ItemTemplate>
        <DataTemplate>
            <code>
            . . .
            . . .
            <code>
        </DataTemplate>
    </sync:SfListView.ItemTemplate>
</sync:SfListView>

C#:

CachedImage FFImage;

var tapGesture = new TapGestureRecognizer();
tapGesture.Tapped += TapGesture_Tapped;
FFImage.GestureRecognizers.Add(tapGesture);

private void TapGesture_Tapped(object sender, EventArgs e)
{
    var blurredTransformation = FFImage.Transformations[0] as BlurredTransformation;
    if (blurredTransformation.Radius == 20) blurredTransformation.Radius = 0;
    else blurredTransformation.Radius = 20;

    FFImage.ReloadImage();
}
```
