﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PlexePublicAPIDemo.Common.Model
{
    public class LoanTransaction
    {
        public object contentType { get; set; }
        public object serializerSettings { get; set; }
        public object statusCode { get; set; }
        public List<LoanTransactionValue> value { get; set; }
    }
    public class LoanTransactionValue
    {
        public DateTime Date { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public AmountResponse Amount { get; set; }

        public bool IsCredit { get; set; }

        public AmountResponse Balance { get; set; }

    }
}
