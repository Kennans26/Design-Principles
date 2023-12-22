using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Interface_Segregation_Principle_IdealCode;

interface IPrint
{
    void Print();
}

interface IScan
{
    void Scan();
}

interface IFax
{
    void Fax();
}

interface IPrintDuplex
{
    void PrintDuplex();
}

class HPPrinter : IPrint, IScan, IFax, IPrintDuplex
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

class SamsungPrinter : IPrint, IFax
{
    public void Fax()
    {
        //fax operations
    }

    public void Print()
    {
        //print operations
    }
}

class LexmarkPrinter : IFax, IPrint, IScan
{
    public void Fax()
    {
        //fax operations
    }

    public void Print()
    {
        //print operations
    }

    public void Scan()
    {
        //scan operations
    }
}