using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //BaseActivity myActivity = new BaseActivity("Breath", "THis will help you breath");
        //myActivity.StartActivity();
        //myActivity.RunCountdown("Breath in", 10);

        //Breathing myBreathing = new Breathing("This activity will help you with your breathing by walking you through how to breathe in and out slowly. Clear your mind and focus on your breathing. ");
        //myBreathing.RunActivity();
        Reflection myReflection = new Reflection("This activity will help you reflect on times in your life when youi have shown stregnth and resilience. This will help you recognize these things in other aspects of your life. ");
        myReflection.RunActivity();
    }
}