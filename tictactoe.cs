using System;

public class tictactoe
{
    public static string[] names={"Player1","Player2"};
    public static string[] board={"1","2","3","4","5","6","7","8","9"};
    public static int selection;
    public static int current=0;
    public static bool won;
   
    public static void Main(string[] args)
    
{
    //Initialize game
    Console.WriteLine("Name of Player one (X): ");
    names[0]=Console.ReadLine();
    Console.WriteLine("Name of Player two (O)");
    names[1]=Console.ReadLine();
    
    //Run Game
    printboard();
    while(won==false)
    {
    Console.WriteLine(names[current]+", please choose field");
    selection=Convert.ToInt32(Console.ReadLine());
    if (current==0)
    {
        board[selection-1]="X";
        current=1;
    }
    else
    {
        board[selection-1]="O";
        current=0;
    }
    printboard();
    woncheck();
    
    }
    declarewinner();  

    
}

//Functions

    //Print Board
    public static void printboard ()
    {
        Console.WriteLine(board[0]+" | "+board[1]+" | "+board[2]);
        Console.WriteLine(board[3]+" | "+board[4]+" | "+board[5]);
        Console.WriteLine(board[6]+" | "+board[7]+" | "+board[8]);
    }
    //Check if someone won
    public static void woncheck()
    {
        //Line check X
        if((board[0]=="X" & board[1]=="X" & board[2]=="X")^ 
            (board[3]=="X" & board[4]=="X" & board[5]=="X")^
            (board[6]=="X" & board[7]=="X" & board[8]=="X"))
        {
            won = true;
        }
        //Linecheck O
        if((board[0]=="O" & board[1]=="O" & board[2]=="O")^ 
            (board[3]=="O" & board[4]=="O" & board[5]=="O")^
            (board[6]=="O" & board[7]=="O" & board[8]=="O"))
        {
            won = true;
        }
        //Columncheck X
         if((board[0]=="X" & board[3]=="X" & board[6]=="X")^ 
            (board[1]=="X" & board[4]=="X" & board[7]=="X")^
            (board[2]=="X" & board[5]=="X" & board[8]=="X"))
            {
                won=true;
            }
        //Columncheck O
         if((board[0]=="O" & board[3]=="O" & board[6]=="O")^ 
            (board[1]=="O" & board[4]=="O" & board[7]=="O")^
            (board[2]=="O" & board[5]=="O" & board[8]=="O"))
        {
            won = true;
        }
        //Diagonal check O
         if((board[0]=="O" & board[4]=="O" & board[8]=="O")^ 
            (board[2]=="O" & board[4]=="O" & board[6]=="O"))
        {
            won = true;
        }
         //Diagonal check O
         if((board[0]=="X" & board[4]=="X" & board[8]=="X")^ 
            (board[2]=="X" & board[4]=="X" & board[6]=="X"))
        {
            won = true;
        }

    }
        //Declare Winner
        public static void declarewinner()
            {
            if (current==0)
                {
                    current=1;
                }
            else
                {
                    current=0;
                }
            Console.WriteLine("The Winner is: " +names[current]);
    }

}
