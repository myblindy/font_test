using SixLabors.Fonts;

var fontCollection = new FontCollection();
var regularFontFamily = fontCollection.Add(@"Font\OpenSans-Regular.ttf");
var font = regularFontFamily.CreateFont(25);

var fontRect = TextMeasurer.Measure("V", new(font));
