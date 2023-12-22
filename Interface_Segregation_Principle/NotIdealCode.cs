using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Interface_Segregation_Principle_NotIdealCode;

interface IPrinter
{
    void Print();
    void Scan();
    void Fax();
    void PrintDuplex();
}

class HPPrinter : IPrinter
{
    public void Fax()
    {
        //fax operations
    }

    public void Print()
    {
        //print operations
    }

    public void PrintDuplex()
    {
        //print duplex operations
    }

    public void Scan()
    {
        //scan operations
    }
}

class SamsungPrinter : IPrinter
{
    public void Fax()
    {
        //fax operations
    }

    public void Print()
    {
        //print operations
    }

    public void PrintDuplex()
        => throw new NotSupportedException();

    public void Scan()
        => throw new NotSupportedException();
}

class LexmarkPrinter : IPrinter
{
    public void Fax()
    {
        //fax operations
    }

    public void Print()
    {
        //print operations
    }

    public void PrintDuplex()
        => throw new NotSupportedException();

    public void Scan()
    {
        //scan operations
    }
}