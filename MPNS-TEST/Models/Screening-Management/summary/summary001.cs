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

namespace MPNS_TEST.Models.Screening_Management.summary
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The summary001 recording.
    /// </summary>
    [TestModule("28eea034-045c-4e82-9071-6aa2bda9f43c", ModuleType.Recording, 1)]
    public partial class summary001 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static summary001 instance = new summary001();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public summary001()
        {
            筛查号 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static summary001 Instance
        {
            get { return instance; }
        }

#region Variables

        string _筛查号;

        /// <summary>
        /// Gets or sets the value of variable 筛查号.
        /// </summary>
        [TestVariable("4c094766-fc89-40ed-aa53-6a6749c4b372")]
        public string 筛查号
        {
            get { return _筛查号; }
            set { _筛查号 = value; }
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

            deleteData();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(1));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.登出' at Center.", repo.页面头选择.登出Info, new RecordItemIndex(2));
            repo.页面头选择.登出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.确定登出' at Center.", repo.页面头选择.确定登出Info, new RecordItemIndex(3));
            repo.页面头选择.确定登出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'Administrator' on item '登录信息.账号'.", repo.登录信息.账号Info, new RecordItemIndex(5));
            repo.登录信息.账号.Element.SetAttributeValue("Value", "Administrator");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '123456' on item '登录信息.密码'.", repo.登录信息.密码Info, new RecordItemIndex(6));
            repo.登录信息.密码.Element.SetAttributeValue("Value", "123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '登录信息.登录按钮' at Center.", repo.登录信息.登录按钮Info, new RecordItemIndex(7));
            repo.登录信息.登录按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.基础信息管理' at Center.", repo.页面头选择.基础信息管理Info, new RecordItemIndex(9));
            repo.页面头选择.基础信息管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.角色管理' at Center.", repo.页面头选择.角色管理Info, new RecordItemIndex(10));
            repo.页面头选择.角色管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(11));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '角色管理.编辑医生' at Center.", repo.角色管理.编辑医生Info, new RecordItemIndex(12));
            repo.角色管理.编辑医生.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '角色管理.编辑全选' at Center.", repo.角色管理.编辑全选Info, new RecordItemIndex(13));
            repo.角色管理.编辑全选.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(14));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.用户管理删除'.", repo.角色管理.用户管理删除Info, new RecordItemIndex(15));
            repo.角色管理.用户管理删除.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.用户管理编辑'.", repo.角色管理.用户管理编辑Info, new RecordItemIndex(16));
            repo.角色管理.用户管理编辑.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.用户管理新增'.", repo.角色管理.用户管理新增Info, new RecordItemIndex(17));
            repo.角色管理.用户管理新增.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.角色管理删除'.", repo.角色管理.角色管理删除Info, new RecordItemIndex(18));
            repo.角色管理.角色管理删除.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.角色管理编辑'.", repo.角色管理.角色管理编辑Info, new RecordItemIndex(19));
            repo.角色管理.角色管理编辑.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'false' on item '角色管理.角色管理新增'.", repo.角色管理.角色管理新增Info, new RecordItemIndex(20));
            repo.角色管理.角色管理新增.Element.SetAttributeValue("Checked", "false");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(21));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(22));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '角色管理.保存角色信息' at Center.", repo.角色管理.保存角色信息Info, new RecordItemIndex(23));
            repo.角色管理.保存角色信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '角色管理.保存成功确定' at Center.", repo.角色管理.保存成功确定Info, new RecordItemIndex(24));
            repo.角色管理.保存成功确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(25));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.基础信息管理' at Center.", repo.页面头选择.基础信息管理Info, new RecordItemIndex(26));
            repo.页面头选择.基础信息管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.医院医生' at Center.", repo.页面头选择.医院医生Info, new RecordItemIndex(27));
            repo.页面头选择.医院医生.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(28));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '医院医生.新增医生' at Center.", repo.医院医生.新增医生Info, new RecordItemIndex(29));
            repo.医院医生.新增医生.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '第二人民医院' on item '医院医生.来源单位'.", repo.医院医生.来源单位Info, new RecordItemIndex(30));
            repo.医院医生.来源单位.Element.SetAttributeValue("Value", "第二人民医院");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张医生' on item '医院医生.送检医生'.", repo.医院医生.送检医生Info, new RecordItemIndex(31));
            repo.医院医生.送检医生.Element.SetAttributeValue("Value", "张医生");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '医院医生.保存' at Center.", repo.医院医生.保存Info, new RecordItemIndex(32));
            repo.医院医生.保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(33));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '医院医生.确定' at Center.", repo.医院医生.确定Info, new RecordItemIndex(34));
            repo.医院医生.确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(35));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.基础信息管理' at Center.", repo.页面头选择.基础信息管理Info, new RecordItemIndex(36));
            repo.页面头选择.基础信息管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.用户管理' at Center.", repo.页面头选择.用户管理Info, new RecordItemIndex(37));
            repo.页面头选择.用户管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(38));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '用户管理.新增用户' at Center.", repo.用户管理.新增用户Info, new RecordItemIndex(39));
            repo.用户管理.新增用户.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(40));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1000001' on item '用户管理.账号'.", repo.用户管理.账号Info, new RecordItemIndex(41));
            repo.用户管理.账号.Element.SetAttributeValue("Value", "1000001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张医生' on item '用户管理.医生姓名'.", repo.用户管理.医生姓名Info, new RecordItemIndex(42));
            repo.用户管理.医生姓名.Element.SetAttributeValue("Value", "张医生");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '123456' on item '用户管理.密码'.", repo.用户管理.密码Info, new RecordItemIndex(43));
            repo.用户管理.密码.Element.SetAttributeValue("Value", "123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'e87075b6-dbe7-41b5-b888-8258996a1952' on item '用户管理.角色'.", repo.用户管理.角色Info, new RecordItemIndex(44));
            repo.用户管理.角色.Element.SetAttributeValue("TagValue", "e87075b6-dbe7-41b5-b888-8258996a1952");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '第二人民医院' on item '用户管理.来源单位'.", repo.用户管理.来源单位Info, new RecordItemIndex(45));
            repo.用户管理.来源单位.Element.SetAttributeValue("TagValue", "第二人民医院");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item '用户管理.启用账户'.", repo.用户管理.启用账户Info, new RecordItemIndex(46));
            repo.用户管理.启用账户.Element.SetAttributeValue("Checked", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '用户管理.保存用户信息' at Center.", repo.用户管理.保存用户信息Info, new RecordItemIndex(47));
            repo.用户管理.保存用户信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(48));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '用户管理.保存确定' at Center.", repo.用户管理.保存确定Info, new RecordItemIndex(49));
            repo.用户管理.保存确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(50));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.登出' at Center.", repo.页面头选择.登出Info, new RecordItemIndex(51));
            repo.页面头选择.登出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.确定登出' at Center.", repo.页面头选择.确定登出Info, new RecordItemIndex(52));
            repo.页面头选择.确定登出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(53));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1000001' on item '登录信息.账号'.", repo.登录信息.账号Info, new RecordItemIndex(54));
            repo.登录信息.账号.Element.SetAttributeValue("Value", "1000001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '123456' on item '登录信息.密码'.", repo.登录信息.密码Info, new RecordItemIndex(55));
            repo.登录信息.密码.Element.SetAttributeValue("Value", "123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '登录信息.登录按钮' at Center.", repo.登录信息.登录按钮Info, new RecordItemIndex(56));
            repo.登录信息.登录按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(57));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(58));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查信息' at Center.", repo.页面头选择.筛查信息Info, new RecordItemIndex(59));
            repo.页面头选择.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(60));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '张孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(61));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "张孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'blh0002' on item '筛查信息.病历号'.", repo.筛查信息.病历号Info, new RecordItemIndex(62));
            repo.筛查信息.病历号.Element.SetAttributeValue("Value", "blh0002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(63));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '0' on item '筛查信息.胎数'.", repo.筛查信息.胎数Info, new RecordItemIndex(64));
            repo.筛查信息.胎数.Element.SetAttributeValue("TagValue", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-05-15' on item '筛查信息.登记日期'.", repo.筛查信息.登记日期Info, new RecordItemIndex(65));
            repo.筛查信息.登记日期.Element.SetAttributeValue("Value", "2018-05-15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '13345676893' on item '筛查信息.联系电话'.", repo.筛查信息.联系电话Info, new RecordItemIndex(66));
            repo.筛查信息.联系电话.Element.SetAttributeValue("Value", "13345676893");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(67));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(68));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'Value' from item '筛查信息.筛查号' and assigning its value to variable '筛查号'.", repo.筛查信息.筛查号Info, new RecordItemIndex(69));
            筛查号 = repo.筛查信息.筛查号.Element.GetAttributeValueText("Value");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", 筛查号, new RecordItemIndex(70));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.新增早期样本' at Center.", repo.早期样本.新增早期样本Info, new RecordItemIndex(71));
            repo.早期样本.新增早期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '早期样本.采样日期'.", repo.早期样本.采样日期Info, new RecordItemIndex(72));
            repo.早期样本.采样日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '早期样本.测试日期'.", repo.早期样本.测试日期Info, new RecordItemIndex(73));
            repo.早期样本.测试日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'YBH00009' on item '早期样本.早期样本号'.", repo.早期样本.早期样本号Info, new RecordItemIndex(74));
            repo.早期样本.早期样本号.Element.SetAttributeValue("Value", "YBH00009");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '早期样本.体重'.", repo.早期样本.体重Info, new RecordItemIndex(75));
            repo.早期样本.体重.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-08-21' on item '早期样本.CRL日期'.", repo.早期样本.CRL日期Info, new RecordItemIndex(76));
            repo.早期样本.CRL日期.Element.SetAttributeValue("Value", "2018-08-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '44' on item '早期样本.CRL长度'.", repo.早期样本.CRL长度Info, new RecordItemIndex(77));
            repo.早期样本.CRL长度.Element.SetAttributeValue("Value", "44");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(78));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0.66' on item '早期样本.NT_E结果'.", repo.早期样本.NT_E结果Info, new RecordItemIndex(79));
            repo.早期样本.NT_E结果.Element.SetAttributeValue("Value", "0.66");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '22000' on item '早期样本.单胎tbhCG_E结果'.", repo.早期样本.单胎tbhCG_E结果Info, new RecordItemIndex(80));
            repo.早期样本.单胎tbhCG_E结果.Element.SetAttributeValue("Value", "22000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '226' on item '早期样本.单胎PAPPA_E结果'.", repo.早期样本.单胎PAPPA_E结果Info, new RecordItemIndex(81));
            repo.早期样本.单胎PAPPA_E结果.Element.SetAttributeValue("Value", "226");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '李医生' on item '早期样本.送检医生'.", repo.早期样本.送检医生Info, new RecordItemIndex(82));
            repo.早期样本.送检医生.Element.SetAttributeValue("Value", "李医生");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '第一人民医院' on item '早期样本.单位来源'.", repo.早期样本.单位来源Info, new RecordItemIndex(83));
            repo.早期样本.单位来源.Element.SetAttributeValue("Value", "第一人民医院");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.保存按钮' at Center.", repo.早期样本.保存按钮Info, new RecordItemIndex(84));
            repo.早期样本.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(85));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.新增中期样本' at Center.", repo.中期样本.新增中期样本Info, new RecordItemIndex(86));
            repo.中期样本.新增中期样本.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(87));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -3000 units.", new RecordItemIndex(88));
            Mouse.ScrollWheel(-3000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-21' on item '中期样本.采样日期'.", repo.中期样本.采样日期Info, new RecordItemIndex(89));
            repo.中期样本.采样日期.Element.SetAttributeValue("Value", "2018-09-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2018-09-21' on item '中期样本.测试日期'.", repo.中期样本.测试日期Info, new RecordItemIndex(90));
            repo.中期样本.测试日期.Element.SetAttributeValue("Value", "2018-09-21");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'YBH00010' on item '中期样本.中期样本号'.", repo.中期样本.中期样本号Info, new RecordItemIndex(91));
            repo.中期样本.中期样本号.Element.SetAttributeValue("Value", "YBH00010");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '46' on item '中期样本.体重'.", repo.中期样本.体重Info, new RecordItemIndex(92));
            repo.中期样本.体重.Element.SetAttributeValue("Value", "46");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(93));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '45' on item '中期样本.AFP_M结果'.", repo.中期样本.AFP_M结果Info, new RecordItemIndex(94));
            repo.中期样本.AFP_M结果.Element.SetAttributeValue("Value", "45");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '33000' on item '中期样本.tbhCG_M结果'.", repo.中期样本.tbhCG_M结果Info, new RecordItemIndex(95));
            repo.中期样本.tbhCG_M结果.Element.SetAttributeValue("Value", "33000");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1.3' on item '中期样本.uE3_M结果'.", repo.中期样本.uE3_M结果Info, new RecordItemIndex(96));
            repo.中期样本.uE3_M结果.Element.SetAttributeValue("Value", "1.3");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '李医生' on item '中期样本.送检医生'.", repo.中期样本.送检医生Info, new RecordItemIndex(97));
            repo.中期样本.送检医生.Element.SetAttributeValue("Value", "李医生");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '第一人民医院' on item '中期样本.单位来源'.", repo.中期样本.单位来源Info, new RecordItemIndex(98));
            repo.中期样本.单位来源.Element.SetAttributeValue("Value", "第一人民医院");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.保存按钮' at Center.", repo.中期样本.保存按钮Info, new RecordItemIndex(99));
            repo.中期样本.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(100));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking PerformClick() on item '方案.增加方案'.", repo.方案.增加方案Info, new RecordItemIndex(101));
            repo.方案.增加方案.PerformClick();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.早中期联合' at Center.", repo.方案.早中期联合Info, new RecordItemIndex(102));
            repo.方案.早中期联合.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.确定添加' at Center.", repo.方案.确定添加Info, new RecordItemIndex(103));
            repo.方案.确定添加.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '20' on item '方案.方案名称'.", repo.方案.方案名称Info, new RecordItemIndex(104));
            repo.方案.方案名称.Element.SetAttributeValue("TagValue", "20");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '1' on item '方案.早期样本'.", repo.方案.早期样本Info, new RecordItemIndex(105));
            repo.方案.早期样本.Element.SetAttributeValue("TagValue", "1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '2' on item '方案.中期样本'.", repo.方案.中期样本Info, new RecordItemIndex(106));
            repo.方案.中期样本.Element.SetAttributeValue("TagValue", "2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.保存方案' at Center.", repo.方案.保存方案Info, new RecordItemIndex(107));
            repo.方案.保存方案.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(108));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.生成风险' at Center.", repo.方案.生成风险Info, new RecordItemIndex(109));
            repo.方案.生成风险.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(110));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.提交审核' at Center.", repo.方案.提交审核Info, new RecordItemIndex(111));
            repo.方案.提交审核.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(112));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.通过审核' at Center.", repo.方案.通过审核Info, new RecordItemIndex(113));
            repo.方案.通过审核.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(114));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.筛查管理' at Center.", repo.页面头选择.筛查管理Info, new RecordItemIndex(115));
            repo.页面头选择.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.汇总信息' at Center.", repo.页面头选择.汇总信息Info, new RecordItemIndex(116));
            repo.页面头选择.汇总信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(117));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'blh0002' on item '汇总信息.搜索框'.", repo.汇总信息.搜索框Info, new RecordItemIndex(118));
            repo.汇总信息.搜索框.Element.SetAttributeValue("Value", "blh0002");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '汇总信息.搜索按钮' at Center.", repo.汇总信息.搜索按钮Info, new RecordItemIndex(119));
            repo.汇总信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
