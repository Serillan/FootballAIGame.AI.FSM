﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAIGame.AI.FSM.UserClasses.Entities;
using FootballAIGame.AI.FSM.UserClasses.Messaging;

namespace FootballAIGame.AI.FSM.UserClasses.TeamStates
{
    class Attacking : State<Team>
    {
        private Attacking() { }

        private static Attacking _instance;

        public static Attacking Instance
        {
            get { return _instance ?? (_instance = new Attacking()); }
        }


        public override void Run(Team entity)
        {
        }

        public override bool ProcessMessage(Message message)
        {
            return false;
        }
    }
}
