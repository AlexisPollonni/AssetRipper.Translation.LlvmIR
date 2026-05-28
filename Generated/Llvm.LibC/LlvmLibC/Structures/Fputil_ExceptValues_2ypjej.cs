using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 160)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm16EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1211")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("Fputil_ExceptValues")]
public partial struct Fputil_ExceptValues_2ypjej
{
	[FieldOffset(0)]
	public InlineArray16_Fputil_ExceptValues_Float16_21_Mapping Values;
}
