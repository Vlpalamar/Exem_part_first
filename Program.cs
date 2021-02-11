using ConsoleApp25.Models;
using ConsoleApp25.Models.RelationShip;
using System;
using System.Collections.Generic;

namespace ConsoleApp25
{
    class Program
    {
        static void read()
        {
            using (DBContext dB= new DBContext())
            {
                foreach (Genre item in dB.genres)
                {
                    Console.WriteLine(item.name);
                }
            }
        }
        static void DiscStoreInsert()
        {
            using (DBContext dB= new DBContext())
            {
                Genre g1 = new Genre { name = "Heavy Metal" };
                Genre g2 = new Genre { name = "Hard Rock" };
                Genre g3 = new Genre { name = "Blues" };
                Genre g4 = new Genre { name = "Jazz" };

                dB.genres.AddRange(new List<Genre> { g1, g2, g3, g4 }); 
                dB.SaveChanges();

                Band b1 = new Band { name = "Black Sabbath" };
                Band b2 = new Band { name = "Metallica" };
                Band b3 = new Band { name = "Joan Jett & The Blackhearts" };
                Band b4 = new Band { name = "Robert Johnson" };
                Band b5 = new Band { name = " Louis Armstrong" };

                dB.bands.AddRange(new List<Band> { b1, b2, b3, b4 });
                dB.SaveChanges();

                Publisher p1 = new Publisher { name = "Vertigo Records" };
                Publisher p2 = new Publisher { name = "Sec Label" };
                Publisher p3 = new Publisher { name = "3rd Label" };
                dB.publishers.AddRange(new List<Publisher> { p1, p2, p3 });
                dB.SaveChanges();

                Disc d1 = new Disc
                {
                    name = "Paranoid",
                    band = b1,
                    publisher = p1,
                    realiseDate = new DateTime(1970, 9, 10, 6, 6, 6),
                    selfCost = 10,
                    sellPrice = 100,
                    treckCount = 12
                };
                dB.discs.Add(d1);
                DiscGeners dg1 = new DiscGeners { disc = d1, genre = g1 };
                dB.Add(dg1);
                dB.SaveChanges();
                
                   
                
            }
            


            
        }

        static void Main(string[] args)
        {
            DiscStoreInsert();
            read();
            Console.WriteLine("Hello World!");
           
        }
    }
}
