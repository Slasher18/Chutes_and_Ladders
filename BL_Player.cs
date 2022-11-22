/* *********************************************************************** 
 * Project:     Chutes_and_Ladders 
 * File:        Player
 * Language:    C# 
 * 
 * Description: This class implements the amount of players
 *             
 * College: Husson University 
 * Course: IT 325 
 * 
 * Edit History; 
 * Ver   Who  Date       Notes 
 * ----  ---- ------     -----------------------------------
 * 0.1   BL  11-21-22      Inital writing 
 *                         
 * 
 * ***********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chutes_and_Ladders
{
    internal class BL_Player
    {
        #region data  
        BL_Queue playerQueue = new BL_Queue();
        BL_Queue inplayPlayers = new BL_Queue();



        int playerPosition = 0;
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

        #endregion data 

        #region properties 
        #endregion properties  

        #region constructor 

        #endregion constructor

        #region methods 

       
        public void PlayerPosition(int data)
        {
            playerPosition = playerPosition + data;
            playerPosition = game_board[playerPosition];


        }

        #endregion methods
    }
}
