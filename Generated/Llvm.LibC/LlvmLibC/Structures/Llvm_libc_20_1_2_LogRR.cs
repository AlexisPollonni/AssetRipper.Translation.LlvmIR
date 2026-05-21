using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 14688)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_5LogRRE")]
[MangledName("struct.__llvm_libc_20_1_2_::LogRR")]
[DemangledName("__llvm_libc_20_1_2_::LogRR")]
public partial struct Llvm_libc_20_1_2_LogRR
{
	[FieldOffset(0)]
	public InlineArray128_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Step_1;

	[FieldOffset(3072)]
	public InlineArray193_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Step_2;

	[FieldOffset(7704)]
	public InlineArray161_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Step_3;

	[FieldOffset(11568)]
	public InlineArray130_Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 Step_4;
}
