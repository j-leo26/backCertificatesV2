﻿using System;
using System.Collections.Generic;

namespace backCertificatesV2.Models;

public partial class TfaUsersTask
{
    public int UserTaskId { get; set; }

    public int UserId { get; set; }

    public bool? StatusTask { get; set; }

    public string? EvidencePath { get; set; }

    public DateTime? EvidenceUploadDate { get; set; }

    public virtual TfaUser User { get; set; } = null!;

    public virtual TfaTask UserTask { get; set; } = null!;
}
