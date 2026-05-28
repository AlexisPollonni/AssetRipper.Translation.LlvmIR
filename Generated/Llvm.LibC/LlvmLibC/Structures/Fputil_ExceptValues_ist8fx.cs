using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 110)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm11EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.1477")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("Fputil_ExceptValues")]
public partial struct Fputil_ExceptValues_ist8fx
{
	[FieldOffset(0)]
	public InlineArray11_Fputil_ExceptValues_Float16_21_Mapping Values;
}
