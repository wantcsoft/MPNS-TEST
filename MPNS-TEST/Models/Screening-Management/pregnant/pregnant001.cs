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

namespace MPNS_TEST.Models.Screening_Management.pregnant
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The pregnant001 recording.
    /// </summary>
    [TestModule("4998a133-296c-437d-8260-27830c8d2402", ModuleType.Recording, 1)]
    public partial class pregnant001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static pregnant001 instance = new pregnant001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public pregnant001()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static pregnant001 Instance
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '赵孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "赵孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00001' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(5));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(6));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00001' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(7));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(8));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000001' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(9));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-01' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(10));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(11));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(12));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(13));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(14));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(15));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '钱孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(16));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "钱孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(17));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00002' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(18));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(19));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00002' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(20));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(21));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000002' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(22));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-02' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(23));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-02");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(24));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(25));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(26));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(27));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(28));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '孙孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(29));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "孙孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(30));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00003' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(31));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00003");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(32));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00003' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(33));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00003");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(34));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000003' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(35));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000003");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-03' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(36));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-03");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(37));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(38));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(39));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(40));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(41));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '李孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(42));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "李孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(43));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00004' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(44));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(45));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00004' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(46));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '4' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(47));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "4");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000004' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(48));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000004");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-04' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(49));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-04");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(50));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(51));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(52));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(53));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(54));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(55));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(56));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00005' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(57));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00005");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(58));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00005' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(59));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00005");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '5' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(60));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "5");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000005' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(61));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000005");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-05' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(62));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-05");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(63));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(64));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(65));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(66));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(67));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '吴孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(68));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "吴孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(69));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00006' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(70));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00006");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(71));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00006' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(72));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00006");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(73));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000006' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(74));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000006");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-06' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(75));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-06");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(76));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(77));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(78));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(79));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(80));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '郑孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(81));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "郑孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(82));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00007' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(83));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "BLH00007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '筛查信息.身份证社保卡'.", repo.筛查信息.身份证社保卡Info, new RecordItemIndex(84));
            repo.筛查信息.身份证社保卡.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '00007' on item '筛查信息.社保卡号'.", repo.筛查信息.社保卡号Info, new RecordItemIndex(85));
            repo.筛查信息.社保卡号.Element.SetAttributeValue("Value", "00007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '筛查信息.人种'.", repo.筛查信息.人种Info, new RecordItemIndex(86));
            repo.筛查信息.人种.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13000000007' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(87));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13000000007");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-10-07' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(88));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-10-07");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(89));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(90));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(91));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.孕妇信息' at Center.", repo.页面头选择.孕妇信息Info, new RecordItemIndex(92));
            repo.页面头选择.孕妇信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(93));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '赵孕妇' on item '孕妇信息.搜索框'.", repo.孕妇信息.搜索框Info, new RecordItemIndex(94));
            repo.孕妇信息.搜索框.Element.SetAttributeValue("Value", "赵孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.搜索按钮' at Center.", repo.孕妇信息.搜索按钮Info, new RecordItemIndex(95));
            repo.孕妇信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(96));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH00002' on item '孕妇信息.搜索框'.", repo.孕妇信息.搜索框Info, new RecordItemIndex(97));
            repo.孕妇信息.搜索框.Element.SetAttributeValue("Value", "BLH00002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.搜索按钮' at Center.", repo.孕妇信息.搜索按钮Info, new RecordItemIndex(98));
            repo.孕妇信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(99));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'MOZ00003' on item '孕妇信息.搜索框'.", repo.孕妇信息.搜索框Info, new RecordItemIndex(100));
            repo.孕妇信息.搜索框.Element.SetAttributeValue("Value", "MOZ00003");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.搜索按钮' at Center.", repo.孕妇信息.搜索按钮Info, new RecordItemIndex(101));
            repo.孕妇信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(102));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '孕妇' on item '孕妇信息.搜索框'.", repo.孕妇信息.搜索框Info, new RecordItemIndex(103));
            repo.孕妇信息.搜索框.Element.SetAttributeValue("Value", "孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.搜索按钮' at Center.", repo.孕妇信息.搜索按钮Info, new RecordItemIndex(104));
            repo.孕妇信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(105));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.表头' at Center.", repo.孕妇信息.表头Info, new RecordItemIndex(106));
            repo.孕妇信息.表头.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(107));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.添加所有' at Center.", repo.孕妇信息.添加所有Info, new RecordItemIndex(108));
            repo.孕妇信息.添加所有.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(109));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.保存' at Center.", repo.孕妇信息.保存Info, new RecordItemIndex(110));
            repo.孕妇信息.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.保存确定' at Center.", repo.孕妇信息.保存确定Info, new RecordItemIndex(111));
            repo.孕妇信息.保存确定.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
