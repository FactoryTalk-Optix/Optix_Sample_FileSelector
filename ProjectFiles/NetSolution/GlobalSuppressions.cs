// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;
using FTOptix.DataLogger;
using FTOptix.Store;
using FTOptix.SQLiteStore;
using FTOptix.Report;

[assembly: SuppressMessage("Minor Code Smell", "S1450:Private fields only used as local variables in methods should become local variables", Justification = "<Pending>", Scope = "member", Target = "~F:FileSystemBrowserDataGridLogic.locationsObject")]
[assembly: SuppressMessage("Major Bug", "S3903:Types should be defined in named namespaces", Justification = "<Pending>", Scope = "type", Target = "~T:Location")]
