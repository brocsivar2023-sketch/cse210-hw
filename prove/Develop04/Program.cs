using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        BaseActivity myActivity = new BaseActivity("Breath", "THis will help you breath");
        myActivity.StartActivity();
    }
}