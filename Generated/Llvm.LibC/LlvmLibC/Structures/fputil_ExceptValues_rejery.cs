using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 160)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm16EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.5274")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_rejery
{
	[FieldOffset(0)]
	public InlineArray8_fputil_ExceptValues_float_6_Mapping values;
}
