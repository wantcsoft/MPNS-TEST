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

namespace MPNS_TEST.Models.Screening_Management.revisit
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The revisit001 recording.
    /// </summary>
    [TestModule("34510adb-6eea-4f2f-b096-5ea8df37621d", ModuleType.Recording, 1)]
    public partial class revisit001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static revisit001 instance = new revisit001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public revisit001()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static revisit001 Instance
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张孕妇001' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "张孕妇001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-02-10' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(4));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2020-02-10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(5));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(6));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(7));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(8));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '32432432432423' on item '中期样本.中期样本号'.", repo.中期样本.中期样本号Info, new RecordItemIndex(9));
            repo.中期样本.中期样本号.Element.SetAttributeValue("Value", "32432432432423");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-02-10' on item '中期样本.采样日期'.", repo.中期样本.采样日期Info, new RecordItemIndex(10));
            repo.中期样本.采样日期.Element.SetAttributeValue("Value", "2020-02-10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-02-10' on item '中期样本.测试日期'.", repo.中期样本.测试日期Info, new RecordItemIndex(11));
            repo.中期样本.测试日期.Element.SetAttributeValue("Value", "2020-02-10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-02-10' on item '中期样本.BPD日期'.", repo.中期样本.BPD日期Info, new RecordItemIndex(12));
            repo.中期样本.BPD日期.Element.SetAttributeValue("Value", "2020-02-10");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '中期样本.BPD长度'.", repo.中期样本.BPD长度Info, new RecordItemIndex(13));
            repo.中期样本.BPD长度.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '中期样本.体重'.", repo.中期样本.体重Info, new RecordItemIndex(14));
            repo.中期样本.体重.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(15));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '66' on item '中期样本.AFP_M结果'.", repo.中期样本.AFP_M结果Info, new RecordItemIndex(16));
            repo.中期样本.AFP_M结果.Element.SetAttributeValue("Value", "66");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '23000' on item '中期样本.tbhCG_M结果'.", repo.中期样本.tbhCG_M结果Info, new RecordItemIndex(17));
            repo.中期样本.tbhCG_M结果.Element.SetAttributeValue("Value", "23000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2' on item '中期样本.uE3_M结果'.", repo.中期样本.uE3_M结果Info, new RecordItemIndex(18));
            repo.中期样本.uE3_M结果.Element.SetAttributeValue("Value", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.保存按钮' at Center.", repo.中期样本.保存按钮Info, new RecordItemIndex(19));
            repo.中期样本.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(20));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(21));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.提交审核' at Center.", repo.方案.提交审核Info, new RecordItemIndex(22));
            repo.方案.提交审核.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(23));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.通过审核' at Center.", repo.方案.通过审核Info, new RecordItemIndex(24));
            repo.方案.通过审核.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(25));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(26));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查回访' at Center.", repo.页面头选择.筛查回访Info, new RecordItemIndex(27));
            repo.页面头选择.筛查回访.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(28));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.第一个回访对象' at Center.", repo.筛查回访.第一个回访对象Info, new RecordItemIndex(29));
            repo.筛查回访.第一个回访对象.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(30));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查回访.保存' at Center.", repo.筛查回访.保存Info, new RecordItemIndex(31));
            repo.筛查回访.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(32));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
