// Copyright (c) Cingulara LLC 2019 and Tutela LLC 2019. All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007 license. See LICENSE file in the project root for full license information.

using System;
using MongoDB.Bson.Serialization.Attributes;

namespace openrmf_templates_api.Models
{
    [Serializable]
    public class Artifact
    {
        public Artifact () {
            CHECKLIST = new CHECKLIST();
        }

        public DateTime created { get; set; }
        public CHECKLIST CHECKLIST { get; set; }
        public string rawChecklist { get; set; }
        
        // if this is part of a system, list that system.
        // if empty this is just a standalone checklist
        public string systemGroupId { get; set; }
        public string systemTitle { get; set; }
        public string hostName { get; set;}
        public string stigType { get; set; }
        public string stigRelease { get; set; }
        public string version {get; set;}
        public string title { get {
            return hostName.Trim() + "-" + stigType.Trim() + "-V" + version + "-" + stigRelease.Trim();
        }}
        
        public string InternalId { get; set; }

        [BsonDateTimeOptions]
        // attribute to gain control on datetime serialization
        public DateTime? updatedOn { get; set; }

        public Guid createdBy { get; set; }
        public Guid? updatedBy { get; set; }
    }

}