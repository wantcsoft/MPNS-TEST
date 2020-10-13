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
    ///The sample013 recording.
    /// </summary>
    [TestModule("8fa09517-ce94-45b2-9778-504f273fe14b", ModuleType.Recording, 1)]
    public partial class sample013 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample013 instance = new sample013();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample013()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample013 Instance
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张孕妇013' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "张孕妇013");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '筛查信息.胎数'.", repo.筛查信息.胎数Info, new RecordItemIndex(5));
            repo.筛查信息.胎数.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.辅助妊娠史'.", repo.筛查信息.辅助妊娠史Info, new RecordItemIndex(6));
            repo.筛查信息.辅助妊娠史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(7));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(9));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-06-26' on item '中期样本.LMP日期'.", repo.中期样本.LMP日期Info, new RecordItemIndex(10));
            repo.中期样本.LMP日期.Element.SetAttributeValue("Value", "2018-06-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-26' on item '中期样本.BPD日期'.", repo.中期样本.BPD日期Info, new RecordItemIndex(11));
            repo.中期样本.BPD日期.Element.SetAttributeValue("Value", "2018-09-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '中期样本.BPD长度'.", repo.中期样本.BPD长度Info, new RecordItemIndex(12));
            repo.中期样本.BPD长度.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '15' on item '中期样本.BPD孕周周'.", repo.中期样本.BPD孕周周Info, new RecordItemIndex(13));
            repo.中期样本.BPD孕周周.Element.SetAttributeValue("Value", "15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '中期样本.BPD孕周天'.", repo.中期样本.BPD孕周天Info, new RecordItemIndex(14));
            repo.中期样本.BPD孕周天.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '43' on item '中期样本.BPD胎儿1'.", repo.中期样本.BPD胎儿1Info, new RecordItemIndex(15));
            repo.中期样本.BPD胎儿1.Element.SetAttributeValue("Value", "43");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '45' on item '中期样本.BPD胎儿2'.", repo.中期样本.BPD胎儿2Info, new RecordItemIndex(16));
            repo.中期样本.BPD胎儿2.Element.SetAttributeValue("Value", "45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-26' on item '中期样本.CRL日期'.", repo.中期样本.CRL日期Info, new RecordItemIndex(17));
            repo.中期样本.CRL日期.Element.SetAttributeValue("Value", "2018-09-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '81' on item '中期样本.CRL长度'.", repo.中期样本.CRL长度Info, new RecordItemIndex(18));
            repo.中期样本.CRL长度.Element.SetAttributeValue("Value", "81");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '15' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(19));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", "15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '中期样本.CRL孕周天'.", repo.中期样本.CRL孕周天Info, new RecordItemIndex(20));
            repo.中期样本.CRL孕周天.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '80' on item '中期样本.CRL胎儿1'.", repo.中期样本.CRL胎儿1Info, new RecordItemIndex(21));
            repo.中期样本.CRL胎儿1.Element.SetAttributeValue("Value", "80");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '83' on item '中期样本.CRL胎儿2'.", repo.中期样本.CRL胎儿2Info, new RecordItemIndex(22));
            repo.中期样本.CRL胎儿2.Element.SetAttributeValue("Value", "83");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-06-26' on item '中期样本.取卵日期'.", repo.中期样本.取卵日期Info, new RecordItemIndex(23));
            repo.中期样本.取卵日期.Element.SetAttributeValue("Value", "2018-06-26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-06-27' on item '中期样本.植入日期'.", repo.中期样本.植入日期Info, new RecordItemIndex(24));
            repo.中期样本.植入日期.Element.SetAttributeValue("Value", "2018-06-27");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '中期样本.卵子日期'.", repo.中期样本.卵子日期Info, new RecordItemIndex(25));
            repo.中期样本.卵子日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.保存按钮' at Center.", repo.中期样本.保存按钮Info, new RecordItemIndex(26));
            repo.中期样本.保存按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}