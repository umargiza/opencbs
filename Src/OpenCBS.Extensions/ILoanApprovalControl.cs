﻿using System;
using System.Windows.Forms;
using OpenCBS.Enums;

namespace OpenCBS.Extensions
{
    public interface ILoanApprovalControl
    {
        Control GetControl();
        void Init(int? loanId, OClientTypes clientType);

        string Comment { get; set; }
        string Code { get; set; }
        DateTime Date { get; set; }
        OContractStatus Status { get; set; }
        Action SaveLoanApproval { get; set; }
    }
}
