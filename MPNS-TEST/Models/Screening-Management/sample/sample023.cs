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
    ///The sample023 recording.
    /// </summary>
    [TestModule("e4ad5588-0ac6-4c85-a41b-9415ef9e87d8", ModuleType.Recording, 1)]
    public partial class sample023 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample023 instance = new sample023();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample023()
        {
            早期LMP日期 = "";
            中期LMP日期 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample023 Instance
        {
            get { return instance; }
        }

#region Variables

        string _早期LMP日期;

        /// <summary>
        /// Gets or sets the value of variable 早期LMP日期.
        /// </summary>
        [TestVariable("1ac9c8aa-c408-4d38-990b-30b0be4c07e8")]
        public string 早期LMP日期
        {
            get { return _早期LMP日期; }
            set { _早期LMP日期 = value; }
        }

        string _中期LMP日期;

        /// <summary>
        /// Gets or sets the value of variable 中期LMP日期.
        /// </summary>
        [TestVariable("d0fe4106-5b96-4eac-9d12-20246c79ccbd")]
        public string 中期LMP日期
        {
            get { return _中期LMP日期; }
            set { _中期LMP日期 = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(0));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(1));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇023' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇023");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1990-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1990-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(5));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.新增早期样本' at Center.", repo.早期样本.新增早期样本Info, new RecordItemIndex(7));
            repo.早期样本.新增早期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.LMP日期' at Center.", repo.早期样本.LMP日期Info, new RecordItemIndex(8));
            repo.早期样本.LMP日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.LMP日期选择今天' at Center.", repo.早期样本.LMP日期选择今天Info, new RecordItemIndex(9));
            repo.早期样本.LMP日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '早期样本.LMP日期' and assigning its value to variable '早期LMP日期'.", repo.早期样本.LMP日期Info, new RecordItemIndex(10));
            早期LMP日期 = repo.早期样本.LMP日期.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 早期LMP日期, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '早期样本.孕周类型'.", repo.早期样本.孕周类型Info, new RecordItemIndex(12));
            repo.早期样本.孕周类型.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '早期样本.LMP日期'.", repo.早期样本.LMP日期Info, new RecordItemIndex(13));
            repo.早期样本.LMP日期.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(14));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.早期样本.计算提示, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.删除按钮' at Center.", repo.早期样本.删除按钮Info, new RecordItemIndex(17));
            repo.早期样本.删除按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(18));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on '早期样本'.", repo.早期样本.SelfInfo, new RecordItemIndex(19));
            repo.早期样本.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(20));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.LMP日期' at Center.", repo.中期样本.LMP日期Info, new RecordItemIndex(21));
            repo.中期样本.LMP日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.LMP日期选择今天' at Center.", repo.中期样本.LMP日期选择今天Info, new RecordItemIndex(22));
            repo.中期样本.LMP日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '中期样本.LMP日期' and assigning its value to variable '中期LMP日期'.", repo.中期样本.LMP日期Info, new RecordItemIndex(23));
            中期LMP日期 = repo.中期样本.LMP日期.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 中期LMP日期, new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(25));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.LMP日期'.", repo.中期样本.LMP日期Info, new RecordItemIndex(26));
            repo.中期样本.LMP日期.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(27));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.中期样本.计算提示, false, new RecordItemIndex(28));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}