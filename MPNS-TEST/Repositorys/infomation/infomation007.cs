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
    /// The class representing the infomation007 element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("d178029e-d43b-408a-8c28-6a1eda7fd7de")]
    public partial class infomation007 : RepoGenBaseFolder
    {
        static infomation007 instance = new infomation007();
        infomation007Folders.筛查信息AppFolder _筛查信息;

        /// <summary>
        /// Gets the singleton class instance representing the infomation007 element repository.
        /// </summary>
        [RepositoryFolder("d178029e-d43b-408a-8c28-6a1eda7fd7de")]
        public static infomation007 Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public infomation007() 
            : base("infomation007", "/", null, 0, false, "d178029e-d43b-408a-8c28-6a1eda7fd7de", ".\\RepositoryImages\\infomation007d178029e.rximgres")
        {
            _筛查信息 = new infomation007Folders.筛查信息AppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("d178029e-d43b-408a-8c28-6a1eda7fd7de")]
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
        public virtual infomation007Folders.筛查信息AppFolder 筛查信息
        {
            get { return _筛查信息; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class infomation007Folders
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
            RepoItemInfo _身份证社保卡Info;
            RepoItemInfo _身份证号Info;
            RepoItemInfo _保存按钮Info;

            /// <summary>
            /// Creates a new 筛查信息  folder.
            /// </summary>
            public 筛查信息AppFolder(RepoGenBaseFolder parentFolder) :
                    base("筛查信息", "/dom[@domain='localhost:8016']", parentFolder, 30000, null, false, "a7efca04-702f-438e-be5f-6859c2578b63", "")
            {
                _筛查管理Info = new RepoItemInfo(this, "筛查管理", ".//ul[#'mainmenus']/?/?/a[@innertext='筛查管理']", 30000, null, "f6984859-bfde-4674-9e61-c1cb3a259c66");
                _筛查信息Info = new RepoItemInfo(this, "筛查信息", ".//ul[#'mainmenus']/?/?/div/ul/?/?/a[@innertext='筛查信息']", 30000, null, "e453ddd0-0b7e-4c8c-9961-38eb0cd79378");
                _孕妇姓名Info = new RepoItemInfo(this, "孕妇姓名", ".//input[#'FirstName']", 30000, null, "939bc867-274b-46b3-9c80-06e123668baf");
                _出生日期Info = new RepoItemInfo(this, "出生日期", ".//input[#'BirthDate']", 30000, null, "a8333816-9850-4ae0-b189-8570117a8500");
                _身份证社保卡Info = new RepoItemInfo(this, "身份证社保卡", ".//select[#'select_CardType']", 30000, null, "3d21fcac-347a-4717-9e67-4e16bf3b624a");
                _身份证号Info = new RepoItemInfo(this, "身份证号", ".//input[#'IDCard']", 30000, null, "c2a20939-5cbf-4255-a22f-4ccc102268a4");
                _保存按钮Info = new RepoItemInfo(this, "保存按钮", ".//input[#'butSavePregnant']", 30000, null, "14b19b0d-0aaf-464c-954c-cb16168186d7");
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
            [RepositoryItem("a8333816-9850-4ae0-b189-8570117a8500")]
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
            [RepositoryItemInfo("a8333816-9850-4ae0-b189-8570117a8500")]
            public virtual RepoItemInfo 出生日期Info
            {
                get
                {
                    return _出生日期Info;
                }
            }

            /// <summary>
            /// The 身份证社保卡 item.
            /// </summary>
            [RepositoryItem("3d21fcac-347a-4717-9e67-4e16bf3b624a")]
            public virtual Ranorex.SelectTag 身份证社保卡
            {
                get
                {
                    return _身份证社保卡Info.CreateAdapter<Ranorex.SelectTag>(true);
                }
            }

            /// <summary>
            /// The 身份证社保卡 item info.
            /// </summary>
            [RepositoryItemInfo("3d21fcac-347a-4717-9e67-4e16bf3b624a")]
            public virtual RepoItemInfo 身份证社保卡Info
            {
                get
                {
                    return _身份证社保卡Info;
                }
            }

            /// <summary>
            /// The 身份证号 item.
            /// </summary>
            [RepositoryItem("c2a20939-5cbf-4255-a22f-4ccc102268a4")]
            public virtual Ranorex.InputTag 身份证号
            {
                get
                {
                    return _身份证号Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The 身份证号 item info.
            /// </summary>
            [RepositoryItemInfo("c2a20939-5cbf-4255-a22f-4ccc102268a4")]
            public virtual RepoItemInfo 身份证号Info
            {
                get
                {
                    return _身份证号Info;
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
        }

    }
#pragma warning restore 0436
}
