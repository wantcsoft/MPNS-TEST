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
    ///The infomation010 recording.
    /// </summary>
    [TestModule("55f3a5d4-5f2c-42ae-9ff5-e6a93885b6cd", ModuleType.Recording, 1)]
    public partial class infomation010 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.infomation.infomation010 repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.infomation.infomation010 repo = global::MPNS_TEST.Repositorys.infomation.infomation010.Instance;

        static infomation010 instance = new infomation010();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public infomation010()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static infomation010 Instance
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
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(3));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1990-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(4));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1990-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1234567890123456789012345678901234' on item '筛查信息.电子邮箱'.", repo.筛查信息.电子邮箱Info, new RecordItemIndex(5));
            repo.筛查信息.电子邮箱.Element.SetAttributeValue("Value", "1234567890123456789012345678901234");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(6));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.社保卡保存失败确定' at Center.", repo.筛查信息.社保卡保存失败确定Info, new RecordItemIndex(7));
            repo.筛查信息.社保卡保存失败确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查信息.电子邮箱'.", repo.筛查信息.电子邮箱Info, new RecordItemIndex(8));
            repo.筛查信息.电子邮箱.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '12345678901234567890123456789012' with focus on '筛查信息.电子邮箱'.", repo.筛查信息.电子邮箱Info, new RecordItemIndex(9));
            repo.筛查信息.电子邮箱.PressKeys("12345678901234567890123456789012");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(10));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '(null)' on item '筛查信息.电子邮箱'.", repo.筛查信息.电子邮箱Info, new RecordItemIndex(11));
            repo.筛查信息.电子邮箱.Element.SetAttributeValue("Value", null);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(12));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
