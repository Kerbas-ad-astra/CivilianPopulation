﻿using System;
using System.Collections.Generic;

namespace CivilianPopulation.Domain
{
    public class CivilianPopulationService
    {
		private const double timeBetweenRents = 6*60*60;
		private const int rentAmountPerCivilian = 200;

        private CivilianPopulationAdapter adapter;

		private double nextTaxesDate;
		private CivilianPopulationWorld world;

        public CivilianPopulationService(CivilianPopulationAdapter adapter)
        {
            this.adapter = adapter;
        }

        public void update(CivilianPopulationWorld world)
        {
            this.world = world;
            this.update();
        }

		private void update()
        {
			if (world.isCareer())
			{
				double next = getNextTaxesDate();
				if (nextTaxesDate < next)
				{
					nextTaxesDate = next;
                    int numCivilians = world.getCiviliansInFlight();
					adapter.addFunds(numCivilians * rentAmountPerCivilian);
				}
			}
		}

		private double getNextTaxesDate()
		{
			double now = world.getUniversalTime();
			double next = 0;
			while (next < now)
			{
				next += timeBetweenRents;
			}
			return next;
		}

        public double getTimeUntilTaxes()
        {
			return getNextTaxesDate() - world.getUniversalTime();
		}

        public List<CivilianVessel> getVessels()
        {
            return world.getVessels();
        }
    }
}
 