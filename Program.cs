﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOopC_
{
    class Program
    {
        static void Main(string[] args)
        {
            //  SOLID :)

            Basket basket = new Basket();
            Fotball fotball = new Fotball();
            Team team = new Team() { TeamName = "TI" };
            Player player = new Player() { Name = "Ion" };

            AddPlayerToTeam(player, team);
            AddTeamToGame(team, basket);

            player = new Player() { Name = "Nicu" };
            team = new Team() { TeamName = "FAF" };

            AddPlayerToTeam(player, team);
            AddTeamToGame(team, basket);


            GetTeams(basket);
            Console.WriteLine("\n -xxx------------------------------------------------------- \n");
            ShowGamesAndTeams(new List<IGameShow>() { basket, fotball, new SomeGame() });


//---experiment-------------------------------------------------------------------------------------------------------
            Order.Builder builder = new Order.Builder();
            builder.Bread("Wheat").Chees("America").Met("Ham");

            Order order = builder.build();

            Console.WriteLine($"{order.bred} , {order.met} , {order.chees} .");
            //----experiment-----------------------------------------------------------------------------------------------------------------------------

            MyClass myClass = new MyClass();

            myClass.SetA("aaaa").SetB("bbbb").SetC("cccc");
            Console.WriteLine(myClass.GetAll());
//-----------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();

        }
        public static void AddTeamToGame(ITeam team, IGameAdd game)
        {
            game.AddTeam(team);
        }
        public static void AddPlayerToTeam(IPlayer player, ITeam team)
        {
            team.AddPlayer(player);
        }
        public static void GetTeams(IGameShow game)
        {
            Console.WriteLine(game.GetTeams());
            game.ShowPlayersAndTeams();
        }

        public static void ShowGamesAndTeams(List<IGameShow> games)
        {
            //Liskov efect
            foreach (IGameShow g in games)
            {
                g.ShowPlayersAndTeams();
                Console.WriteLine("\n -------------------------------------------------------- \n");
            }
        }

    }
}
