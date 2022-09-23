using PearsonTest.DTOs;
using PearsonTest.Logic.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PearsonTest.Logic.Services
{
    public class CoinChangeService : ICoinChangeService
    {
        private double _changeRemaining;

        public int HowManyCoinsAreNeeded(double changeRemaining)
        {
            List<DenominationQuantity> coinDenominations = new List<DenominationQuantity>
            {
                new DenominationQuantity { Denomination = 100 },
                new DenominationQuantity { Denomination = 50 },
                new DenominationQuantity { Denomination = 20 },
                new DenominationQuantity { Denomination = 10 },
                new DenominationQuantity { Denomination = 5 },
                new DenominationQuantity { Denomination = 2 },
                new DenominationQuantity { Denomination = 1 }
            };

            _changeRemaining = changeRemaining;

            foreach (DenominationQuantity denomination in coinDenominations)
            {
                denomination.Quantity = GetCoinQuantity(denomination.Denomination);
            }

            return coinDenominations.Select(x => x.Quantity).Sum();
        }

        private int GetCoinQuantity(int denomination)
        {
            if (denomination > _changeRemaining) return 0;

            int coinQuantity = Convert.ToInt32(Math.Floor(_changeRemaining / denomination));

            _changeRemaining = _changeRemaining - (denomination * coinQuantity);

            return coinQuantity;
        }
    }
}
