﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Company_change recording.
    /// </summary>
    [TestModule("da39143a-4387-4e2a-ae82-ba2ff8e0dc6d", ModuleType.Recording, 1)]
    public partial class Company_change : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Company_change instance = new Company_change();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Company_change()
        {
            CompName = "THS NATIONAL";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Company_change Instance
        {
            get { return instance; }
        }

#region Variables

        /// <summary>
        /// Gets or sets the value of variable CompName.
        /// </summary>
        [TestVariable("5ef40c9b-1ab2-45f7-b273-dff7b63c33a6")]
        public string CompName
        {
            get { return repo.CompName; }
            set { repo.CompName = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 20;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ChangeCompany' at Center.", repo.ApplicationUnderTest.ChangeCompanyInfo, new RecordItemIndex(0));
            repo.ApplicationUnderTest.ChangeCompany.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(1));
            Delay.Duration(30000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Text' at Center.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(2));
            repo.MyFrankCrum.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompName' with focus on 'MyFrankCrum.Text'.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(3));
            repo.MyFrankCrum.Text.PressKeys(CompName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.compselect' at Center.", repo.MyFrankCrum.compselectInfo, new RecordItemIndex(4));
            repo.MyFrankCrum.compselect.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}