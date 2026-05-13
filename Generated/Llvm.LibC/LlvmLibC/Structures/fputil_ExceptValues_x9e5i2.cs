using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 120)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::ExceptValues.2751")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues")]
[CleanName("fputil_ExceptValues")]
public partial struct fputil_ExceptValues_x9e5i2
{
	[FieldOffset(0)]
	public InlineArray6_fputil_ExceptValues_float_6_Mapping values;
}
