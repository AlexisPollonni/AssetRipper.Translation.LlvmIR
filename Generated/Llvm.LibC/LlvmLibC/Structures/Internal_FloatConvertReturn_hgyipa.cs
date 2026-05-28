using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIeEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::FloatConvertReturn.14")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn")]
[CleanName("Internal_FloatConvertReturn")]
public partial struct Internal_FloatConvertReturn_hgyipa
{
	[FieldOffset(0)]
	public Internal_ExpandedFloat_9jummq Num;

	[FieldOffset(32)]
	public int Error;

	[FieldOffset(36)]
	public InlineArray12_SByte field_2;
}
