﻿using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CivilianPopulation.Domain
{
    [TestFixture()]
    public class CivilianPopulationServiceShould
    {
        [Test()]
        public void AddRentEveryDay()
        {
            MockedCivilianPopulationAdapter adapter = new MockedCivilianPopulationAdapter();
            adapter.setFunds(0);

			CivilianPopulationService service = new CivilianPopulationService(adapter);

			bool career = true;
			int time = 0;
            List<CivilianVessel> vessels = new List<CivilianVessel>();

            CivilianPopulationWorld world = new CivilianPopulationWorld(career, time, vessels);
            service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

            time += 60 * 60;
            world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

			time += 60 * 60;
            vessels.Add(new CivilianVessel("My vessel", 2));
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

			time += 60 * 60;
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
            Assert.AreEqual(0, adapter.getFunds());

			time += 60 * 60;
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

            time += 60 * 60;
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

			time += 60 * 60;
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(0, adapter.getFunds());

			time += 60 * 60;
			world = new CivilianPopulationWorld(career, time, vessels);
			service.update(world);
			Assert.AreEqual(400, adapter.getFunds());
		}
    }
}
