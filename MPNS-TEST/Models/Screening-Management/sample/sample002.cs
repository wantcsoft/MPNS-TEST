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

namespace MPNS_TEST.Models.Screening_Management.sample
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The sample002 recording.
    /// </summary>
    [TestModule("f31ba608-80b7-4acb-861e-5e62fda71b09", ModuleType.Recording, 1)]
    public partial class sample002 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample002 instance = new sample002();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample002()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample002 Instance
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

            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '226' on item '早期样本.双胎PAPPA_E结果'.", repo.早期样本.双胎PAPPA_E结果Info, new RecordItemIndex(0));
            repo.早期样本.双胎PAPPA_E结果.Element.SetAttributeValue("Value", "226");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-22' on item '中期样本.CRL日期'.", repo.中期样本.CRL日期Info, new RecordItemIndex(1));
            repo.中期样本.CRL日期.Element.SetAttributeValue("Value", "2018-08-22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(2));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item '中期样本.计算按钮'.", repo.中期样本.计算按钮Info, new RecordItemIndex(3));
            repo.中期样本.计算按钮.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '45' on item '中期样本.AFP_M结果'.", repo.中期样本.AFP_M结果Info, new RecordItemIndex(5));
            repo.中期样本.AFP_M结果.Element.SetAttributeValue("Value", "45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '33000' on item '中期样本.tbhCG_M结果'.", repo.中期样本.tbhCG_M结果Info, new RecordItemIndex(6));
            repo.中期样本.tbhCG_M结果.Element.SetAttributeValue("Value", "33000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1.3' on item '中期样本.uE3_M结果'.", repo.中期样本.uE3_M结果Info, new RecordItemIndex(7));
            repo.中期样本.uE3_M结果.Element.SetAttributeValue("Value", "1.3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(8));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(9));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(10));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(11));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '5' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(12));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(13));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '15' on item '中期样本.评估孕周周'.", repo.中期样本.评估孕周周Info, new RecordItemIndex(14));
            repo.中期样本.评估孕周周.Element.SetAttributeValue("Value", "15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '4' on item '中期样本.评估孕周天'.", repo.中期样本.评估孕周天Info, new RecordItemIndex(15));
            repo.中期样本.评估孕周天.Element.SetAttributeValue("Value", "4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(16));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.保存按钮' at Center.", repo.中期样本.保存按钮Info, new RecordItemIndex(18));
            repo.中期样本.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(19));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(20));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(21));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(22));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(23));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(24));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '中期样本.CRL日期'.", repo.中期样本.CRL日期Info, new RecordItemIndex(25));
            repo.中期样本.CRL日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(26));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(27));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(28));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(29));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
