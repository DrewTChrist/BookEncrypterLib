# BookEncrypterLib
A C# library for encrypting messages with books, and a few classes with stand alone functionality.

* **Note the [constructor](https://github.com/DrewTChrist/BookEncrypterLib/blob/5d69f754fc5f8259c9fcf6dc661826975b0b56ca/BookEncrypter/BookEncrypter/CodeBook.cs#L9-L25) for** `BookEncrypter.CodeBook` **needs optimized to increase the creation speed of the** `Dictionary<string, List<int>>` **class** 

* **The wait time for large books can be a really long time. At about six thousand words visual studio will go into break mode because it takes so long**


---
## Classes with stand alone functionality
### BookEncrypter.TextFile
* Can be used as an easy text file reader and writer
* Initializing a new instance of a `TextFile` will invoke an `OpenFileDialog` and request a text file
* The text file contents are then stored as a string in `TextFile.Text` and can be used for whatever purpose
* You can also save the `TextFile` contents by calling the `TextFile.writeToFile()` method

### BookEncrypter.StandardizedString
* Can be used to clean up a string by removing punctuation and extra spaces
* Initializing a new instance of a `StandardizedString` will create a string with no extra white space or punctuation
* Used as such `StandardizedString standardizedString = new StandardizedString(yourString);`
* `yourString` will have all punctuation and extra space removed and will be stored in `standardizedString.Text` for use
