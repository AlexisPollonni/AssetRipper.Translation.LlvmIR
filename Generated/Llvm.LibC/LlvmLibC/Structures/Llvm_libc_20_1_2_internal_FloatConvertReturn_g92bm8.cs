using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal18FloatConvertReturnIdEE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::FloatConvertReturn")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn")]
[CleanName("Llvm_libc_20_1_2_internal_FloatConvertReturn")]
public partial struct Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8
{
	[FieldOffset(0)]
	public Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv Num;

	[FieldOffset(16)]
	public int Error;

	[FieldOffset(20)]
	public InlineArray4_SByte field_2;
}
