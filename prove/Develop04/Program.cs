using System;
using Microsoft.VisualBasic;


/* 
For my program I completed all of the rquirements and I made 4 different classes. They each perform different
funtions. For my exceeding requirements I added a part where it keeps track of how many times you did each activity
and prints out a message at the end of the program that lets you know what activitys you did and how many times 
you did it.
*/
class Program
{
    static void Main(string[] args)
    {
        Menu myMenu = new Menu();
        myMenu.RunMenu();
    }
}