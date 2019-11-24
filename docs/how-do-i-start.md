## How do I start
![steganography](media/steganography.jpg)

## Image Steganography
Merging and separating the image file with text content.

### Merger
```c#
var instance = Steganography
    .Merger
    .SourceType(SteganographyType.Image)
    .Source(new FileInfo("sample/square.bmp"))
    .MergeType(SteganographyType.Text)
    .Content("CryptoSteganography")
    .Merge(new FileInfo("sample/merged/square.txt.bmp"));
```

### Separator
```c#
var instance = Steganography
    .Separator
    .SourceType(SteganographyType.Image)
    .Source(new FileInfo("sample/merged/square.txt.bmp"))
    .SeparateType(SteganographyType.Text)
    .Separate();
```

## Text Steganography
Merging and separating the word dictionary file with text content.

### Merger
```c#
 var actual = instance
	.SourceType(SteganographyType.Text)
	.Source(new System.IO.FileInfo("sample/dictionary.en.json"))
	.MergeType(SteganographyType.Text)
	.Content(StringMock.StringItem)
	.Merge(new System.IO.FileInfo("sample/merged/dictionary.en.txt"));
```

### Separator
```c#
var instance = new Separator()
    .SourceType(SteganographyType.Text)
    .Source(new FileInfo("sample/merged/steganongraphy.en.txt"))
    .SeparateType(SteganographyType.Text)
    .Separate();
```