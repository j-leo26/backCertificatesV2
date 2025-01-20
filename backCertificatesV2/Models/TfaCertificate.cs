using System;
using System.Collections.Generic;

namespace backCertificatesV2.Models;

public partial class TfaCertificate
{
    public int CertificatesId { get; set; }

    public string? CertificateMessage { get; set; }

    public int? CertificateReceptor { get; set; }

    public int? CertificateLead { get; set; }

    public string? CertificatePrincipio { get; set; }

    public string? CertificateMotivo { get; set; }

    public virtual TfaUser? CertificateLeadNavigation { get; set; }

    public virtual TfaUser? CertificateReceptorNavigation { get; set; }

    public virtual ICollection<TfaHistory> TfaHistories { get; set; } = new List<TfaHistory>();
}
