using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chutes_and_Ladders
{
    public partial class Chutes_Ladders : Form
    {

        #region data 
        int[] game_board = new int[100]{ 0, 38, 2, 3, 14, 5, 6, 7, 8, 31, 10,
                                        11, 12, 13, 14, 15, 6, 17, 18, 19, 20,
                                        21, 22, 23, 24, 25, 26, 27, 84, 29, 30,
                                        31, 32, 33, 34, 35, 44, 37, 38, 39, 40,
                                        41, 42, 43, 44, 45, 46, 26, 48, 11, 50,
                                        67, 52, 53, 54, 55, 53, 57, 58, 59, 60,
                                        61, 19, 63, 60, 65, 66, 67, 68, 69, 70,
                                        91, 72, 73, 74, 75, 76, 77, 78, 79, 100,
                                        82, 83, 84, 85, 86, 24, 88, 89, 90, 91,
                                        92, 73, 94, 75, 96, 97, 78, 99, 100};


        BL_Queue playerQueue = new BL_Queue();
        BL_Queue inplayPlayers = new BL_Queue();
        
        int count = 0;
      
        





        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 
        #endregion constructor

        #region methods  
        public int Roll()
        {

            Random rnd = new Random();
            int diceResult = rnd.Next(1, 7);
            return diceResult;
        }
        
        int index = 0;
  
        public void Turn()
        {


            int dieValue;
            int player_count = inplayPlayers.Count;
            int playerPosition;
            int[] playerArray = new int[inplayPlayers.Count()];
            
            
            DisplayQueue(inplayPlayers, listBoxPlayers);
            dieValue = Roll();
            int certainPlayer = playerArray[index++];

            playerPosition = playerArray[index] + dieValue;
            playerPosition = game_board[playerPosition];
            listBoxPlayers.Items.Add(dieValue);
            listBoxPlayers.Items.Add(playerPosition).ToString();
            index++;
            

            string tempPlayer;
            tempPlayer = inplayPlayers.Dequeue();
            inplayPlayers.Enqueue(tempPlayer);
 

        }

        private void DisplayQueue(BL_Queue theQueue, ListBox theListBox)
        {
            // clear the queue
            theListBox.Items.Clear();

            // display header
            //theListBox.Items.Add("Is up next:");

            // display the content of the queue
            //foreach (String custID in theQueue)
            //{
              theListBox.Items.Add(theQueue.First());
            //}

            // display footer
            //theListBox.Items.Add("Back of the Queue");

            // display stats
            theListBox.Items.Add(String.Empty);
            //theListBox.Items.Add(String.Format("Count = {0}", theQueue.Count));
        }
        #endregion methods

        public Chutes_Ladders()
        {
            InitializeComponent();
        }

        private void Chutes_Ladders_Load(object sender, EventArgs e)
        {

        }
       
        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            string[] players = new string[6] { "player1", "player2", "player3", "player4", "player5", "player6" };
            
            int player_count;

            listBoxPlayers.Items.Clear();
            

            player_count = Convert.ToInt32(textBoxPlayerNum.Text);
            if (player_count > 1 && player_count < 7)
            {
                for (int index = 0; index < player_count; index++)
                {
                    string player = players[index];
                    playerQueue.Enqueue(players[index]);
                    inplayPlayers.Enqueue(player);
                    
                    listBoxPlayers.Items.Add(player); 

                    
                    

                }
            }else
            {
                MessageBox.Show("Put in the right number");
            }
           
        }
        
        private void buttonPlayTurn_Click(object sender, EventArgs e)
        {

           
            Turn();
        }
    }
}
