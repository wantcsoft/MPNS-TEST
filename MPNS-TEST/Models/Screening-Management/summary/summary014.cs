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
    ///The summary014 recording.
    /// </summary>
    [TestModule("0d3d7192-36ef-40d6-bb56-e284373a93ee", ModuleType.Recording, 1)]
    public partial class summary014 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static summary014 instance = new summary014();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public summary014()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static summary014 Instance
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.高级查询' at Center.", repo.汇总信息.高级查询Info, new RecordItemIndex(3));
            repo.汇总信息.高级查询.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.样本信息' at Center.", repo.汇总信息.样本信息Info, new RecordItemIndex(5));
            repo.汇总信息.样本信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '0' on item '汇总信息.样本阶段选择'.", repo.汇总信息.样本阶段选择Info, new RecordItemIndex(6));
            repo.汇总信息.样本阶段选择.Element.SetAttributeValue("TagValue", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.中期标记物' at Center.", repo.汇总信息.中期标记物Info, new RecordItemIndex(7));
            repo.汇总信息.中期标记物.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '汇总信息.AFPMOMM1'.", repo.汇总信息.AFPMOMM1Info, new RecordItemIndex(8));
            repo.汇总信息.AFPMOMM1.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2' on item '汇总信息.AFPMOMM2'.", repo.汇总信息.AFPMOMM2Info, new RecordItemIndex(9));
            repo.汇总信息.AFPMOMM2.Element.SetAttributeValue("Value", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0' on item '汇总信息.HCGMOMM1'.", repo.汇总信息.HCGMOMM1Info, new RecordItemIndex(10));
            repo.汇总信息.HCGMOMM1.Element.SetAttributeValue("Value", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '汇总信息.HCGMOMM2'.", repo.汇总信息.HCGMOMM2Info, new RecordItemIndex(11));
            repo.汇总信息.HCGMOMM2.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0' on item '汇总信息.UE3MOMM1'.", repo.汇总信息.UE3MOMM1Info, new RecordItemIndex(12));
            repo.汇总信息.UE3MOMM1.Element.SetAttributeValue("Value", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2' on item '汇总信息.UE3MOMM2'.", repo.汇总信息.UE3MOMM2Info, new RecordItemIndex(13));
            repo.汇总信息.UE3MOMM2.Element.SetAttributeValue("Value", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '汇总信息.UE3M1'.", repo.汇总信息.UE3M1Info, new RecordItemIndex(14));
            repo.汇总信息.UE3M1.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2' on item '汇总信息.UE3M2'.", repo.汇总信息.UE3M2Info, new RecordItemIndex(15));
            repo.汇总信息.UE3M2.Element.SetAttributeValue("Value", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '10' on item '汇总信息.AFPM1'.", repo.汇总信息.AFPM1Info, new RecordItemIndex(16));
            repo.汇总信息.AFPM1.Element.SetAttributeValue("Value", "10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '50' on item '汇总信息.AFPM2'.", repo.汇总信息.AFPM2Info, new RecordItemIndex(17));
            repo.汇总信息.AFPM2.Element.SetAttributeValue("Value", "50");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '10000' on item '汇总信息.HCGM1'.", repo.汇总信息.HCGM1Info, new RecordItemIndex(18));
            repo.汇总信息.HCGM1.Element.SetAttributeValue("Value", "10000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '50000' on item '汇总信息.HCGM2'.", repo.汇总信息.HCGM2Info, new RecordItemIndex(19));
            repo.汇总信息.HCGM2.Element.SetAttributeValue("Value", "50000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '汇总信息.元素间关系'.", repo.汇总信息.元素间关系Info, new RecordItemIndex(20));
            repo.汇总信息.元素间关系.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.高级搜索按钮' at Center.", repo.汇总信息.高级搜索按钮Info, new RecordItemIndex(21));
            repo.汇总信息.高级搜索按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}