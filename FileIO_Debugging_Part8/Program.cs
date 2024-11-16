using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace FileIO_Debugging_Part8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------------------------------------------------------------------

            //1.File and Directory Operations in C# 


            //string directoryPath = "MyTestDirectory";
            //string filePath = Path.Combine(directoryPath, "testfile.txt");

            //if (!Directory.Exists(directoryPath))
            //{
            //    Directory.CreateDirectory(directoryPath);
            //}
            //// Create and write to file
            //File.WriteAllText(filePath, "Hello World!");

            //// Read and display file contents
            //string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine("File Content: " + fileContent);

            //// Clean up by deleting file and directory
            //File.Delete(filePath);
            //Directory.Delete(directoryPath);

            //Console.WriteLine("File and Directory deleted successfully.");

            //---------------------------------------------------------------------

            //2.Stream - based I / O

            // Write a program in C# that reads a text file "sample.txt" line by line using StreamReader and 
            //writes each line to a new file named "copy.txt" using StreamWriter.


            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //// Read from source and write to destination using streams
            //using (StreamReader reader = new StreamReader(sourceFilePath))
            //using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        writer.WriteLine(line);
            //    }
            //}

            //Console.WriteLine("File copied successfully.");

            //---------------------------------------------------------------------


            //3.Serialization and Deserialization

            //Define a Person class with properties Name and Age.Write a program to serialize an instance of
            //Person to a JSON file and then deserialize it back to display the object properties on the console.


            //Person person = new Person { Name = "John Doe", Age = 30 };
            //string filePath = "person.json";

            //// Serialize to JSON and save to file
            //string jsonString = JsonSerializer.Serialize(person);
            //File.WriteAllText(filePath, jsonString);
            //Console.WriteLine("Object serialized to JSON file.");

            //// Deserialize from JSON file
            //string readJson = File.ReadAllText(filePath);
            //Person deserializedPerson = JsonSerializer.Deserialize<Person>(readJson);
            //Console.WriteLine($"Name: {deserializedPerson.Name}, Age: { deserializedPerson.Age}"); 

            //---------------------------------------------------------------------

            //4.Exception Handling in File Operations

            //Modify the file copy program in Question 2 to handle possible exceptions like
            //FileNotFoundException, UnauthorizedAccessException, and IOException.Display custom error
            //messages for each exception type.

            //string sourceFilePath = "sample.txt";
            //string destinationFilePath = "copy.txt";

            //try
            //{
            //    using (StreamReader reader = new StreamReader(sourceFilePath))
            //    using (StreamWriter writer = new StreamWriter(destinationFilePath))
            //    {
            //        string line;
            //        while ((line = reader.ReadLine()) != null)
            //        {
            //            writer.WriteLine(line);
            //        }
            //    }

            //    Console.WriteLine("File copied successfully.");
            //}
            //catch (FileNotFoundException ex)
            //{
            //    Console.WriteLine("Error: Source file not found.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (UnauthorizedAccessException ex)
            //{
            //    Console.WriteLine("Error: Access denied. Check permissions.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("Error: IO exception occurred.");
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An unexpected error occurred.");
            //    Console.WriteLine(ex.Message);
            //}


            //---------------------------------------------------------------------

            //5.File Search and Modification in Directory

            //string dirPath = "Logs";
            //Directory.CreateDirectory(dirPath);

            //string sampleFilePath = Path.Combine(dirPath, "sample.txt");
            //if (!File.Exists(sampleFilePath))
            //{
            //    File.WriteAllText(sampleFilePath, "Sample log entry.");
            //    Console.WriteLine("Sample file created in Logs directory.");
            //}

            //// Search for .txt files and modify them
            //foreach (string filePath in Directory.GetFiles(dirPath, "*.txt"))
            //{
            //    // Append timestamp
            //    string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //    File.AppendAllText(filePath, $"\n{timestamp}");

            //    // Display file content after modification
            //    string content = File.ReadAllText(filePath);
            //    Console.WriteLine($"File: {filePath}\nContent:\n{content}");
            //}

            //---------------------------------------------------------------------

            //6.Binary File Operations with Streams

            // string filePath = "data.bin";
            // int[] numbers = { 10, 20, 30, 40, 50 };

            // // Write integers to binary file
            // using (BinaryWriter writer = new BinaryWriter(File.Open(filePath,
            //FileMode.Create)))
            // {
            //     foreach (int number in numbers)
            //     {
            //         writer.Write(number);
            //     }
            // }

            // Console.WriteLine("Data written to binary file.");

            // // Read integers from binary file
            // using (BinaryReader reader = new BinaryReader(File.Open(filePath,
            //FileMode.Open)))
            // {
            //     Console.WriteLine("Reading data from binary file:");
            //     while (reader.BaseStream.Position != reader.BaseStream.Length)
            //     {
            //         int number = reader.ReadInt32();
            //         Console.WriteLine(number);
            //     }
            // }

            //---------------------------------------------------------------------

            //7.Custom Exception Handling in File Operations


            //Create a custom exception class named FileTooLargeException which is thrown when a file
            //exceeds 1 MB in size.Write a program that reads a file's size and throws this exception if the file 
            //size is too large.Otherwise, it should display "File size is acceptable."

            //string filePath = "largefile.txt";

            //try
            //{
            //    FileInfo fileInfo = new FileInfo(filePath);
            //    if (fileInfo.Length > 1024 * 1024)
            //    {
            //        throw new FileTooLargeException("The file size exceeds the 1 MB limit."); 
            //    }
            //    Console.WriteLine("File size is acceptable.");
            //}
            //catch (FileTooLargeException ex)
            //{
            //    Console.WriteLine("Custom Exception: " + ex.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}

            //---------------------------------------------------------------------


            //8.Text File Serialization and Deserialization with XML

            //Define a Book class with properties Title, Author, and ISBN.Write a program that serializes an
            //instance of Book to an XML file named "book.xml" and then deserializes it back, displaying the
            //details on the console.



            //Book book = new Book
            //{
            //    Title = "C# Programming",
            //    Author = "John Doe",
            //    ISBN = "1234567890"
            //};
            //string filePath1 = "book.xml";

            //// Serialize to XML
            //XmlSerializer serializer = new XmlSerializer(typeof(Book));
            //using (FileStream fs = new FileStream(filePath1, FileMode.Create))
            //{
            //    serializer.Serialize(fs, book);
            //}
            //Console.WriteLine("Book object serialized to XML.");

            //// Deserialize from XML
            //Book deserializedBook;
            //using (FileStream fs = new FileStream(filePath1, FileMode.Open))
            //{
            //    deserializedBook = (Book)serializer.Deserialize(fs);
            //}
            //Console.WriteLine($"Title: {deserializedBook.Title}, Author: { deserializedBook.Author}, ISBN: { deserializedBook.ISBN}  "); 




            //---------------------------------------------------------------------

            //9.Visual Studio Debugging Tools and NUnit





            //---------------------------------------------------------------------
            //---------------------------------------------------------------------
            //---------------------------------------------------------------------

            Console.ReadLine();
        }
    }
}
