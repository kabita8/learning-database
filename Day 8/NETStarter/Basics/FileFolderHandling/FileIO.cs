using System.IO;
class FileIO
{
 string folderpath= @"E:\day 2\learning-database\Day 8\NETStarter\Basics\FileFolderHandling";
 //create a text file
    public void CreateFile()
    {
        string fileName ="Student.txt";
        string filepath = Path.Combine(folderpath, fileName);
        File.WriteAllText(filepath,"this is first line");
    }
    public void CreateFileWithInfolder()
    {
        string newFolderName = "Student";
        string newFolderPath = Path.Combine(folderpath, newFolderName);
        Directory.CreateDirectory(newFolderPath);
        string fileName = "Student1.txt";
        string filepath = Path.Combine(newFolderName, fileName);
        File.WriteAllText(filepath, "This is first line");
    }
}