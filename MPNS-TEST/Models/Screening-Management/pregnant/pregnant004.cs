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
    ///The pregnant004 recording.
    /// </summary>
    [TestModule("22f43df9-471c-4385-a32a-e5463add8f64", ModuleType.Recording, 1)]
    public partial class pregnant004 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static pregnant004 instance = new pregnant004();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public pregnant004()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static pregnant004 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '页面头选择.孕妇信息' at Center.", repo.页面头选择.孕妇信息Info, new RecordItemIndex(1));
            repo.页面头选择.孕妇信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(2));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.全选框' at Center.", repo.孕妇信息.全选框Info, new RecordItemIndex(3));
            repo.孕妇信息.全选框.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.导出' at Center.", repo.孕妇信息.导出Info, new RecordItemIndex(4));
            repo.孕妇信息.导出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(5));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.确定' at Center.", repo.孕妇信息.确定Info, new RecordItemIndex(6));
            repo.孕妇信息.确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(7));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息导出.保存文件' at Center.", repo.孕妇信息导出.保存文件Info, new RecordItemIndex(8));
            repo.孕妇信息导出.保存文件.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息导出.确定' at Center.", repo.孕妇信息导出.确定Info, new RecordItemIndex(9));
            repo.孕妇信息导出.确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '赵孕妇' on item '孕妇信息.搜索框'.", repo.孕妇信息.搜索框Info, new RecordItemIndex(10));
            repo.孕妇信息.搜索框.Element.SetAttributeValue("Value", "赵孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.搜索按钮' at Center.", repo.孕妇信息.搜索按钮Info, new RecordItemIndex(11));
            repo.孕妇信息.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.全选框' at Center.", repo.孕妇信息.全选框Info, new RecordItemIndex(12));
            repo.孕妇信息.全选框.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.导出' at Center.", repo.孕妇信息.导出Info, new RecordItemIndex(13));
            repo.孕妇信息.导出.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(14));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息.确定' at Center.", repo.孕妇信息.确定Info, new RecordItemIndex(15));
            repo.孕妇信息.确定.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(16));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息导出.保存文件' at Center.", repo.孕妇信息导出.保存文件Info, new RecordItemIndex(17));
            repo.孕妇信息导出.保存文件.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '孕妇信息导出.确定' at Center.", repo.孕妇信息导出.确定Info, new RecordItemIndex(18));
            repo.孕妇信息导出.确定.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}