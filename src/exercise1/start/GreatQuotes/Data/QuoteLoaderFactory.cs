using System;
using System.Collections.Generic;
using System.Text;
using GreatQuotes.Data;


namespace GreatQuotes
{
    public static class QuoteLoaderFactory
    {
        public static Func<IQuoteLoader> Create { get; set; }
    }
}
