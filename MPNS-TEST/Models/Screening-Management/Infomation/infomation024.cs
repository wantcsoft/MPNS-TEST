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
    ///The infomation024 recording.
    /// </summary>
    [TestModule("4c1411af-b218-46a6-b43e-81fd8b94b4a7", ModuleType.Recording, 1)]
    public partial class infomation024 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::MPNS_TEST.Repositorys.infomation.infomation024 repository.
        /// </summary>
        public static global::MPNS_TEST.Repositorys.infomation.infomation024 repo = global::MPNS_TEST.Repositorys.infomation.infomation024.Instance;

        static infomation024 instance = new infomation024();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public infomation024()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static infomation024 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '维护.维护管理' at Center.", repo.维护.维护管理Info, new RecordItemIndex(0));
            repo.维护.维护管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '维护.参数信息' at Center.", repo.维护.参数信息Info, new RecordItemIndex(1));
            repo.维护.参数信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(2));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '维护.数据来源' at Center.", repo.维护.数据来源Info, new RecordItemIndex(3));
            repo.维护.数据来源.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item '维护.病历号回车'.", repo.维护.病历号回车Info, new RecordItemIndex(5));
            repo.维护.病历号回车.Element.SetAttributeValue("Checked", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item '维护.外部数据接口'.", repo.维护.外部数据接口Info, new RecordItemIndex(6));
            repo.维护.外部数据接口.Element.SetAttributeValue("Checked", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item '维护.读取标记物'.", repo.维护.读取标记物Info, new RecordItemIndex(7));
            repo.维护.读取标记物.Element.SetAttributeValue("Checked", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Checked to 'true' on item '维护.替换SQL语句中的起始日期'.", repo.维护.替换SQL语句中的起始日期Info, new RecordItemIndex(8));
            repo.维护.替换SQL语句中的起始日期.Element.SetAttributeValue("Checked", "true");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(9));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(10));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -1000 units.", new RecordItemIndex(11));
            Mouse.ScrollWheel(-1000);
            Delay.Milliseconds(300);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '维护.保存按钮' at Center.", repo.维护.保存按钮Info, new RecordItemIndex(12));
            repo.维护.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(13));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(14));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'DESKTOP-SM51UF2\\MOZZIE' on item '维护.服务器名'.", repo.维护.服务器名Info, new RecordItemIndex(15));
            repo.维护.服务器名.Element.SetAttributeValue("Value", "DESKTOP-SM51UF2\\MOZZIE");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'MOZZIE' on item '维护.数据库名'.", repo.维护.数据库名Info, new RecordItemIndex(16));
            repo.维护.数据库名.Element.SetAttributeValue("Value", "MOZZIE");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to 'sa' on item '维护.账户'.", repo.维护.账户Info, new RecordItemIndex(17));
            repo.维护.账户.Element.SetAttributeValue("Value", "sa");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '123456' on item '维护.密码'.", repo.维护.密码Info, new RecordItemIndex(18));
            repo.维护.密码.Element.SetAttributeValue("Value", "123456");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to 'select * FROM T_ForPatientId_BocadeId_Enter where PatientID= #%s# and testdate >= #startDate# and testdate <= #endDate#' on item '维护.T_SQL语句'.", repo.维护.T_SQL语句Info, new RecordItemIndex(19));
            repo.维护.T_SQL语句.Element.SetAttributeValue("TagValue", "select * FROM T_ForPatientId_BocadeId_Enter where PatientID= #%s# and testdate >= #startDate# and testdate <= #endDate#");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.筛查管理' at Center.", repo.筛查信息.筛查管理Info, new RecordItemIndex(20));
            repo.筛查信息.筛查管理.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.筛查信息' at Center.", repo.筛查信息.筛查信息Info, new RecordItemIndex(21));
            repo.筛查信息.筛查信息.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '牛孕妇' on item '筛查信息.孕妇姓名'.", repo.筛查信息.孕妇姓名Info, new RecordItemIndex(22));
            repo.筛查信息.孕妇姓名.Element.SetAttributeValue("Value", "牛孕妇");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Value to '1999-01-01' on item '筛查信息.出生日期'.", repo.筛查信息.出生日期Info, new RecordItemIndex(23));
            repo.筛查信息.出生日期.Element.SetAttributeValue("Value", "1999-01-01");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item '筛查信息.保存按钮' at Center.", repo.筛查信息.保存按钮Info, new RecordItemIndex(24));
            repo.筛查信息.保存按钮.Click();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '3' on item '中期样本.方案名称'.", repo.中期样本.方案名称Info, new RecordItemIndex(25));
            repo.中期样本.方案名称.Element.SetAttributeValue("TagValue", "3");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
