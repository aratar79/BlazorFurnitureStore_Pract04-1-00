﻿using System;

namespace Blazor.FurnitureStore.Shared
{
    public class ClientStore
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public string FullName
        {
            get 
            { 
                return LastName + ", "  + FirstName; 
            }
        }



    }
}
