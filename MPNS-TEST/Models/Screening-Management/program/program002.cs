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

namespace MPNS_TEST.Models.Screening_Management.program
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The program002 recording.
    /// </summary>
    [TestModule("9370b6d8-53b1-41c1-9f70-9d96d05159ca", ModuleType.Recording, 1)]
    public partial class program002 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static program002 instance = new program002();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public program002()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static program002 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(1));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇002' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1990-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1990-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(5));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.新增早期样本' at Center.", repo.早期样本.新增早期样本Info, new RecordItemIndex(7));
            repo.早期样本.新增早期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'YBH00098' on item '早期样本.早期样本号'.", repo.早期样本.早期样本号Info, new RecordItemIndex(8));
            repo.早期样本.早期样本号.Element.SetAttributeValue("Value", "YBH00098");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-26' on item '早期样本.采样日期'.", repo.早期样本.采样日期Info, new RecordItemIndex(9));
            repo.早期样本.采样日期.Element.SetAttributeValue("Value", "2018-09-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-26' on item '早期样本.测试日期'.", repo.早期样本.测试日期Info, new RecordItemIndex(10));
            repo.早期样本.测试日期.Element.SetAttributeValue("Value", "2018-09-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '早期样本.体重'.", repo.早期样本.体重Info, new RecordItemIndex(11));
            repo.早期样本.体重.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-26' on item '早期样本.CRL日期'.", repo.早期样本.CRL日期Info, new RecordItemIndex(12));
            repo.早期样本.CRL日期.Element.SetAttributeValue("Value", "2018-09-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '早期样本.CRL长度'.", repo.早期样本.CRL长度Info, new RecordItemIndex(13));
            repo.早期样本.CRL长度.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '早期样本.NT_E结果'.", repo.早期样本.NT_E结果Info, new RecordItemIndex(14));
            repo.早期样本.NT_E结果.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '120000' on item '早期样本.单胎tbhCG_E结果'.", repo.早期样本.单胎tbhCG_E结果Info, new RecordItemIndex(15));
            repo.早期样本.单胎tbhCG_E结果.Element.SetAttributeValue("Value", "120000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '600' on item '早期样本.单胎PAPPA_E结果'.", repo.早期样本.单胎PAPPA_E结果Info, new RecordItemIndex(16));
            repo.早期样本.单胎PAPPA_E结果.Element.SetAttributeValue("Value", "600");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(17));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item '方案.增加方案'.", repo.方案.增加方案Info, new RecordItemIndex(18));
            repo.方案.增加方案.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.确定添加' at Center.", repo.方案.确定添加Info, new RecordItemIndex(19));
            repo.方案.确定添加.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(20));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(21));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
