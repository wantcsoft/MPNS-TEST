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

namespace MPNS_TEST.Models.Screening_Management.program
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The program017 recording.
    /// </summary>
    [TestModule("e79981f9-fbeb-4cad-84ec-36ffe5451000", ModuleType.Recording, 1)]
    public partial class program017 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.Infomation repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.Infomation repo = global::MPNS_TEST.Repositorys.Infomation.Instance;

        static program017 instance = new program017();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public program017()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static program017 Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(0));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.选择CRL孕周' at Center.", repo.中期样本.选择CRL孕周Info, new RecordItemIndex(2));
            repo.中期样本.选择CRL孕周.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '11' on item '中期样本.CRL孕周周'.", repo.中期样本.CRL孕周周Info, new RecordItemIndex(3));
            repo.中期样本.CRL孕周周.Element.SetAttributeValue("Value", "11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0' on item '中期样本.CRL孕周天'.", repo.中期样本.CRL孕周天Info, new RecordItemIndex(4));
            repo.中期样本.CRL孕周天.Element.SetAttributeValue("Value", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '中期样本.计算按钮' at Center.", repo.中期样本.计算按钮Info, new RecordItemIndex(5));
            repo.中期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 1000 units.", new RecordItemIndex(6));
            Mouse.ScrollWheel(1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.选择CRL孕周' at Center.", repo.早期样本.选择CRL孕周Info, new RecordItemIndex(7));
            repo.早期样本.选择CRL孕周.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '11' on item '早期样本.CRL孕周周'.", repo.早期样本.CRL孕周周Info, new RecordItemIndex(8));
            repo.早期样本.CRL孕周周.Element.SetAttributeValue("Value", "11");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '0' on item '早期样本.CRL孕周天'.", repo.早期样本.CRL孕周天Info, new RecordItemIndex(9));
            repo.早期样本.CRL孕周天.Element.SetAttributeValue("Value", "0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '早期样本.计算按钮' at Center.", repo.早期样本.计算按钮Info, new RecordItemIndex(10));
            repo.早期样本.计算按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存' at Center.", repo.方案.一键保存Info, new RecordItemIndex(12));
            repo.方案.一键保存.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '方案.一键保存后确认' at Center.", repo.方案.一键保存后确认Info, new RecordItemIndex(14));
            repo.方案.一键保存后确认.Click();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
