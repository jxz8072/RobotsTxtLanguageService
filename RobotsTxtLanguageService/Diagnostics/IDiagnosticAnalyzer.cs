﻿using System;
using System.ComponentModel.Composition;

namespace RobotsTxtLanguageService.Diagnostics
{
    public interface IDiagnosticAnalyzer
    {
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class ExportDiagnosticAnalyzer : ExportAttribute
    {
        public ExportDiagnosticAnalyzer()
            : base(typeof(IDiagnosticAnalyzer))
        { }
    }
}
