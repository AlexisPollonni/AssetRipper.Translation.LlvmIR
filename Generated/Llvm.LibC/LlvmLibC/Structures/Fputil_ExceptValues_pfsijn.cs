using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 40)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm4EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1233")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("Fputil_ExceptValues")]
public partial struct Fputil_ExceptValues_pfsijn
{
	[FieldOffset(0)]
	public InlineArray4_Fputil_ExceptValues_Float16_21_Mapping Values;
}
