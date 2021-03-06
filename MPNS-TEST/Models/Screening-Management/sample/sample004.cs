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
    ///The sample004 recording.
    /// </summary>
    [TestModule("9c23ee36-1eec-47c1-9731-f5f85bfb22f1", ModuleType.Recording, 1)]
    public partial class sample004 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample004 instance = new sample004();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample004()
        {
            预产期 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample004 Instance
        {
            get { return instance; }
        }

#region Variables

        string _预产期;

        /// <summary>
        /// Gets or sets the value of variable 预产期.
        /// </summary>
        [TestVariable("41e0068f-59f9-4a24-b9ad-56f844efc3a4")]
        public string 预产期
        {
            get { return _预产期; }
            set { _预产期 = value; }
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
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '钱孕妇004' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "钱孕妇004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1994-9-29' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1994-9-29");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(5));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(6));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(7));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(8));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '346237468732324' on item '中期样本.新增中期样本'.", repo.中期样本.新增中期样本Info, new RecordItemIndex(9));
            repo.中期样本.新增中期样本.Element.SetAttributeValue("Value", "346237468732324");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '中期样本.采样日期'.", repo.中期样本.采样日期Info, new RecordItemIndex(10));
            repo.中期样本.采样日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '中期样本.测试日期'.", repo.中期样本.测试日期Info, new RecordItemIndex(11));
            repo.中期样本.测试日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-05-08' on item '中期样本.LMP日期'.", repo.中期样本.LMP日期Info, new RecordItemIndex(12));
            repo.中期样本.LMP日期.Element.SetAttributeValue("Value", "2018-05-08");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '中期样本.孕周类型'.", repo.中期样本.孕周类型Info, new RecordItemIndex(13));
            repo.中期样本.孕周类型.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking Focus() on item '中期样本.计算按钮'.", repo.中期样本.计算按钮Info, new RecordItemIndex(14));
            repo.中期样本.计算按钮.Focus();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(15));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '中期样本.预产期' and assigning its value to variable '预产期'.", repo.中期样本.预产期Info, new RecordItemIndex(16));
            预产期 = repo.中期样本.预产期.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 预产期, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
