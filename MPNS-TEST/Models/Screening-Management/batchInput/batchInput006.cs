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
    ///The batchInput006 recording.
    /// </summary>
    [TestModule("06f1d6d0-81d8-45c4-927e-d910372b3234", ModuleType.Recording, 1)]
    public partial class batchInput006 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static batchInput006 instance = new batchInput006();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public batchInput006()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static batchInput006 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.批量录入' at Center.", repo.页面头选择.批量录入Info, new RecordItemIndex(1));
            repo.页面头选择.批量录入.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.导入' at Center.", repo.筛查管理批量录入.导入Info, new RecordItemIndex(3));
            repo.筛查管理批量录入.导入.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(4));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.浏览' at Center.", repo.筛查管理批量录入.浏览Info, new RecordItemIndex(5));
            repo.筛查管理批量录入.浏览.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to '测试用例V1.19.xls' on item '文件上传.文件名'.", repo.文件上传.文件名Info, new RecordItemIndex(6));
            repo.文件上传.文件名.Element.SetAttributeValue("Text", "测试用例V1.19.xls");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '文件上传.打开' at Center.", repo.文件上传.打开Info, new RecordItemIndex(7));
            repo.文件上传.打开.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.确定导入' at Center.", repo.筛查管理批量录入.确定导入Info, new RecordItemIndex(8));
            repo.筛查管理批量录入.确定导入.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查管理批量录入.导入成功确定' at Center.", repo.筛查管理批量录入.导入成功确定Info, new RecordItemIndex(9));
            repo.筛查管理批量录入.导入成功确定.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
