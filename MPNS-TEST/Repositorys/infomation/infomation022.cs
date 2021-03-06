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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MPNS_TEST.Repositorys.infomation
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the infomation022 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("2584a7b1-43e6-4e10-ba23-7ef63bc47ae8")]
    public partial class infomation022 : RepoGenBaseFolder
    {
        static infomation022 instance = new infomation022();
        infomation022Folders.筛查信息AppFolder _筛查信息;
        infomation022Folders.高级查询AppFolder _高级查询;

        /// <summary>
        /// Gets the singleton class instance representing the infomation022 element repository.
        /// </summary>
        [RepositoryFolder("2584a7b1-43e6-4e10-ba23-7ef63bc47ae8")]
        public static infomation022 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public infomation022() 
            : base("infomation022", "/", null, 0, false, "2584a7b1-43e6-4e10-ba23-7ef63bc47ae8", ".\\RepositoryImages\\infomation0222584a7b1.rximgres")
        {
            _筛查信息 = new infomation022Folders.筛查信息AppFolder(this);
            _高级查询 = new infomation022Folders.高级查询AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("2584a7b1-43e6-4e10-ba23-7ef63bc47ae8")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The 筛查信息 folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public virtual infomation022Folders.筛查信息AppFolder 筛查信息
        {
            get { return _筛查信息; }
        }

        /// <summary>
        /// The 高级查询 folder.
        /// </summary>
        [RepositoryFolder("79d1f82f-9f11-42bb-9ca5-68ddcc310296")]
        public virtual infomation022Folders.高级查询AppFolder 高级查询
        {
            get { return _高级查询; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class infomation022Folders
    {
        /// <summary>
        /// The 筛查信息AppFolder folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public partial class 筛查信息AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _筛查管理Info;
            RepoItemInfo _筛查信息Info;

            /// <summary>
            /// Creates a new 筛查信息  folder.
            /// </summary>
            public 筛查信息AppFolder(RepoGenBaseFolder parentFolder) :
                    base("筛查信息", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "a7efca04-702f-438e-be5f-6859c2578b63", "")
            {
                _筛查管理Info = new RepoItemInfo(this, "筛查管理", ".//ul[#'mainmenus']/?/?/a[@innertext='筛查管理']", 30000, null, "f6984859-bfde-4674-9e61-c1cb3a259c66");
                _筛查信息Info = new RepoItemInfo(this, "筛查信息", ".//ul[#'mainmenus']/?/?/div/ul/?/?/a[@innertext='筛查信息']", 30000, null, "e453ddd0-0b7e-4c8c-9961-38eb0cd79378");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a7efca04-702f-438e-be5f-6859c2578b63")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a7efca04-702f-438e-be5f-6859c2578b63")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The 筛查管理 item.
            /// </summary>
            [RepositoryItem("f6984859-bfde-4674-9e61-c1cb3a259c66")]
            public virtual Ranorex.ATag 筛查管理
            {
                get
                {
                    return _筛查管理Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 筛查管理 item info.
            /// </summary>
            [RepositoryItemInfo("f6984859-bfde-4674-9e61-c1cb3a259c66")]
            public virtual RepoItemInfo 筛查管理Info
            {
                get
                {
                    return _筛查管理Info;
                }
            }

            /// <summary>
            /// The 筛查信息 item.
            /// </summary>
            [RepositoryItem("e453ddd0-0b7e-4c8c-9961-38eb0cd79378")]
            public virtual Ranorex.ATag 筛查信息
            {
                get
                {
                    return _筛查信息Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 筛查信息 item info.
            /// </summary>
            [RepositoryItemInfo("e453ddd0-0b7e-4c8c-9961-38eb0cd79378")]
            public virtual RepoItemInfo 筛查信息Info
            {
                get
                {
                    return _筛查信息Info;
                }
            }
        }

        /// <summary>
        /// The 高级查询AppFolder folder.
        /// </summary>
        [RepositoryFolder("79d1f82f-9f11-42bb-9ca5-68ddcc310296")]
        public partial class 高级查询AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _高级查询Info;
            RepoItemInfo _筛查号Info;
            RepoItemInfo _病历号Info;
            RepoItemInfo _孕妇姓名Info;
            RepoItemInfo _样本号1Info;
            RepoItemInfo _样本号2Info;
            RepoItemInfo _测试开始日期Info;
            RepoItemInfo _测试结束日期Info;
            RepoItemInfo _搜索按钮Info;
            RepoItemInfo _左侧Info;

            /// <summary>
            /// Creates a new 高级查询  folder.
            /// </summary>
            public 高级查询AppFolder(RepoGenBaseFolder parentFolder) :
                    base("高级查询", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "79d1f82f-9f11-42bb-9ca5-68ddcc310296", "")
            {
                _高级查询Info = new RepoItemInfo(this, "高级查询", "body/div[2]/div[1]/?/?/a[@innertext='高级查询']", 30000, null, "f4e20073-5d08-4d45-a850-2d1608cccaa5");
                _筛查号Info = new RepoItemInfo(this, "筛查号", ".//input[#'SCheckNo']", 30000, null, "c5061193-46fa-4323-b24e-01246a5747e6");
                _病历号Info = new RepoItemInfo(this, "病历号", ".//input[#'txtPatientID']", 30000, null, "2e710be8-cbb2-4d5c-b0d1-716a6db07ecb");
                _孕妇姓名Info = new RepoItemInfo(this, "孕妇姓名", ".//input[#'RealName']", 30000, null, "100d483c-d7cf-4931-b557-a10c51d546d4");
                _样本号1Info = new RepoItemInfo(this, "样本号1", ".//input[#'txtStartSampleID']", 30000, null, "5712dbfa-81fb-4903-b7f7-bea598f4e2d0");
                _样本号2Info = new RepoItemInfo(this, "样本号2", ".//input[#'txtEndSampleID']", 30000, null, "7ff3231b-4851-4caa-bd3f-cb9ada362965");
                _测试开始日期Info = new RepoItemInfo(this, "测试开始日期", ".//input[#'StartDate']", 30000, null, "348cc03a-1804-4589-b6a2-5cca65692507");
                _测试结束日期Info = new RepoItemInfo(this, "测试结束日期", ".//input[#'EndDate']", 30000, null, "49d09167-ae52-48f6-8c80-9e9820709c21");
                _搜索按钮Info = new RepoItemInfo(this, "搜索按钮", ".//div[#'searchSeniorBox']/table//input[@type='button']", 30000, null, "d8c869cd-53c7-44e9-a2ed-29adea5ee4fc");
                _左侧Info = new RepoItemInfo(this, "左侧", "body/div[2]/div[2]/table[2]/?/?/tr/td[1]/div[1]", 30000, null, "3322ead4-cf32-43ef-8d8f-1e5a7659ab62");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("79d1f82f-9f11-42bb-9ca5-68ddcc310296")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("79d1f82f-9f11-42bb-9ca5-68ddcc310296")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The 高级查询 item.
            /// </summary>
            [RepositoryItem("f4e20073-5d08-4d45-a850-2d1608cccaa5")]
            public virtual Ranorex.ATag 高级查询
            {
                get
                {
                    return _高级查询Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 高级查询 item info.
            /// </summary>
            [RepositoryItemInfo("f4e20073-5d08-4d45-a850-2d1608cccaa5")]
            public virtual RepoItemInfo 高级查询Info
            {
                get
                {
                    return _高级查询Info;
                }
            }

            /// <summary>
            /// The 筛查号 item.
            /// </summary>
            [RepositoryItem("c5061193-46fa-4323-b24e-01246a5747e6")]
            public virtual Ranorex.InputTag 筛查号
            {
                get
                {
                    return _筛查号Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 筛查号 item info.
            /// </summary>
            [RepositoryItemInfo("c5061193-46fa-4323-b24e-01246a5747e6")]
            public virtual RepoItemInfo 筛查号Info
            {
                get
                {
                    return _筛查号Info;
                }
            }

            /// <summary>
            /// The 病历号 item.
            /// </summary>
            [RepositoryItem("2e710be8-cbb2-4d5c-b0d1-716a6db07ecb")]
            public virtual Ranorex.InputTag 病历号
            {
                get
                {
                    return _病历号Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 病历号 item info.
            /// </summary>
            [RepositoryItemInfo("2e710be8-cbb2-4d5c-b0d1-716a6db07ecb")]
            public virtual RepoItemInfo 病历号Info
            {
                get
                {
                    return _病历号Info;
                }
            }

            /// <summary>
            /// The 孕妇姓名 item.
            /// </summary>
            [RepositoryItem("100d483c-d7cf-4931-b557-a10c51d546d4")]
            public virtual Ranorex.InputTag 孕妇姓名
            {
                get
                {
                    return _孕妇姓名Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 孕妇姓名 item info.
            /// </summary>
            [RepositoryItemInfo("100d483c-d7cf-4931-b557-a10c51d546d4")]
            public virtual RepoItemInfo 孕妇姓名Info
            {
                get
                {
                    return _孕妇姓名Info;
                }
            }

            /// <summary>
            /// The 样本号1 item.
            /// </summary>
            [RepositoryItem("5712dbfa-81fb-4903-b7f7-bea598f4e2d0")]
            public virtual Ranorex.InputTag 样本号1
            {
                get
                {
                    return _样本号1Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 样本号1 item info.
            /// </summary>
            [RepositoryItemInfo("5712dbfa-81fb-4903-b7f7-bea598f4e2d0")]
            public virtual RepoItemInfo 样本号1Info
            {
                get
                {
                    return _样本号1Info;
                }
            }

            /// <summary>
            /// The 样本号2 item.
            /// </summary>
            [RepositoryItem("7ff3231b-4851-4caa-bd3f-cb9ada362965")]
            public virtual Ranorex.InputTag 样本号2
            {
                get
                {
                    return _样本号2Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 样本号2 item info.
            /// </summary>
            [RepositoryItemInfo("7ff3231b-4851-4caa-bd3f-cb9ada362965")]
            public virtual RepoItemInfo 样本号2Info
            {
                get
                {
                    return _样本号2Info;
                }
            }

            /// <summary>
            /// The 测试开始日期 item.
            /// </summary>
            [RepositoryItem("348cc03a-1804-4589-b6a2-5cca65692507")]
            public virtual Ranorex.InputTag 测试开始日期
            {
                get
                {
                    return _测试开始日期Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 测试开始日期 item info.
            /// </summary>
            [RepositoryItemInfo("348cc03a-1804-4589-b6a2-5cca65692507")]
            public virtual RepoItemInfo 测试开始日期Info
            {
                get
                {
                    return _测试开始日期Info;
                }
            }

            /// <summary>
            /// The 测试结束日期 item.
            /// </summary>
            [RepositoryItem("49d09167-ae52-48f6-8c80-9e9820709c21")]
            public virtual Ranorex.InputTag 测试结束日期
            {
                get
                {
                    return _测试结束日期Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 测试结束日期 item info.
            /// </summary>
            [RepositoryItemInfo("49d09167-ae52-48f6-8c80-9e9820709c21")]
            public virtual RepoItemInfo 测试结束日期Info
            {
                get
                {
                    return _测试结束日期Info;
                }
            }

            /// <summary>
            /// The 搜索按钮 item.
            /// </summary>
            [RepositoryItem("d8c869cd-53c7-44e9-a2ed-29adea5ee4fc")]
            public virtual Ranorex.InputTag 搜索按钮
            {
                get
                {
                    return _搜索按钮Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 搜索按钮 item info.
            /// </summary>
            [RepositoryItemInfo("d8c869cd-53c7-44e9-a2ed-29adea5ee4fc")]
            public virtual RepoItemInfo 搜索按钮Info
            {
                get
                {
                    return _搜索按钮Info;
                }
            }

            /// <summary>
            /// The 左侧 item.
            /// </summary>
            [RepositoryItem("3322ead4-cf32-43ef-8d8f-1e5a7659ab62")]
            public virtual Ranorex.DivTag 左侧
            {
                get
                {
                    return _左侧Info.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The 左侧 item info.
            /// </summary>
            [RepositoryItemInfo("3322ead4-cf32-43ef-8d8f-1e5a7659ab62")]
            public virtual RepoItemInfo 左侧Info
            {
                get
                {
                    return _左侧Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
