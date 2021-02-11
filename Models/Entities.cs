﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ConsoleApp25.Models
{

   


    public class Disc
    {
        public int Id { get; set; }

     
        public string name { get; set; }

    
        public Band band { get; set; }

        
        public Publisher publisher { get; set; }

        public int treckCount { get; set; }

        //!!
        public List<RelationShip.DiscGeners>  discsGeners { get; set; }



        public DateTime realiseDate { get; set; }

        [Column(TypeName ="Money")]
        public decimal selfCost { get; set; }

        [Column(TypeName = "Money")]
        public decimal sellPrice { get; set; }
    }

    public class Genre
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string name { get; set; }


        //!!
        public List<RelationShip.DiscGeners> discsGeners { get; set; }

    }

    public class Band
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string name { get; set; }

        public List<Disc> discs { get; set; }

    }

    public  class Publisher
    {
        public int Id { get; set; }

        [MaxLength(30)]
        public string name { get; set; }
        public List<Disc> discs { get; set; }
    }

}
