using System;
using System.Collections.Generic;
using System.Text;


public class Printer // Printer is written using the Singleton technique... Its a super useful design
{
    static Printer m_Instance; // m_Instance acts as the access point to the Printer class and Methods

    private Printer() // constructor not accessible. ...also private keyword not needed, private by default.
    {
    }

    public static Printer Instance()
    {
        // the constructor is only ever called from within the class and only if a Printer instance doesnt exist already
        // this is the a core part of the singleton design along with the m_Instance object
        if (m_Instance == null)
            m_Instance = new Printer();
        return m_Instance;
    }

    // shorter syntax than Printer.Print()?
    public static void Print(String str)
    {
        Console.WriteLine(str);
    }
}
