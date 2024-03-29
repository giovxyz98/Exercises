﻿using System;
using System.Runtime.CompilerServices;

namespace EsercizioDelegateCeo
{
    public delegate void Cambio(object obj,Even e);
    public class Even : EventArgs
    {
        public string newCeo;
        public Even(string ceo)
        {
            this.newCeo = ceo;
        }
       

    }
    
    public abstract class Centralbank
    {
        
        public event Cambio cambio;
       
        public static string _CEO ;
        public string newCEO;
        public string CEO
        {
            get { return _CEO; }
            set
            {
                newCEO = value;
                if (_CEO != newCEO)
                {   
                    _CEO = newCEO;
                   Even even = new Even(newCEO);
                    cambio(this,even);
                    
                }
            }

        }
    }
    
}