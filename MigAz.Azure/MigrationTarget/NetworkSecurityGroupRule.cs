// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using MigAz.Azure.Core;
using MigAz.Azure.Core.ArmTemplate;
using MigAz.Azure.Core.Interface;
using System;

namespace MigAz.Azure.MigrationTarget
{
    public class NetworkSecurityGroupRule : Core.MigrationTarget
    {
        private bool _IsSystemRule = false;

        #region Constructors

        public NetworkSecurityGroupRule(Asm.NetworkSecurityGroupRule asmRule, TargetSettings targetSettings) : base(String.Empty, String.Empty)
        {
            this.SetTargetName(asmRule.Name, targetSettings);
            this.Access = asmRule.Action;
            this.DestinationAddressPrefix = asmRule.DestinationAddressPrefix;
            this.DestinationPortRange = asmRule.DestinationPortRange;
            this.Direction = asmRule.Type;
            this.IsSystemRule = asmRule.IsSystemRule;
            this.Priority = asmRule.Priority;
            this.Protocol = asmRule.Protocol;
            this.SourceAddressPrefix = asmRule.SourceAddressPrefix;
            this.SourcePortRange = asmRule.SourcePortRange;
        }

        public NetworkSecurityGroupRule(Arm.NetworkSecurityGroupRule armRule, TargetSettings targetSettings) : base(String.Empty, String.Empty)
        {
            this.SetTargetName(armRule.Name, targetSettings);
            this.Access = armRule.Access;
            this.DestinationAddressPrefix = armRule.DestinationAddressPrefix;
            this.DestinationPortRange = armRule.DestinationPortRange;
            this.Direction = armRule.Direction;
            this.Priority = armRule.Priority;
            this.Protocol = armRule.Protocol;
            this.SourcePortRange = armRule.SourcePortRange;
            this.SourceAddressPrefix = armRule.SourceAddressPrefix;
        }

        #endregion

        public string Direction
        {
            get; set;
        }

        public long Priority
        {
            get; set;
        }

        public string Access
        {
            get; set;
        }

        public string SourceAddressPrefix
        {
            get; set;
        }

        public string DestinationAddressPrefix
        {
            get; set;
        }

        public string SourcePortRange
        {
            get; set;
        }

        public string DestinationPortRange
        {
            get; set;
        }

        public string Protocol
        {
            get; set;
        }

        public bool IsSystemRule
        {
            get { return _IsSystemRule; }
            set { _IsSystemRule = value; }
        }

        public String SourceName
        {
            get
            {
                return String.Empty;
            }
        }

        public override string ImageKey { get { return "NetworkSecurityGroupRule"; } }

        public override string FriendlyObjectName { get { return "Network Security Group Rule"; } }


        public override void SetTargetName(string targetName, TargetSettings targetSettings)
        {
            this.TargetName = targetName.Trim().Replace(" ", String.Empty);
            this.TargetNameResult = this.TargetName;
        }
    }
}

