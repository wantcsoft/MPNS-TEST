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

namespace MPNS_TEST.Models.Screening_Management.Infomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The infomation002 recording.
    /// </summary>
    [TestModule("9a1e45d9-12b1-40f6-a9d8-b4fa287db77b", ModuleType.Recording, 1)]
    public partial class infomation002 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.infomation.infomation002 repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.infomation.infomation002 repo = global::MPNS_TEST.Repositorys.infomation.infomation002.Instance;

        static infomation002 instance = new infomation002();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public infomation002()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static infomation002 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.筛查管理' at Center.", repo.筛查信息.筛查管理Info, new RecordItemIndex(0));
            repo.筛查信息.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.筛查信息' at Center.", repo.筛查信息.筛查信息Info, new RecordItemIndex(1));
            repo.筛查信息.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'blh0001' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(3));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "blh0001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(4));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1988-01-08' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(5));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1988-01-08");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(6));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.胎数'.", repo.筛查信息.胎数Info, new RecordItemIndex(7));
            repo.筛查信息.胎数.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1' on item '筛查信息.孕次'.", repo.筛查信息.孕次Info, new RecordItemIndex(8));
            repo.筛查信息.孕次.Element.SetAttributeValue("Value", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0' on item '筛查信息.产次'.", repo.筛查信息.产次Info, new RecordItemIndex(9));
            repo.筛查信息.产次.Element.SetAttributeValue("Value", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.糖尿病史'.", repo.筛查信息.糖尿病史Info, new RecordItemIndex(10));
            repo.筛查信息.糖尿病史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.吸烟史'.", repo.筛查信息.吸烟史Info, new RecordItemIndex(11));
            repo.筛查信息.吸烟史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.唐氏病史'.", repo.筛查信息.唐氏病史Info, new RecordItemIndex(12));
            repo.筛查信息.唐氏病史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.辅助妊娠史'.", repo.筛查信息.辅助妊娠史Info, new RecordItemIndex(13));
            repo.筛查信息.辅助妊娠史.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '310105198801082134' on item '筛查信息.身份证号'.", repo.筛查信息.身份证号Info, new RecordItemIndex(14));
            repo.筛查信息.身份证号.Element.SetAttributeValue("Value", "310105198801082134");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.身份证社保卡' at Center.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(15));
            repo.筛查信息.身份证社保卡.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(16));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '310105198801082134' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(17));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "310105198801082134");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '长宁区' on item '筛查信息.家庭地址'.", repo.筛查信息.家庭地址Info, new RecordItemIndex(18));
            repo.筛查信息.家庭地址.Element.SetAttributeValue("Value", "长宁区");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13764515239' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(19));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13764515239");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(20));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
