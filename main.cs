// Author: Dana Kleber
// File Name: main.cs
// Project Name: Game
// Creation Date: Sept. 24, 2020
// Modified Date: Sept. 29, 2020
// Description: This program is built to allow two players to play a tic tac toe game through user keyboard input

using System;

class MainClass 
{

  public static void Main (string[] args) 
  {
    // Store the user symbols (x's & o's)
    string [,] userSpace = new string[3,3];

    //Set the amount of plays made by the user to zero
    int numPlays = 0;

    // Set up conditons to display main menu and check for a draw
    bool mainMenu = true;
    bool checkDraw = false;

    // Keep looping while the mainMenu is set to true
     while (mainMenu == true)
     {
       // Reset the array to have all blank values
       ResetArray(userSpace);

       // Display info and rules 
       Console.WriteLine(userSpace[0,0]);
       Rules();

        // Ask for and retrieve input from user to start game 
       Console.WriteLine ("Press '1' to begin the game");
       string startGame = Console.ReadLine();
       
       // Setting up the first players turn
       int nextTurn = 1;

       // Randomize which player goes first and store in playerOrder
       Random random = new Random();
       int playerOrder = random.Next(1,3);
       String msg1 = ", Using X";
       
       // Keep looping while startGame is equal to win
         while (startGame == "1")
         {
           Console.Clear();
           
           // Displaying board and current player as well as which symbol they use
           Console.WriteLine("Current Player: Player" + playerOrder + msg1);
           OutputBoard(userSpace);
           
            // Use a for loop to check the row in the array for a horizontal win
             for (int rowNumArray = 0; rowNumArray < userSpace.GetLength(0); rowNumArray++ )
             {
               //if the array has an x or O value continue to the next if statment
               if (userSpace[rowNumArray,0] == "x" || userSpace[rowNumArray,0] == "O")
               { 
                 if (userSpace[rowNumArray,0] == userSpace[rowNumArray,1] && userSpace[rowNumArray,0] == userSpace[rowNumArray,2]) 
                 {
                   // Output the message if the current turn would have belonged to player 1 
                   if (playerOrder == 1)
                   {
                     Console.WriteLine("Player 2 Wins. Press Enter to return to main menu.");
                   }
                   // Output the message if the current turn would have belonged to player 2
                   else if (playerOrder == 2)
                   {
                     Console.WriteLine("Player 1 Wins. Press Enter to return to main menu.");
                   }

                   // Set nextTurn to neither 1 or 2 so the players are not allowed to continue once someone wins
                   nextTurn = 3;

                   // Retrieve input to enter main menu
                   string enterMenu = Console.ReadLine();
                    // Enter main menu again if user chooses to
                     if (enterMenu == "")
                     {
                      Console.Clear();
                      startGame = "2";
                     }
                }
              }
              else
              {
                checkDraw = true;
              }
          }

           // Use a for loop to check for a vertical win
           for (int rowColumnArray = 0; rowColumnArray < userSpace.GetLength(1); rowColumnArray++)
          {
            // If the array has an x or O value continue to the next if statment
            if (userSpace[0,rowColumnArray] == "x" || userSpace[0,rowColumnArray] == "O")
            {
              if (userSpace[0,rowColumnArray] == userSpace[1,rowColumnArray] && userSpace[0,rowColumnArray] == userSpace[2,rowColumnArray]) 
              {
                // Output the message if the current turn would have belonged to player 1 
                if (playerOrder == 1)
                {
                 Console.WriteLine("Player 2 Wins. Press Enter to return to main menu.");
                }
                // Output the message if the current turn would have belonged to player 2
                 else if (playerOrder == 2)
                 {
                  Console.WriteLine("Player 1 Wins. Press Enter to return to main menu.");
                 }
                 
                 // Set nextTurn to neither 1 or 2 so the players are not allowed to continue once someone wins
                 nextTurn = 3;
                 
              // Retrieve input to enter main menu   
              string enterMenu = Console.ReadLine();
              // Enter main menu again if user chooses to
              if (enterMenu == "")
              {
                Console.Clear();
                startGame = "2";
              }

             }
          }
           else 
          {
           checkDraw = true;
          }
        }

          // Check for a diagonal win if the array matches the values below
          if (userSpace[0,0] == "x" || userSpace[0,0] == "O")
          {
            if (userSpace[0,0] == userSpace[1,1] && userSpace[0,0] == userSpace[2,2]) 
            {
              // Output the message if the current turn would have belonged to player 1 
              if (playerOrder == 1)
              {
           Console.WriteLine("Player 2 Wins. Press Enter to return to main menu.");
              }
               // Output the message if the current turn would have belonged to player 2
              else if (playerOrder == 2)
              {
                Console.WriteLine("Player 1 Wins. Press Enter to return to main menu.");
              }

            // Set nextTurn to neither 1 or 2 so the players are not allowed to continue once someone wins
             nextTurn = 3;
      
            // Retrieve input to enter main menu
            string enterMenu = Console.ReadLine();
            // Enter main menu again if user chooses to
            if (enterMenu == "")
            {
             Console.Clear();
             startGame = "2";
            }
          }
          else
          {
         checkDraw = true;
          }
        }

         // Check for a diagonal win if the array matches the values below
         if (userSpace[0,2] == "x" || userSpace[0,2] == "O")
         {
           if (userSpace[0,2] == userSpace[1,1] && userSpace[0,2] == userSpace[2,0]) 
           {
             // Output the message if the current turn would have belonged to player 1
             if (playerOrder == 1)
             {
               Console.WriteLine("Player 2 Wins. Press Enter to return to main menu.");
             }
             // Output the message if the current turn would have belonged to player 2
             else if (playerOrder == 2)
             {
               Console.WriteLine("Player 1 Wins. Press Enter to return to main menu.");
             }
         
             // Set nextTurn to neither 1 or 2 so the players are not allowed to continue once someone wins
            nextTurn = 3;
      
            // Retrieve input to enter main menu   
            string enterMenu = Console.ReadLine();
            // Enter main menu again if user chooses to
             if (enterMenu == "")
             {
              Console.Clear();
              startGame = "2";
             }
          }
          else
          {
           checkDraw = true;
          }
       }
       
        // Declare a draw based on the number of plays and value of checkDraw
        if (numPlays == 9 && checkDraw == true)
        {
          // Output if there is a draw
          string reply = "Draw, no one wins. Press Enter to return to main menu";
          Console.WriteLine(reply);

          // Set nextTurn to neither 1 or 2 so the players are not allowed to continue once someone wins
          nextTurn = 3;
      
           // Retrieve input to enter main menu   
           string enterMenu = Console.ReadLine();
             // Enter main menu again if user chooses to
             if (enterMenu == "")
             {
               Console.Clear();
               startGame = "2";

               // set reply and numPlays to 0 to fully exit game
               reply = "";
               numPlays = 0;
             }
        }

      // Check if if nextTurn is equal to one or two to collect and display the user's plays
      if (nextTurn == 1)
      {
        // Ask for and retrieve user's desired row to place their symbol
         RowQuestion();
         String userRowChoice = Console.ReadLine();

        //Check if the user entered a valid response to proceed to ask for and retrieve users desired column 
         if (userRowChoice == "a" || userRowChoice == "b" || userRowChoice == "c")
         {
           // Ask for and retrieve user's desired column 
           ColQuestion();
           String userColumnChoice = Console.ReadLine();

           // Check if user entered a valid response to display their play
           if (userColumnChoice == "a" || userColumnChoice == "b" || userColumnChoice == "c")
           {
             // Change the user inputed value into an array value
             int rowNum = CreateArrayValuesRow(userRowChoice);int columnNum = CreateArrayValuesRow(userColumnChoice);

             // Check if the current space already has a symbol on it
             if (!(userSpace[rowNum, columnNum] == "x" || userSpace[rowNum, columnNum] == "O"))
             {
               // Display an x in the user desired spot 
               userSpace[rowNum, columnNum]= "x";
               
               //Add one to the number of plays and change the user turn
               numPlays++;
               nextTurn = 2;
               
               //Switch the player orders
               if (playerOrder == 1)
               {
                 playerOrder = 2;
               }
               else if (playerOrder == 2)
               {
                 playerOrder = 1;
               }

             msg1 = ", Using O"; 
             }
            }
        }
      }
      else if (nextTurn == 2)
      {
       // Ask for and retrieve user's desired row to place their symbol
        RowQuestion();
        String userRowChoice = Console.ReadLine();

        // Check if user entered a valid response to display their play
        if (userRowChoice == "a" || userRowChoice == "b" || userRowChoice == "c")
        {
          // Ask for and retrieve user's desired column 
          ColQuestion();
          String userColumnChoice = Console.ReadLine();

          // Check if user entered a valid response to display their play
          if (userColumnChoice == "a" || userColumnChoice == "b" || userColumnChoice == "c")
          {
            // Change the user inputed value into an array value
            int rowNum = CreateArrayValuesRow(userRowChoice);
            int columnNum = CreateArrayValuesRow(userColumnChoice);

            // Check if the current space already has a symbol on it
            if (!(userSpace[rowNum, columnNum] == "x" || userSpace[rowNum, columnNum] == "O"))
            {
               // Display an o in the user desired spot 
              userSpace[rowNum, columnNum]= "O";

              //Add one to the number of plays and change the user turn
              numPlays++;
              nextTurn = 1;

              //Switch the player orders
              if (playerOrder == 1)
              {
                playerOrder = 2;
              }
              else if (playerOrder == 2)
              {
                playerOrder = 1;
              }

           msg1 = ", using X"; 
            }
         }
       }
      }
          }
     }
  }
  
  // Pre: a string value
  // Post: Returning the matching row number to the letter
  // Description: Change the user's letter choice as a string into a real integer value to store as the row value
  public static int CreateArrayValuesRow(string a)
    {
       int row = 0;
       
       // Assign a value to the row depending on the user's string value
       if (a == "a")
       {
        row = 0;
       }
      else if (a == "b")
       {
        row = 1;
       }
      else if (a == "c")
       {
        row = 2;
       }

      return row;
    }

  // Pre: a string value
  // Post: Returning the matching column number to the letter
  // Description: Change the user's letter choice as a string into a real integer value to store as the column value
  public static int CreateArrayValuesColumn(string b)
    {
      int column = 0;
      
      // Assign a value to the row depending on the user's string value
      if (b == "a")
      {
       column = 0;
      }
      else if (b == "b")
      {
       column = 1;
      }
      else if (b == "c")
      {
        column = 2;
      }

      return column;
    }

  // Pre: a 2D array holding string values
  // Post: None
  // Description: Reset the array to have blank values
  private static void ResetArray(string [,] testArray)
  {
    for (int row1 = 0; row1 < testArray.GetLength(0); row1++)
    {
      for (int col1 = 0; col1 < testArray.GetLength(1); col1++)
      {
        testArray[row1,col1] = " ";
      }
    }
  }

 // Pre: a 2D array holding string values
 // Post: None
 // Description: Display a board with all the values of the array
  private static void OutputBoard(string [,] userSpace)
  {
    Console.WriteLine("+---+---+---+" + "\n" + "|" +  userSpace[0,0] + "\t" + "|" + userSpace[0,1] + "\t" + "|" + userSpace[0,2] + "\t" + "|" + "\n" + "+---+---+---+" + "\n" + "|" + userSpace[1,0] + "\t" + "|" + userSpace[1,1] + "\t" + "|" + userSpace[1,2] + "\t" + "|"+ "\n" + "+---+---+---+" + "\n" + "|" + userSpace[2,0] + "\t" + "|" + userSpace[2,1] + "\t" + "|" + userSpace[2,2] + "\t" + "|" + "\n" + "+---+---+---+" + "\n");
  }

  // Pre: None
  // Post: None
  // Description: Display the rules of the game
  private static void Rules()
  {
    Console.WriteLine ("Welcome to Tic-Tac-Toe!" + "\n");
    Console.WriteLine ("If you are the first to have three of your letters in either a diagonal, row, or column, you win. The player who goes first is randomized, but the player who goes first will use X"+ "\n");
  }

  // Pre: None
  // Post: None
  // Description: Display the question that asks users which row to place their letter
  private static void RowQuestion()
  {
    Console.WriteLine("Which row would you like to place your letter?" + "\n" + "a) Top" + "\n" + "b) Middle" + "\n" + "c) Bottom");
  }

  // Pre: None
  // Post: None
  // Description: Display the question that asks users which column to place their letter
  private static void ColQuestion()
  {
  Console.WriteLine("\n" + "Which column would you like to place your letter?" + "\n" + "a) Left" + "\n" + "b) Middle" + "\n" + "c) Right");
  }

}