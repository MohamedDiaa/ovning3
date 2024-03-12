﻿using System;
using System.Xml.Linq;

namespace Arv.Animals
{
    //13. here we add the attributes shared by all the birds.

    public class Bird: Animal
	{
        private double wingSpan;

        public Bird()
		{
		}

        public override void DoSound()
        {
            Console.WriteLine("it sound like a bird");
        }


        public override string Stats()
        {
            string baseString = base.Stats();

            return $"{base.Stats}, wingspan: {wingSpan}";
        }
    }
}

