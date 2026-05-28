using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 80)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm8EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.2505")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("Fputil_ExceptValues")]
public partial struct Fputil_ExceptValues_ztktch
{
	[FieldOffset(0)]
	public InlineArray8_Fputil_ExceptValues_Float16_21_Mapping Values;
}
