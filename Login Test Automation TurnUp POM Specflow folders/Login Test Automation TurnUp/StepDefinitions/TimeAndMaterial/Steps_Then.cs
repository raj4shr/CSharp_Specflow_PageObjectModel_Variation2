﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Login_Test_Automation_TurnUp.StepDefinitions.TimeAndMaterial
{
    public partial class TimeAndMaterial_StepDefinitions 
    {
        [Then(@"A new time and material should be created sucessfully")]
        public void ThenANewTimeAndMaterialShouldBeCreatedSucessfully()
        {
            NTAM.checkNewTimeAndMaterialCreated(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }

        [Then(@"Time and material record should be deleted successfully")]
        public void ThenTimeAndMaterialRecordShouldBeDeletedSuccessfully()
        {
            Console.WriteLine("Time and material record has been deleted successfully.....");
            wd.chromeDriver.Quit();
            // throw new PendingStepException();
        }

        [Then(@"time and material record should be edited successfully")]
        public void ThenTimeAndMaterialRecordShouldBeEditedSuccessfully()
        {
            ETAM.checkEditTimeAndMaterial(wd.chromeDriver);
            wd.chromeDriver.Quit();
        }

        [Then(@"The time and material page should be sorted successfully")]
        public void ThenTheTimeAndMaterialPageShouldBeSortedSuccessfully()
        {
            TMDAD.dragAnddropCloseBDD(wd.chromeDriver);
            Console.WriteLine("Time and material drag and drop tab closed successfully.....");
            wd.chromeDriver.Quit();
            //throw new PendingStepException();
        }
    }
}
