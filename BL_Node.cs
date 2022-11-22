/* *********************************************************************** 
 * Project:     Chutes_and_Ladders 
 * File:        BL_Node
 * Language:    C# 
 * 
 * Description: This class implements a node pointer
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

namespace Chutes_and_Ladders
{
    internal class BL_Node
    {
        #region data
        #endregion data

        #region properties
        public String PlayerID { get; set; }      // customer identifier
        public BL_Node Next { get; set; }           // pointer to the next customer
        public BL_Node Top { get; set; }
        #endregion properties

        #region constructor
        /// <summary>
        /// This routine initializes a Customer Node using the Customer Identifier
        /// </summary>
        /// <param name="customerID"></param>
        public BL_Node(String playerID)
        {
            PlayerID = playerID;
            Next = null;
        }

        #endregion constructor

        #region methods
        /// <summary>
        /// This method outputs the node in a generic format
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("Is up = {0}, Next up = {1}", this.PlayerID,
                this.Next == null ? "end of queue" : this.Next.PlayerID);
        }
        #endregion methods
    }
}

