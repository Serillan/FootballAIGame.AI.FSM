﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FootballAIGame.AI.FSM.SimulationEntities;
using FootballAIGame.AI.FSM.UserClasses.Messaging;

namespace FootballAIGame.AI.FSM.UserClasses.Entities
{
    class GoalKeeper : Player
    {
        public GoalKeeper(FootballPlayer player) : base(player)
        {
        }

        public override void Update()
        {
            throw new NotImplementedException();
        }

        public override bool ProcessMessage(Message message)
        {
            return false;
        }
    }
}
