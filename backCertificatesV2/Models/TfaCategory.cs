﻿using System;
using System.Collections.Generic;

namespace backCertificatesV2.Models;

public partial class TfaCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; } = null!;

    public string? CategoryDescription { get; set; }

    public int? CategoryPoints { get; set; }

    public DateOnly? CategoryDeadLine { get; set; }

    public int? ReducePoints { get; set; }

    public virtual ICollection<TfaHistory> TfaHistories { get; set; } = new List<TfaHistory>();

    public virtual ICollection<TfaTask> TfaTasks { get; set; } = new List<TfaTask>();

    public virtual ICollection<TfaTeam> TfaTeams { get; set; } = new List<TfaTeam>();

    public virtual ICollection<TfaTeam> Teams { get; set; } = new List<TfaTeam>();
}
