# How to add benchmark line in Xamarin.Forms Chart (SfChart)?

This example demonstrates how to represent a benchmark/threshold-indicator line in Xamarin.Forms SfChart using the annotation feature.

You can represent a benchmark line in a chart using the annotation feature and set the target value to the Y1 position of [HorizontalLineAnnotation](https://help.syncfusion.com/cr/xamarin/Syncfusion.SfChart.XForms.HorizontalLineAnnotation.html). For example, the target value has been set to 62 in the following data.

My data look like this:

| S.No | XValue | YValue |
| ------ | ------ | ------ |
| 1 | GroupA | 50% |
| 2 | GroupB | 60% |
| 3 | GroupC | 70% |

Target Value: 62%

The following code demonstrates how to add benchmark line in a chart using the annotation feature.

**XAML**
```
<chart:SfChart>
…
 
<chart:SfChart.Series>
      <chart:ColumnSeries ItemsSource="{Binding SeriesData}" XBindingPath="XValue" YBindingPath="YValue">
                <chart:ColumnSeries.DataMarker>
                    <chart:ChartDataMarker>
                        <chart:ChartDataMarker.LabelStyle>
                            <chart:DataMarkerLabelStyle LabelPosition="Inner" LabelFormat="0'%'" />
                        </chart:ChartDataMarker.LabelStyle>
                    </chart:ChartDataMarker>
                </chart:ColumnSeries.DataMarker>
        </chart:ColumnSeries>
 </chart:SfChart.Series> 
 
 <chart:SfChart.ChartAnnotations>
     <chart:HorizontalLineAnnotation Y1="62"  Text = "Benchmark" StrokeColor="Orange" StrokeWidth = "6">
         <chart:HorizontalLineAnnotation.LabelStyle>
             <chart:ChartAnnotationLabelStyle Font="12" HorizontalTextAlignment="Start" VerticalTextAlignment="End"/>
         </chart:HorizontalLineAnnotation.LabelStyle>
     </chart:HorizontalLineAnnotation>
</chart:SfChart.ChartAnnotations>
 
</chart:SfChart>
```

**C#**
```
SfChart chart = new SfChart();
…
 
ColumnSeries series = new ColumnSeries();
series.ItemsSource = view.SeriesData;
series.XBindingPath = "XValue";
series.YBindingPath = "YValue";
series.DataMarker = new ChartDataMarker();
series.DataMarker.LabelStyle = new DataMarkerLabelStyle();
series.DataMarker.LabelStyle.LabelPosition = DataMarkerLabelPosition.Inner;
series.DataMarker.LabelStyle.LabelFormat = "0'%'";
chart.Series.Add(series);
 
HorizontalLineAnnotation horizontalLine = new HorizontalLineAnnotation();
horizontalLine.Y1 = 62;
horizontalLine.Text = "Benchmark";
horizontalLine.StrokeColor = Color.Orange;
horizontalLine.StrokeWidth = 6;
horizontalLine.LabelStyle = new ChartAnnotationLabelStyle();
horizontalLine.LabelStyle.Font = Font.SystemFontOfSize(12);
horizontalLine.LabelStyle.HorizontalTextAlignment = ChartAnnotationAlignment.Start;
horizontalLine.LabelStyle.VerticalTextAlignment = ChartAnnotationAlignment.End;
chart.ChartAnnotations.Add(horizontalLine);
```

**ViewModel**
```
public class ViewModel
{
     public ObservableCollection<Model> SeriesData
     {
         get;
         set;
     }

     public ViewModel()
     {
         SeriesData = new ObservableCollection<Model>();
         SeriesData.Add(new Model { XValue = "Group A", YValue = 50 });
         SeriesData.Add(new Model { XValue = "Group B", YValue = 60 });
         SeriesData.Add(new Model { XValue = "Group C", YValue = 70 });
     }
}
```

## Output:

![Benchmark line using Annotation in Xamarin.Forms Chart](https://user-images.githubusercontent.com/53489303/200602811-01514285-8d12-48f0-9d8a-bb4ed8dea0fc.png)

KB article - [How to add benchmark line in Xamarin.Forms Chart?](https://www.syncfusion.com/kb/9304/how-to-add-benchmark-line-in-xamarin-forms-chart)

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
