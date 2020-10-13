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
    ///The sample034 recording.
    /// </summary>
    [TestModule("1f5b8ef4-3d94-459c-beca-1eb2765ed246", ModuleType.Recording, 1)]
    public partial class sample034 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample034 instance = new sample034();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample034()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample034 Instance
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇034' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇034");
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '早期样本.孕周类型'.", repo.早期样本.孕周类型Info, new RecordItemIndex(8));
            repo.早期样本.孕周类型.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.CRL日期' at Center.", repo.早期样本.CRL日期Info, new RecordItemIndex(9));
            repo.早期样本.CRL日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.CRL日期选择今天' at Center.", repo.早期样本.CRL日期选择今天Info, new RecordItemIndex(10));
            repo.早期样本.CRL日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.选择CRL孕周' at Center.", repo.早期样本.选择CRL孕周Info, new RecordItemIndex(11));
            repo.早期样本.选择CRL孕周.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '10' with focus on '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(12));
            repo.早期样本.CRL孕周周.PressKeys("10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(13));
            repo.早期样本.CRL孕周天.PressKeys("0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(14));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.早期样本.孕周截图, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(17));
            repo.早期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(18));
            repo.早期样本.CRL孕周天.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '13' with focus on '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(19));
            repo.早期样本.CRL孕周周.PressKeys("13");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6' with focus on '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(20));
            repo.早期样本.CRL孕周天.PressKeys("6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(21));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(22));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.早期样本.孕周截图, false, new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(24));
            repo.早期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(25));
            repo.早期样本.CRL孕周天.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '9' with focus on '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(26));
            repo.早期样本.CRL孕周周.PressKeys("9");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6' with focus on '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(27));
            repo.早期样本.CRL孕周天.PressKeys("6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(28));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(29));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.早期样本.计算提示, false, new RecordItemIndex(30));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.删除按钮' at Center.", repo.早期样本.删除按钮Info, new RecordItemIndex(31));
            repo.早期样本.删除按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(32));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on '早期样本'.", repo.早期样本.SelfInfo, new RecordItemIndex(33));
            repo.早期样本.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(34));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(35));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.CRL日期' at Center.", repo.中期样本.CRL日期Info, new RecordItemIndex(36));
            repo.中期样本.CRL日期.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.CRL日期选择今天' at Center.", repo.中期样本.CRL日期选择今天Info, new RecordItemIndex(37));
            repo.中期样本.CRL日期选择今天.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.选择CRL孕周' at Center.", repo.中期样本.选择CRL孕周Info, new RecordItemIndex(38));
            repo.中期样本.选择CRL孕周.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '15' with focus on '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(39));
            repo.中期样本.CRL孕周周.PressKeys("15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on '中期样本.CRL孕周天'.", repo.中期样本.CRL孕周天Info, new RecordItemIndex(40));
            repo.中期样本.CRL孕周天.PressKeys("0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(41));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(42));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.中期样本.孕周类型截图, false, new RecordItemIndex(43));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(44));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.CRL孕周天'.", repo.中期样本.CRL孕周天Info, new RecordItemIndex(45));
            repo.中期样本.CRL孕周天.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '20' with focus on '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(46));
            repo.中期样本.CRL孕周周.PressKeys("20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '6' with focus on '中期样本.CRL孕周天'.", repo.中期样本.CRL孕周天Info, new RecordItemIndex(47));
            repo.中期样本.CRL孕周天.PressKeys("6");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(48));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(49));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.中期样本.孕周类型截图, false, new RecordItemIndex(50));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(51));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1.1' with focus on '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(52));
            repo.中期样本.CRL孕周周.PressKeys("1.1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(53));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '21' with focus on '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(54));
            repo.中期样本.CRL孕周周.PressKeys("21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(55));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(56));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.中期样本.计算提示, false, new RecordItemIndex(57));
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(58));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'a' with focus on '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(59));
            repo.中期样本.CRL孕周周.PressKeys("a");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
