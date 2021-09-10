using System;
using System.Drawing;

public class Program
{
    static int Main(string[] args)
    {

        Image img;
        String solutionDir = "D:/work/dev/c#/Image2Text/";
        String projectDir = solutionDir + "Image2Text/";

        Printer.Print("enter the img path (relative to the project directory)\n");
        String str = Console.ReadLine();
        try
        {
            //img = Image.FromFile(projectDir + "res/img/chix.bmp");
            img = Image.FromFile(projectDir + str);
            Printer.Print("Path: " + projectDir + "res/img/chix.bmp\nImage Loaded\n");
        }
        catch
        {
            Printer.Print("Path: " + projectDir + "res/img/chix.bmp\nImage Load Failed\n");
            return Exit();
        }

        return Exit();
    }

    static int Exit()
    {
        Printer.Print("Press any key to exit.");
        Console.ReadKey();
        return 0;
    }
}

public class Printer
{
    static Printer m_Instance; // access point to the static Printer

    private Printer() // constructor not accessible private keyword not needed, private by default
    {
    }

    public static Printer Instance()
    {
        // the constructor is only called privately within the class and only if a Printer instance doesnt exist already
        if (m_Instance == null)
            m_Instance = new Printer(); 
        return m_Instance;
    }
    
    // Come up with shorter syntax than 'Printer.Print()'
    public static void Print(String str)
    {
        Console.WriteLine(str);
    }
}
