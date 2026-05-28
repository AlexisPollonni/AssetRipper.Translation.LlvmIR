using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 10)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm1EEE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.2381")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("Fputil_ExceptValues")]
public partial struct Fputil_ExceptValues_yv4gxk
{
	[FieldOffset(0)]
	public InlineArray1_Fputil_ExceptValues_Float16_21_Mapping Values;
}
