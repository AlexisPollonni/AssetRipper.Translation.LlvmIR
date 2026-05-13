using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 80)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.5800")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_wpg668
{
	[FieldOffset(0)]
	public InlineArray4_fputil_ExceptValues_float_6_Mapping values;
}
