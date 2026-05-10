using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 14688)]
[MangledName("struct.__llvm_libc_20_1_2_::LogRR")]
[DemangledName("__llvm_libc_20_1_2_::LogRR")]
public partial struct LogRR
{
	[FieldOffset(0)]
	public InlineArray128_fputil_DyadicFloat_kt2kd4 step_1;

	[FieldOffset(3072)]
	public InlineArray193_fputil_DyadicFloat_kt2kd4 step_2;

	[FieldOffset(7704)]
	public InlineArray161_fputil_DyadicFloat_kt2kd4 step_3;

	[FieldOffset(11568)]
	public InlineArray130_fputil_DyadicFloat_kt2kd4 step_4;
}
