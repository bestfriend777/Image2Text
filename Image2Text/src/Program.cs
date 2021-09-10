using System;
using System.Drawing;

public class Program
{
    static int Main(string[] args)
    {
        Image img;
        String solutionDir = "D:/work/dev/c#/Image2Text/";
        String projectDir = solutionDir + "Image2Text/";
        String imgDir = projectDir + "res/img/";

        try
        {
            Printer.Print("enter the img path relative to the project directory:");
            String str = Console.ReadLine();
            img = Image.FromFile(projectDir + str);
            Printer.Print("\nImage Loaded!" );
        }
        catch
        {
            Printer.Print("\nLoad Failed!");
            return Exit();
        }

        Printer.Print("Save as new copy? Y/N");
        if (Console.ReadLine().ToUpper() == "Y")
        {
            Printer.Print("\nEnter Name: ");
            String name = Console.ReadLine();

            try
            {
                img.Save(imgDir + name);
                Printer.Print("\n'" + name + "' Saved as New Image!");
            }
            catch
            {
                Printer.Print("\nSave Failed!");
                return Exit();
            }
        }
        
        return Exit();
    }

    static int Exit()
    {
        Printer.Print("\nPress ~any~ key to exit");
        Console.ReadKey();
        return 0;
    }
}
