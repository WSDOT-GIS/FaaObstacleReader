using System;

namespace FaaObstruction
{
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class ColumnsAttribute : Attribute
	{
		// This is a positional argument
		public ColumnsAttribute(int startColumn, int? endColumn=null)
		{
			this.StartColumn = startColumn;
			this.EndColumn = endColumn.HasValue && endColumn.Value >= startColumn ? endColumn.Value : startColumn;
		}

		public int StartColumn { get; set; }
		public int EndColumn { get; set; }

	}
}
