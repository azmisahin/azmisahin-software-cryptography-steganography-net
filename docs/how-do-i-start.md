## How do I start
![steganography](media/steganography.jpg)

## Image Steganography
Merging and separating the image file with text content.

### Merger
```c#
// Instance
var instance = new Merger();

// Test Condination
Assert.IsInstanceOfType(instance, typeof(IMerger));

// Test Modul
var actual = instance
    .SourceType(SteganographyType.Image)
    .Source(new System.IO.FileInfo("sample/square.bmp"))
    .MergeType(SteganographyType.Text)
    .Content(StringMock.StringItem)
    .Merge(new System.IO.FileInfo("sample/merged/square.text.bmp"));

// Test Condination
Assert.IsInstanceOfType(actual, typeof(CryptoImage));
```

### Separator
```c#
var instance = new Separator()
    .SourceType(SteganographyType.Image)
    .Source(new FileInfo("sample/merged/square.text.bmp"))
    .SeparateType(SteganographyType.Text)
    .Separate();

// Test Condination
Assert.IsInstanceOfType(instance, typeof(CryptoImage));

// Test Modul
CryptoImage actual = (CryptoImage)instance;

// Test Condination
Assert.IsInstanceOfType(actual.String, typeof(string));
```

## Text Steganography
Merging and separating the word dictionary file with text content.

### Merger
```c#
// Instance
var instance = new Merger();

// Test Condination
Assert.IsInstanceOfType(instance, typeof(IMerger));

// Test Modul
var actual = instance
    .SourceType(SteganographyType.Text)
    .Source(new System.IO.FileInfo("sample/dictionary.en.json"))
    .MergeType(SteganographyType.Text)
    .Content(@"
Peter Piper picked a peck of pickled peppers;
A peck of pickled peppers Peter Piper picked;
If Peter Piper picked a peck of pickled peppers,
Where’s the peck of pickled peppers Peter Piper picked?")
    .Merge(new System.IO.FileInfo("sample /merged/dictionary.en.txt"));

// Test Condination
Assert.IsInstanceOfType(actual, typeof(CryptoText));

CryptoText ct = (CryptoText)actual;

System.Console.WriteLine(ct.String);
```

### Separator
```c#
var instance = new Separator()
    .SourceType(SteganographyType.Text)
    .Source(new FileInfo("sample/merged/steganongraphy.en.txt"))
    .SeparateType(SteganographyType.Text)
    .Separate();

// Test Condination
Assert.IsInstanceOfType(instance, typeof(CryptoText));

// Test Modul
CryptoText actual = (CryptoText)instance;

// Test Condination
Assert.IsInstanceOfType(actual.String, typeof(string));

Console.WriteLine(actual.String);
```
