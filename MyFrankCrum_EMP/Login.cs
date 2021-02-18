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
    ///The Login recording.
    /// </summary>
    [TestModule("36c8b41b-2742-4277-9a7e-e0ef2589f773", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyFrankCrum_EMPRepository repository.
        /// </summary>
        public static MyFrankCrum_EMPRepository repo = MyFrankCrum_EMPRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
            CompUser = "Masscompany";
            CompPwd = "Crum2017";
            CompName = "A0f21";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
        {
            get { return instance; }
        }

#region Variables

        string _CompUser;

        /// <summary>
        /// Gets or sets the value of variable CompUser.
        /// </summary>
        [TestVariable("4b080769-593e-4275-ad9e-2a9bd08bcfae")]
        public string CompUser
        {
            get { return _CompUser; }
            set { _CompUser = value; }
        }

        string _CompPwd;

        /// <summary>
        /// Gets or sets the value of variable CompPwd.
        /// </summary>
        [TestVariable("b0780f8a-34b4-4e0a-9ae8-8b57866aa511")]
        public string CompPwd
        {
            get { return _CompPwd; }
            set { _CompPwd = value; }
        }

        string _CompName;

        /// <summary>
        /// Gets or sets the value of variable CompName.
        /// </summary>
        [TestVariable("87d5af70-d755-46e2-9f24-a2ca558f99a7")]
        public string CompName
        {
            get { return _CompName; }
            set { _CompName = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Username' at Center.", repo.MyFrankCrum.UsernameInfo, new RecordItemIndex(0));
            repo.MyFrankCrum.Username.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompUser' with focus on 'MyFrankCrum.Username'.", repo.MyFrankCrum.UsernameInfo, new RecordItemIndex(1));
            repo.MyFrankCrum.Username.PressKeys(CompUser);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Password' at Center.", repo.MyFrankCrum.PasswordInfo, new RecordItemIndex(2));
            repo.MyFrankCrum.Password.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompPwd' with focus on 'MyFrankCrum.Password'.", repo.MyFrankCrum.PasswordInfo, new RecordItemIndex(3));
            repo.MyFrankCrum.Password.PressKeys(CompPwd);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.LoginButton' at Center.", repo.MyFrankCrum.LoginButtonInfo, new RecordItemIndex(4));
            repo.MyFrankCrum.LoginButton.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Text' at Center.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(5));
            repo.MyFrankCrum.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.Text' at Center.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(6));
            repo.MyFrankCrum.Text.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CompName' with focus on 'MyFrankCrum.Text'.", repo.MyFrankCrum.TextInfo, new RecordItemIndex(7));
            repo.MyFrankCrum.Text.PressKeys(CompName);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'MyFrankCrum.A0F21THSNATIONALLLC' at Center.", repo.MyFrankCrum.A0F21THSNATIONALLLCInfo, new RecordItemIndex(8));
            repo.MyFrankCrum.A0F21THSNATIONALLLC.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 10s.", new RecordItemIndex(9));
            Delay.Duration(10000, false);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hi, User!') on item 'ApplicationUnderTest.HiUser'.", repo.ApplicationUnderTest.HiUserInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.HiUserInfo, "InnerText", "Hi, User!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (InnerText>'Pending Time Off Requests ') on item 'ApplicationUnderTest.PendingTimeOffRequests0'.", repo.ApplicationUnderTest.PendingTimeOffRequests0Info, new RecordItemIndex(11));
            Validate.AttributeContains(repo.ApplicationUnderTest.PendingTimeOffRequests0Info, "InnerText", "Pending Time Off Requests ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Time Off Calendar') on item 'ApplicationUnderTest.TimeOffCalendar'.", repo.ApplicationUnderTest.TimeOffCalendarInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.TimeOffCalendarInfo, "InnerText", "Time Off Calendar");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Employees' at Center.", repo.ApplicationUnderTest.EmployeesInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.Employees.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.Search' at Center.", repo.ApplicationUnderTest.SomeDivTag.SearchInfo, new RecordItemIndex(14));
            repo.ApplicationUnderTest.SomeDivTag.Search.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'allen' with focus on 'ApplicationUnderTest.SomeDivTag.Search'.", repo.ApplicationUnderTest.SomeDivTag.SearchInfo, new RecordItemIndex(15));
            repo.ApplicationUnderTest.SomeDivTag.Search.PressKeys("allen");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.FindEmployee' at Center.", repo.ApplicationUnderTest.SomeDivTag.FindEmployeeInfo, new RecordItemIndex(16));
            repo.ApplicationUnderTest.SomeDivTag.FindEmployee.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SomeDivTag.AllenDaneT' at Center.", repo.ApplicationUnderTest.SomeDivTag.AllenDaneTInfo, new RecordItemIndex(17));
            repo.ApplicationUnderTest.SomeDivTag.AllenDaneT.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Personal') on item 'ApplicationUnderTest.Personal'.", repo.ApplicationUnderTest.PersonalInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PersonalInfo, "InnerText", "Personal");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.JobPay' at Center.", repo.ApplicationUnderTest.JobPayInfo, new RecordItemIndex(19));
            repo.ApplicationUnderTest.JobPay.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Job & Pay') on item 'ApplicationUnderTest.JobPay'.", repo.ApplicationUnderTest.JobPayInfo, new RecordItemIndex(20));
            Validate.AttributeEqual(repo.ApplicationUnderTest.JobPayInfo, "InnerText", "Job & Pay");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}