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

namespace MPNS_TEST.Models.Screening_Management.batchInput
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The batchInput008 recording.
    /// </summary>
    [TestModule("a9b3b447-ffd8-406f-bf90-9a38e8d1b6ea", ModuleType.Recording, 1)]
    public partial class batchInput008 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static batchInput008 instance = new batchInput008();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public batchInput008()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static batchInput008 Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2019/11/02' on item '筛查管理批量录入.开始日期'.", repo.筛查管理批量录入.开始日期Info, new RecordItemIndex(0));
            repo.筛查管理批量录入.开始日期.Element.SetAttributeValue("Value", "2019/11/02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2019/11/03' on item '筛查管理批量录入.结束日期'.", repo.筛查管理批量录入.结束日期Info, new RecordItemIndex(1));
            repo.筛查管理批量录入.结束日期.Element.SetAttributeValue("Value", "2019/11/03");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.外部查询' at Center.", repo.筛查管理批量录入.外部查询Info, new RecordItemIndex(2));
            repo.筛查管理批量录入.外部查询.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(3));
            Delay.Duration(300, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
