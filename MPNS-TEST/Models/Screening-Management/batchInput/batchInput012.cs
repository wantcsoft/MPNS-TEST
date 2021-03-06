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

namespace MPNS_TEST.Models.Screening_Management.batchInput
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The batchInput012 recording.
    /// </summary>
    [TestModule("a4ec182e-cf90-4fea-94e1-c96ee4b9fb1c", ModuleType.Recording, 1)]
    public partial class batchInput012 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static batchInput012 instance = new batchInput012();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public batchInput012()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static batchInput012 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.维护管理' at Center.", repo.页面头选择.维护管理Info, new RecordItemIndex(0));
            repo.页面头选择.维护管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.参数信息' at Center.", repo.页面头选择.参数信息Info, new RecordItemIndex(1));
            repo.页面头选择.参数信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '数据来源.数据来源' at Center.", repo.数据来源.数据来源Info, new RecordItemIndex(3));
            repo.数据来源.数据来源.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -2000 units.", new RecordItemIndex(5));
            Mouse.ScrollWheel(-2000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -2000 units.", new RecordItemIndex(6));
            Mouse.ScrollWheel(-2000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '数据来源.批量录入关联依据'.", repo.数据来源.批量录入关联依据Info, new RecordItemIndex(7));
            repo.数据来源.批量录入关联依据.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(8));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '数据来源.保存按钮' at Center.", repo.数据来源.保存按钮Info, new RecordItemIndex(9));
            repo.数据来源.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(10));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(12));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(13));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '钱孕妇' on item '筛查信息查询.搜索框内容'.", repo.筛查信息查询.搜索框内容Info, new RecordItemIndex(15));
            repo.筛查信息查询.搜索框内容.Element.SetAttributeValue("Value", "钱孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息查询.点击搜索' at Center.", repo.筛查信息查询.点击搜索Info, new RecordItemIndex(16));
            repo.筛查信息查询.点击搜索.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(17));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息查询.搜索到的第一人' at Center.", repo.筛查信息查询.搜索到的第一人Info, new RecordItemIndex(18));
            repo.筛查信息查询.搜索到的第一人.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(19));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.已经保存的中期样本' at Center.", repo.中期样本.已经保存的中期样本Info, new RecordItemIndex(20));
            repo.中期样本.已经保存的中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(21));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.删除按钮' at Center.", repo.中期样本.删除按钮Info, new RecordItemIndex(22));
            repo.中期样本.删除按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(23));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(24));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '310105199901020002' on item '筛查信息.身份证号'.", repo.筛查信息.身份证号Info, new RecordItemIndex(25));
            repo.筛查信息.身份证号.Element.SetAttributeValue("Value", "310105199901020002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(26));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2019/11/02' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(27));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2019/11/02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(28));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(29));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(30));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.批量录入' at Center.", repo.页面头选择.批量录入Info, new RecordItemIndex(31));
            repo.页面头选择.批量录入.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2019/11/02' on item '筛查管理批量录入.开始日期'.", repo.筛查管理批量录入.开始日期Info, new RecordItemIndex(32));
            repo.筛查管理批量录入.开始日期.Element.SetAttributeValue("Value", "2019/11/02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2019/11/02' on item '筛查管理批量录入.结束日期'.", repo.筛查管理批量录入.结束日期Info, new RecordItemIndex(33));
            repo.筛查管理批量录入.结束日期.Element.SetAttributeValue("Value", "2019/11/02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.外部查询' at Center.", repo.筛查管理批量录入.外部查询Info, new RecordItemIndex(34));
            repo.筛查管理批量录入.外部查询.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(35));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.全选框' at Center.", repo.筛查管理批量录入.全选框Info, new RecordItemIndex(36));
            repo.筛查管理批量录入.全选框.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.保存' at Center.", repo.筛查管理批量录入.保存Info, new RecordItemIndex(37));
            repo.筛查管理批量录入.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.确定导入' at Center.", repo.筛查管理批量录入.确定导入Info, new RecordItemIndex(38));
            repo.筛查管理批量录入.确定导入.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(39));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(40));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
