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

namespace MPNS_TEST.Models.Screening_Management.summary
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The summary019 recording.
    /// </summary>
    [TestModule("d4298a6a-06f9-4a3e-b1a3-a2917d1cad13", ModuleType.Recording, 1)]
    public partial class summary019 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static summary019 instance = new summary019();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public summary019()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static summary019 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(0));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.汇总信息' at Center.", repo.页面头选择.汇总信息Info, new RecordItemIndex(1));
            repo.页面头选择.汇总信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '刘孕妇' on item '汇总信息.搜索框'.", repo.汇总信息.搜索框Info, new RecordItemIndex(3));
            repo.汇总信息.搜索框.Element.SetAttributeValue("Value", "刘孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.搜索按钮' at Center.", repo.汇总信息.搜索按钮Info, new RecordItemIndex(4));
            repo.汇总信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}