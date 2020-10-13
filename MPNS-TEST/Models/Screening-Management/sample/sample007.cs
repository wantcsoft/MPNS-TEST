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
    ///The sample007 recording.
    /// </summary>
    [TestModule("e41c36c0-fcb0-4391-b730-40adbdd5261a", ModuleType.Recording, 1)]
    public partial class sample007 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample007 instance = new sample007();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample007()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample007 Instance
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '孙孕妇007' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "孙孕妇007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.辅助妊娠史'.", repo.筛查信息.辅助妊娠史Info, new RecordItemIndex(5));
            repo.筛查信息.辅助妊娠史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(6));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(8));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '56732456787983' on item '中期样本.中期样本号'.", repo.中期样本.中期样本号Info, new RecordItemIndex(9));
            repo.中期样本.中期样本号.Element.SetAttributeValue("Value", "56732456787983");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '中期样本.采样日期'.", repo.中期样本.采样日期Info, new RecordItemIndex(10));
            repo.中期样本.采样日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '中期样本.测试日期'.", repo.中期样本.测试日期Info, new RecordItemIndex(11));
            repo.中期样本.测试日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '5' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(12));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '15' on item '中期样本.评估孕周周'.", repo.中期样本.评估孕周周Info, new RecordItemIndex(13));
            repo.中期样本.评估孕周周.Element.SetAttributeValue("Value", "15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '中期样本.评估孕周天'.", repo.中期样本.评估孕周天Info, new RecordItemIndex(14));
            repo.中期样本.评估孕周天.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(15));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(16));
            Delay.Duration(300, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.中期样本.孕周类型截图, false, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}