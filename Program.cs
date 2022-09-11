using System;
public class Program
{
   public static void Main()
   {
    string Station_Input = Input_sta();
    int Station_Number = Converttoint(Station_Input);
    int cost = Bts_Calculator(Station_Number);
    Console.WriteLine(cost);

   }
   public static string Input_sta()
   {
    Console.Write("Please input: ");
    return Console.ReadLine();
   }
   public static int Converttoint(string statio)
   {
    int.TryParse(statio,out int Value);
    return Value;
   }

   public static int Bts_Calculator(int terminal)
   {
    if(One_terminal(terminal))
    {
    return 16;
    }
    else if(Sec_terminal(terminal))
    {
    return 23;
    }
    else if(Third_terminal(terminal))
    {
    return 26;
    }
    else if(fourth_terminal(terminal))
    {
    return 30;
    }
    else if(Fifth_terminal(terminal))
    {
    return 33;
    }
    else if(six_terminal(terminal))
    {
    return 37;
    }
    else if(seven_terminal(terminal))
    {
    return 40;
    }
    else if( EighttoFifteen_terminal(terminal))
    {
        return 44;
    }

     else if(MorethanFifteen_terminal(terminal))
    {
    return 59;
    }
    else return 0;


   } 
   public static bool One_terminal(int terminal)
   {
    return terminal==1;
   } 
   public static bool Sec_terminal(int terminal)
   {
    return terminal==2;
   }      public static bool Third_terminal(int terminal)
   {
    return terminal==3;
   }    
   public static bool fourth_terminal(int terminal)
   {
    return terminal==4;
   }   
   public static bool Fifth_terminal(int terminal)
   {
    return terminal==5;
   } 
   public static bool six_terminal(int terminal)
   {
    return terminal==6;
   } 
   public static bool seven_terminal(int terminal)
   {
    return terminal==7;
   } 
   public static bool EighttoFifteen_terminal(int terminal)
   {
    return terminal>=8&&terminal<=15;
   } 
    public static bool MorethanFifteen_terminal(int terminal)
   {
    return terminal>15;
   } 





}

    
