using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.DisplayPlayerInfo();
        goalManager.Start();  
    }
}