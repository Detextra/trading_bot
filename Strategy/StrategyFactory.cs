﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trading_bot_WPF.Central;
using Trading_bot_WPF.Strategy.StrategyType;
using Trading_bot_WPF.Market;
using System.Threading.Tasks;

namespace Trading_bot_WPF.Strategy
{
    internal class StrategyFactory
    {
        private readonly Core _core;
        private readonly Exchange _exchange;

        public StrategyFactory(Core core, Exchange exchange)
        {
            _core = core;
            _exchange = exchange;
        }

        public Strategy CreateStrategy(string strategyType, decimal cash)
        {
            return strategyType switch
            {
                "StrategyA" => new StrategyA("StrategyA", _core, _exchange, cash),
                "StrategyB" => new StrategyB("StrategyB", _core, _exchange, cash),

                _ => throw new ArgumentException("Invalid strategy type")
            };
        }
    }
}
