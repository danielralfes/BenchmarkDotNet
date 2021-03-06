﻿using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Horology;

namespace BenchmarkDotNet.Reports
{
    public interface ISummaryStyle
    {
        bool PrintUnitsInHeader { get; }
        bool PrintUnitsInContent { get; }
        SizeUnit SizeUnit { get; }
        TimeUnit TimeUnit { get; }

        ISummaryStyle WithTimeUnit(TimeUnit timeUnit);
        ISummaryStyle WithSizeUnit(SizeUnit sizeUnit);
    }
}