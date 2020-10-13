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
    /// The class representing the Infomation012 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("dfff80d2-044b-4762-886e-20fddea5168e")]
    public partial class Infomation012 : RepoGenBaseFolder
    {
        static Infomation012 instance = new Infomation012();
        Infomation012Folders.筛查信息AppFolder _筛查信息;

        /// <summary>
        /// Gets the singleton class instance representing the Infomation012 element repository.
        /// </summary>
        [RepositoryFolder("dfff80d2-044b-4762-886e-20fddea5168e")]
        public static Infomation012 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public Infomation012() 
            : base("Infomation012", "/", null, 0, false, "dfff80d2-044b-4762-886e-20fddea5168e", ".\\RepositoryImages\\infomation012dfff80d2.rximgres")
        {
            _筛查信息 = new Infomation012Folders.筛查信息AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("dfff80d2-044b-4762-886e-20fddea5168e")]
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
        public virtual Infomation012Folders.筛查信息AppFolder 筛查信息
        {
            get { return _筛查信息; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class Infomation012Folders
    {
        /// <summary>
        /// The 筛查信息AppFolder folder.
        /// </summary>
        [RepositoryFolder("a7efca04-702f-438e-be5f-6859c2578b63")]
        public partial class 筛查信息AppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _筛查管理Info;
            RepoItemInfo _筛查信息Info;
            RepoItemInfo _孕妇姓名Info;
            RepoItemInfo _出生日期Info;
            RepoItemInfo _孕次Info;
            RepoItemInfo _保存按钮Info;
            RepoItemInfo _保存失败确定Info;
            RepoItemInfo _社保卡保存失败确定Info;

            /// <summary>
            /// Creates a new 筛查信息  folder.
            /// </summary>
            public 筛查信息AppFolder(RepoGenBaseFolder parentFolder) :
                    base("筛查信息", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "a7efca04-702f-438e-be5f-6859c2578b63", "")
            {
                _筛查管理Info = new RepoItemInfo(this, "筛查管理", ".//ul[#'mainmenus']/?/?/a[@innertext='筛查管理']", 30000, null, "f6984859-bfde-4674-9e61-c1cb3a259c66");
                _筛查信息Info = new RepoItemInfo(this, "筛查信息", ".//ul[#'mainmenus']/?/?/div/ul/?/?/a[@innertext='筛查信息']", 30000, null, "e453ddd0-0b7e-4c8c-9961-38eb0cd79378");
                _孕妇姓名Info = new RepoItemInfo(this, "孕妇姓名", ".//input[#'FirstName']", 30000, null, "939bc867-274b-46b3-9c80-06e123668baf");
                _出生日期Info = new RepoItemInfo(this, "出生日期", ".//input[#'BirthDate']", 30000, null, "12f70fcf-6fa9-4e67-a4f2-67d24ddf526f");
                _孕次Info = new RepoItemInfo(this, "孕次", ".//input[#'GravidNumber']", 30000, null, "a2da240a-67a8-4cec-9f13-0a62d9b30ab8");
                _保存按钮Info = new RepoItemInfo(this, "保存按钮", ".//input[#'butSavePregnant']", 30000, null, "14b19b0d-0aaf-464c-954c-cb16168186d7");
                _保存失败确定Info = new RepoItemInfo(this, "保存失败确定", ".//div[#'xubox_layer3']//a[@innertext='确定']", 30000, null, "667c4daa-cae9-4f35-b552-517de4926614");
                _社保卡保存失败确定Info = new RepoItemInfo(this, "社保卡保存失败确定", ".//div[#'xubox_layer1']//a[@innertext='确定']", 30000, null, "c940f0e2-dd00-4a68-8dcc-92ed29b2817b");
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

            /// <summary>
            /// The 孕妇姓名 item.
            /// </summary>
            [RepositoryItem("939bc867-274b-46b3-9c80-06e123668baf")]
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
            [RepositoryItemInfo("939bc867-274b-46b3-9c80-06e123668baf")]
            public virtual RepoItemInfo 孕妇姓名Info
            {
                get
                {
                    return _孕妇姓名Info;
                }
            }

            /// <summary>
            /// The 出生日期 item.
            /// </summary>
            [RepositoryItem("12f70fcf-6fa9-4e67-a4f2-67d24ddf526f")]
            public virtual Ranorex.InputTag 出生日期
            {
                get
                {
                    return _出生日期Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 出生日期 item info.
            /// </summary>
            [RepositoryItemInfo("12f70fcf-6fa9-4e67-a4f2-67d24ddf526f")]
            public virtual RepoItemInfo 出生日期Info
            {
                get
                {
                    return _出生日期Info;
                }
            }

            /// <summary>
            /// The 孕次 item.
            /// </summary>
            [RepositoryItem("a2da240a-67a8-4cec-9f13-0a62d9b30ab8")]
            public virtual Ranorex.InputTag 孕次
            {
                get
                {
                    return _孕次Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 孕次 item info.
            /// </summary>
            [RepositoryItemInfo("a2da240a-67a8-4cec-9f13-0a62d9b30ab8")]
            public virtual RepoItemInfo 孕次Info
            {
                get
                {
                    return _孕次Info;
                }
            }

            /// <summary>
            /// The 保存按钮 item.
            /// </summary>
            [RepositoryItem("14b19b0d-0aaf-464c-954c-cb16168186d7")]
            public virtual Ranorex.InputTag 保存按钮
            {
                get
                {
                    return _保存按钮Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 保存按钮 item info.
            /// </summary>
            [RepositoryItemInfo("14b19b0d-0aaf-464c-954c-cb16168186d7")]
            public virtual RepoItemInfo 保存按钮Info
            {
                get
                {
                    return _保存按钮Info;
                }
            }

            /// <summary>
            /// The 保存失败确定 item.
            /// </summary>
            [RepositoryItem("667c4daa-cae9-4f35-b552-517de4926614")]
            public virtual Ranorex.ATag 保存失败确定
            {
                get
                {
                    return _保存失败确定Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 保存失败确定 item info.
            /// </summary>
            [RepositoryItemInfo("667c4daa-cae9-4f35-b552-517de4926614")]
            public virtual RepoItemInfo 保存失败确定Info
            {
                get
                {
                    return _保存失败确定Info;
                }
            }

            /// <summary>
            /// The 社保卡保存失败确定 item.
            /// </summary>
            [RepositoryItem("c940f0e2-dd00-4a68-8dcc-92ed29b2817b")]
            public virtual Ranorex.ATag 社保卡保存失败确定
            {
                get
                {
                    return _社保卡保存失败确定Info.CreateAdapter<Ranorex.ATag>(true);
                }
            }

            /// <summary>
            /// The 社保卡保存失败确定 item info.
            /// </summary>
            [RepositoryItemInfo("c940f0e2-dd00-4a68-8dcc-92ed29b2817b")]
            public virtual RepoItemInfo 社保卡保存失败确定Info
            {
                get
                {
                    return _社保卡保存失败确定Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
