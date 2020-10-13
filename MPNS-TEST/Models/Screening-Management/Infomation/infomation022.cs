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
    ///The infomation022 recording.
    /// </summary>
    [TestModule("11f9b456-6f68-4283-a5a4-58717aec7a43", ModuleType.Recording, 1)]
    public partial class infomation022 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.infomation.infomation022 repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.infomation.infomation022 repo = global::MPNS_TEST.Repositorys.infomation.infomation022.Instance;

        static infomation022 instance = new infomation022();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public infomation022()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static infomation022 Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '高级查询.高级查询' at Center.", repo.高级查询.高级查询Info, new RecordItemIndex(3));
            repo.高级查询.高级查询.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'MOZ0001' on item '高级查询.筛查号'.", repo.高级查询.筛查号Info, new RecordItemIndex(4));
            repo.高级查询.筛查号.Element.SetAttributeValue("Value", "MOZ0001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'BLH0001' on item '高级查询.病历号'.", repo.高级查询.病历号Info, new RecordItemIndex(5));
            repo.高级查询.病历号.Element.SetAttributeValue("Value", "BLH0001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '周孕妇' on item '高级查询.孕妇姓名'.", repo.高级查询.孕妇姓名Info, new RecordItemIndex(6));
            repo.高级查询.孕妇姓名.Element.SetAttributeValue("Value", "周孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'YBH0001' on item '高级查询.样本号1'.", repo.高级查询.样本号1Info, new RecordItemIndex(7));
            repo.高级查询.样本号1.Element.SetAttributeValue("Value", "YBH0001");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'YBH0010' on item '高级查询.样本号2'.", repo.高级查询.样本号2Info, new RecordItemIndex(8));
            repo.高级查询.样本号2.Element.SetAttributeValue("Value", "YBH0010");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-9-23' on item '高级查询.测试开始日期'.", repo.高级查询.测试开始日期Info, new RecordItemIndex(9));
            repo.高级查询.测试开始日期.Element.SetAttributeValue("Value", "2020-9-23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '2020-9-23' on item '高级查询.测试结束日期'.", repo.高级查询.测试结束日期Info, new RecordItemIndex(10));
            repo.高级查询.测试结束日期.Element.SetAttributeValue("Value", "2020-9-23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '高级查询.搜索按钮' at Center.", repo.高级查询.搜索按钮Info, new RecordItemIndex(11));
            repo.高级查询.搜索按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.高级查询.左侧, false, new RecordItemIndex(13));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
