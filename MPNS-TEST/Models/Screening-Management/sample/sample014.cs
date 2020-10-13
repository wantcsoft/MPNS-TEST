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
    ///The sample014 recording.
    /// </summary>
    [TestModule("d2e90f13-edc0-46e1-a830-1d4017b97a2f", ModuleType.Recording, 1)]
    public partial class sample014 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static sample014 instance = new sample014();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public sample014()
        {
            早期CRL = "";
            中期CRL = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static sample014 Instance
        {
            get { return instance; }
        }

#region Variables

        string _早期CRL;

        /// <summary>
        /// Gets or sets the value of variable 早期CRL.
        /// </summary>
        [TestVariable("ef34584b-a19a-4939-9608-472ea4cfb533")]
        public string 早期CRL
        {
            get { return _早期CRL; }
            set { _早期CRL = value; }
        }

        string _中期CRL;

        /// <summary>
        /// Gets or sets the value of variable 中期CRL.
        /// </summary>
        [TestVariable("5b57a054-6cd3-4535-bba9-a4546cb36569")]
        public string 中期CRL
        {
            get { return _中期CRL; }
            set { _中期CRL = value; }
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张孕妇014' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "张孕妇014");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '筛查信息.胎数'.", repo.筛查信息.胎数Info, new RecordItemIndex(5));
            repo.筛查信息.胎数.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(6));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.新增早期样本' at Center.", repo.早期样本.新增早期样本Info, new RecordItemIndex(8));
            repo.早期样本.新增早期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '43' on item '早期样本.CRL胎儿1'.", repo.早期样本.CRL胎儿1Info, new RecordItemIndex(9));
            repo.早期样本.CRL胎儿1.Element.SetAttributeValue("Value", "43");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '45' on item '早期样本.CRL胎儿2'.", repo.早期样本.CRL胎儿2Info, new RecordItemIndex(10));
            repo.早期样本.CRL胎儿2.Element.SetAttributeValue("Value", "45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.CRL胎儿1' at Center.", repo.早期样本.CRL胎儿1Info, new RecordItemIndex(11));
            repo.早期样本.CRL胎儿1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.CRL胎儿2' at Center.", repo.早期样本.CRL胎儿2Info, new RecordItemIndex(12));
            repo.早期样本.CRL胎儿2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '早期样本.CRL长度' and assigning its value to variable '早期CRL'.", repo.早期样本.CRL长度Info, new RecordItemIndex(13));
            早期CRL = repo.早期样本.CRL长度.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 早期CRL, new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(15));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '80' on item '中期样本.CRL胎儿1'.", repo.中期样本.CRL胎儿1Info, new RecordItemIndex(16));
            repo.中期样本.CRL胎儿1.Element.SetAttributeValue("Value", "80");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '82' on item '中期样本.CRL胎儿2'.", repo.中期样本.CRL胎儿2Info, new RecordItemIndex(17));
            repo.中期样本.CRL胎儿2.Element.SetAttributeValue("Value", "82");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.CRL胎儿1' at Center.", repo.中期样本.CRL胎儿1Info, new RecordItemIndex(18));
            repo.中期样本.CRL胎儿1.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.CRL胎儿2' at Center.", repo.中期样本.CRL胎儿2Info, new RecordItemIndex(19));
            repo.中期样本.CRL胎儿2.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '中期样本.CRL长度' and assigning its value to variable '中期CRL'.", repo.中期样本.CRL长度Info, new RecordItemIndex(20));
            中期CRL = repo.中期样本.CRL长度.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 中期CRL, new RecordItemIndex(21));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
