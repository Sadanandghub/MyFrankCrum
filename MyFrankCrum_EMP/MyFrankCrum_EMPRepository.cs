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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyFrankCrum_EMP
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyFrankCrum_EMPRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("57aa7af5-e1bb-4d86-b1a0-d72cef37e59c")]
    public partial class MyFrankCrum_EMPRepository : RepoGenBaseFolder
    {
        static MyFrankCrum_EMPRepository instance = new MyFrankCrum_EMPRepository();
        MyFrankCrum_EMPRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        MyFrankCrum_EMPRepositoryFolders.MyFrankCrumAppFolder _myfrankcrum;

        /// <summary>
        /// Gets the singleton class instance representing the MyFrankCrum_EMPRepository element repository.
        /// </summary>
        [RepositoryFolder("57aa7af5-e1bb-4d86-b1a0-d72cef37e59c")]
        public static MyFrankCrum_EMPRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyFrankCrum_EMPRepository() 
            : base("MyFrankCrum_EMPRepository", "/", null, 0, false, "57aa7af5-e1bb-4d86-b1a0-d72cef37e59c", ".\\RepositoryImages\\MyFrankCrum_EMPRepository57aa7af5.rximgres")
        {
            _applicationundertest = new MyFrankCrum_EMPRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _myfrankcrum = new MyFrankCrum_EMPRepositoryFolders.MyFrankCrumAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("57aa7af5-e1bb-4d86-b1a0-d72cef37e59c")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("4adb2402-d0f1-4185-819f-54d35157c656")]
        public virtual MyFrankCrum_EMPRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The MyFrankCrum folder.
        /// </summary>
        [RepositoryFolder("e02b0ef2-fe8d-4d4c-89ac-ddc5221f14bc")]
        public virtual MyFrankCrum_EMPRepositoryFolders.MyFrankCrumAppFolder MyFrankCrum
        {
            get { return _myfrankcrum; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyFrankCrum_EMPRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("4adb2402-d0f1-4185-819f-54d35157c656")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {
            MyFrankCrum_EMPRepositoryFolders.SomeDivTagFolder _somedivtag;
            RepoItemInfo _hiuserInfo;
            RepoItemInfo _pendingtimeoffrequests0Info;
            RepoItemInfo _timeoffcalendarInfo;
            RepoItemInfo _employeesInfo;
            RepoItemInfo _personalInfo;
            RepoItemInfo _jobpayInfo;

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='devmfc.frankcrum.com']", parentFolder, 30000, null, false, "4adb2402-d0f1-4185-819f-54d35157c656", "")
            {
                _somedivtag = new MyFrankCrum_EMPRepositoryFolders.SomeDivTagFolder(this);
                _hiuserInfo = new RepoItemInfo(this, "HiUser", ".//div[#'app']/div[2]/div[3]/div/div/div[1]/div[@innertext='Hi, User!']", 30000, null, "a3e32600-6f6d-4dc7-b218-60c088d58d1d");
                _pendingtimeoffrequests0Info = new RepoItemInfo(this, "PendingTimeOffRequests0", ".//div[#'app']/div[2]/div[3]/div/div/div[2]/div[1]/div[1]/?/?/div[@innertext>'Pending Time Off Requests']", 30000, null, "c56020f0-77cb-4f3b-959c-9530964f1a71");
                _timeoffcalendarInfo = new RepoItemInfo(this, "TimeOffCalendar", ".//div[#'app']/div[2]/div[3]/div/div/div[2]/?/?/h5[@innertext='Time Off Calendar']", 30000, null, "b0975e3b-721e-4b0e-87b0-893b6f26a04c");
                _employeesInfo = new RepoItemInfo(this, "Employees", ".//div[#'/Employees']//div[@innertext='Employees']", 30000, null, "4c761a55-0c84-4b80-b662-f8ba98ff564f");
                _personalInfo = new RepoItemInfo(this, "Personal", ".//div[#'app']/div[2]/div[3]/div/div[4]/div[1]/ul/?/?/li[@innertext='Personal']", 30000, null, "18137ebf-5c2e-48a0-b589-8241b8c342d1");
                _jobpayInfo = new RepoItemInfo(this, "JobPay", ".//div[#'app']/div[2]/div[3]/div/div[4]/div[1]/ul/?/?/li[@innertext='Job & Pay']", 30000, null, "663ab337-b10c-4767-94a3-3dc45d8bdddb");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("4adb2402-d0f1-4185-819f-54d35157c656")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("4adb2402-d0f1-4185-819f-54d35157c656")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The HiUser item.
            /// </summary>
            [RepositoryItem("a3e32600-6f6d-4dc7-b218-60c088d58d1d")]
            public virtual Ranorex.DivTag HiUser
            {
                get
                {
                    return _hiuserInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The HiUser item info.
            /// </summary>
            [RepositoryItemInfo("a3e32600-6f6d-4dc7-b218-60c088d58d1d")]
            public virtual RepoItemInfo HiUserInfo
            {
                get
                {
                    return _hiuserInfo;
                }
            }

            /// <summary>
            /// The PendingTimeOffRequests0 item.
            /// </summary>
            [RepositoryItem("c56020f0-77cb-4f3b-959c-9530964f1a71")]
            public virtual Ranorex.DivTag PendingTimeOffRequests0
            {
                get
                {
                    return _pendingtimeoffrequests0Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The PendingTimeOffRequests0 item info.
            /// </summary>
            [RepositoryItemInfo("c56020f0-77cb-4f3b-959c-9530964f1a71")]
            public virtual RepoItemInfo PendingTimeOffRequests0Info
            {
                get
                {
                    return _pendingtimeoffrequests0Info;
                }
            }

            /// <summary>
            /// The TimeOffCalendar item.
            /// </summary>
            [RepositoryItem("b0975e3b-721e-4b0e-87b0-893b6f26a04c")]
            public virtual Ranorex.H5Tag TimeOffCalendar
            {
                get
                {
                    return _timeoffcalendarInfo.CreateAdapter<Ranorex.H5Tag>(true);
                }
            }

            /// <summary>
            /// The TimeOffCalendar item info.
            /// </summary>
            [RepositoryItemInfo("b0975e3b-721e-4b0e-87b0-893b6f26a04c")]
            public virtual RepoItemInfo TimeOffCalendarInfo
            {
                get
                {
                    return _timeoffcalendarInfo;
                }
            }

            /// <summary>
            /// The Employees item.
            /// </summary>
            [RepositoryItem("4c761a55-0c84-4b80-b662-f8ba98ff564f")]
            public virtual Ranorex.DivTag Employees
            {
                get
                {
                    return _employeesInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Employees item info.
            /// </summary>
            [RepositoryItemInfo("4c761a55-0c84-4b80-b662-f8ba98ff564f")]
            public virtual RepoItemInfo EmployeesInfo
            {
                get
                {
                    return _employeesInfo;
                }
            }

            /// <summary>
            /// The Personal item.
            /// </summary>
            [RepositoryItem("18137ebf-5c2e-48a0-b589-8241b8c342d1")]
            public virtual Ranorex.LiTag Personal
            {
                get
                {
                    return _personalInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The Personal item info.
            /// </summary>
            [RepositoryItemInfo("18137ebf-5c2e-48a0-b589-8241b8c342d1")]
            public virtual RepoItemInfo PersonalInfo
            {
                get
                {
                    return _personalInfo;
                }
            }

            /// <summary>
            /// The JobPay item.
            /// </summary>
            [RepositoryItem("663ab337-b10c-4767-94a3-3dc45d8bdddb")]
            public virtual Ranorex.LiTag JobPay
            {
                get
                {
                    return _jobpayInfo.CreateAdapter<Ranorex.LiTag>(true);
                }
            }

            /// <summary>
            /// The JobPay item info.
            /// </summary>
            [RepositoryItemInfo("663ab337-b10c-4767-94a3-3dc45d8bdddb")]
            public virtual RepoItemInfo JobPayInfo
            {
                get
                {
                    return _jobpayInfo;
                }
            }

            /// <summary>
            /// The SomeDivTag folder.
            /// </summary>
            [RepositoryFolder("3c277c0b-840f-4617-a705-75fe26324e8e")]
            public virtual MyFrankCrum_EMPRepositoryFolders.SomeDivTagFolder SomeDivTag
            {
                get { return _somedivtag; }
            }
        }

        /// <summary>
        /// The SomeDivTagFolder folder.
        /// </summary>
        [RepositoryFolder("3c277c0b-840f-4617-a705-75fe26324e8e")]
        public partial class SomeDivTagFolder : RepoGenBaseFolder
        {
            RepoItemInfo _findemployeeInfo;
            RepoItemInfo _searchInfo;
            RepoItemInfo _allendanetInfo;

            /// <summary>
            /// Creates a new SomeDivTag  folder.
            /// </summary>
            public SomeDivTagFolder(RepoGenBaseFolder parentFolder) :
                    base("SomeDivTag", ".//div[#'app']/div[2]/div[3]/div/div[3]", parentFolder, 30000, null, false, "3c277c0b-840f-4617-a705-75fe26324e8e", "")
            {
                _findemployeeInfo = new RepoItemInfo(this, "FindEmployee", ".//form[@action='https://devmfc.frankcrum.com/Employees']/button[@innertext='Find Employee']", 30000, null, "4a94201e-15df-4f15-b447-e46ce28162b6");
                _searchInfo = new RepoItemInfo(this, "Search", ".//form[@action='https://devmfc.frankcrum.com/Employees']/input[@name='search']", 30000, null, "1afcd6c6-15d5-4d92-9d42-cfeaefa208ad");
                _allendanetInfo = new RepoItemInfo(this, "AllenDaneT", "div/div/div[3]/div/div/div/div/div[2]/?/?/button[@innertext='Allen, Dane  T']", 30000, null, "525585a1-9415-4e8e-ba21-a47ab7c00a61");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("3c277c0b-840f-4617-a705-75fe26324e8e")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("3c277c0b-840f-4617-a705-75fe26324e8e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The FindEmployee item.
            /// </summary>
            [RepositoryItem("4a94201e-15df-4f15-b447-e46ce28162b6")]
            public virtual Ranorex.ButtonTag FindEmployee
            {
                get
                {
                    return _findemployeeInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The FindEmployee item info.
            /// </summary>
            [RepositoryItemInfo("4a94201e-15df-4f15-b447-e46ce28162b6")]
            public virtual RepoItemInfo FindEmployeeInfo
            {
                get
                {
                    return _findemployeeInfo;
                }
            }

            /// <summary>
            /// The Search item.
            /// </summary>
            [RepositoryItem("1afcd6c6-15d5-4d92-9d42-cfeaefa208ad")]
            public virtual Ranorex.InputTag Search
            {
                get
                {
                    return _searchInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Search item info.
            /// </summary>
            [RepositoryItemInfo("1afcd6c6-15d5-4d92-9d42-cfeaefa208ad")]
            public virtual RepoItemInfo SearchInfo
            {
                get
                {
                    return _searchInfo;
                }
            }

            /// <summary>
            /// The AllenDaneT item.
            /// </summary>
            [RepositoryItem("525585a1-9415-4e8e-ba21-a47ab7c00a61")]
            public virtual Ranorex.ButtonTag AllenDaneT
            {
                get
                {
                    return _allendanetInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The AllenDaneT item info.
            /// </summary>
            [RepositoryItemInfo("525585a1-9415-4e8e-ba21-a47ab7c00a61")]
            public virtual RepoItemInfo AllenDaneTInfo
            {
                get
                {
                    return _allendanetInfo;
                }
            }
        }

        /// <summary>
        /// The MyFrankCrumAppFolder folder.
        /// </summary>
        [RepositoryFolder("e02b0ef2-fe8d-4d4c-89ac-ddc5221f14bc")]
        public partial class MyFrankCrumAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _usernameInfo;
            RepoItemInfo _passwordInfo;
            RepoItemInfo _loginbuttonInfo;
            RepoItemInfo _textInfo;
            RepoItemInfo _a0f21thsnationalllcInfo;

            /// <summary>
            /// Creates a new MyFrankCrum  folder.
            /// </summary>
            public MyFrankCrumAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MyFrankCrum", "/dom[@domain='devmfc.frankcrum.com']", parentFolder, 30000, null, false, "e02b0ef2-fe8d-4d4c-89ac-ddc5221f14bc", "")
            {
                _usernameInfo = new RepoItemInfo(this, "Username", ".//input[#'username']", 30000, null, "dae14d42-0356-417b-9909-606bdede9e58");
                _passwordInfo = new RepoItemInfo(this, "Password", ".//input[#'password']", 30000, null, "412c74cf-dc5a-4923-abfd-d0df44deb072");
                _loginbuttonInfo = new RepoItemInfo(this, "LoginButton", ".//button[#'login-button']", 30000, null, "5f2dc3f0-e054-4d98-957f-563cc77b128a");
                _textInfo = new RepoItemInfo(this, "Text", ".//div[#'modal-wrapper']/div/div/div[4]/div/div[1]/?/?/input[@type='text']", 30000, null, "2c2381c4-c30c-4b42-b588-e26ac722476e");
                _a0f21thsnationalllcInfo = new RepoItemInfo(this, "A0F21THSNATIONALLLC", ".//div[#'company-list-scroll']//button[@innertext='A0F21-THS NATIONAL LLC']", 30000, null, "0bf98207-7145-403e-bdbb-7408bdc8115b");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("e02b0ef2-fe8d-4d4c-89ac-ddc5221f14bc")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("e02b0ef2-fe8d-4d4c-89ac-ddc5221f14bc")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Username item.
            /// </summary>
            [RepositoryItem("dae14d42-0356-417b-9909-606bdede9e58")]
            public virtual Ranorex.InputTag Username
            {
                get
                {
                    return _usernameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Username item info.
            /// </summary>
            [RepositoryItemInfo("dae14d42-0356-417b-9909-606bdede9e58")]
            public virtual RepoItemInfo UsernameInfo
            {
                get
                {
                    return _usernameInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("412c74cf-dc5a-4923-abfd-d0df44deb072")]
            public virtual Ranorex.InputTag Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("412c74cf-dc5a-4923-abfd-d0df44deb072")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The LoginButton item.
            /// </summary>
            [RepositoryItem("5f2dc3f0-e054-4d98-957f-563cc77b128a")]
            public virtual Ranorex.ButtonTag LoginButton
            {
                get
                {
                    return _loginbuttonInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The LoginButton item info.
            /// </summary>
            [RepositoryItemInfo("5f2dc3f0-e054-4d98-957f-563cc77b128a")]
            public virtual RepoItemInfo LoginButtonInfo
            {
                get
                {
                    return _loginbuttonInfo;
                }
            }

            /// <summary>
            /// The Text item.
            /// </summary>
            [RepositoryItem("2c2381c4-c30c-4b42-b588-e26ac722476e")]
            public virtual Ranorex.InputTag Text
            {
                get
                {
                    return _textInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Text item info.
            /// </summary>
            [RepositoryItemInfo("2c2381c4-c30c-4b42-b588-e26ac722476e")]
            public virtual RepoItemInfo TextInfo
            {
                get
                {
                    return _textInfo;
                }
            }

            /// <summary>
            /// The A0F21THSNATIONALLLC item.
            /// </summary>
            [RepositoryItem("0bf98207-7145-403e-bdbb-7408bdc8115b")]
            public virtual Ranorex.ButtonTag A0F21THSNATIONALLLC
            {
                get
                {
                    return _a0f21thsnationalllcInfo.CreateAdapter<Ranorex.ButtonTag>(true);
                }
            }

            /// <summary>
            /// The A0F21THSNATIONALLLC item info.
            /// </summary>
            [RepositoryItemInfo("0bf98207-7145-403e-bdbb-7408bdc8115b")]
            public virtual RepoItemInfo A0F21THSNATIONALLLCInfo
            {
                get
                {
                    return _a0f21thsnationalllcInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}