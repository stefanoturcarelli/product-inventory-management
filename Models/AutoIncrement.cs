using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductInventoryManagement.Models
{

    /// <summary>
    /// AutoIncrement class to manage incremental IDs
    /// Researched from https://stackoverflow.com/questions/51641722/create-a-c-sharp-method-to-generate-auto-increment-id
    /// </summary>
    public class AutoIncrement
    {
        private int id = 1; // Initial ID value

        /// <summary>
        /// // Method to generate a new ID
        /// </summary>
        /// <returns>The current Id</returns>
        public int GenerateId()
        {
            return id++;
        }
    }
}